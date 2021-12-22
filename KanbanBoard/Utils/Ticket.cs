using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KanbanBoard.Utils
{
    public sealed class Ticket : Panel
    {
        public Label Title { get; set; }
        public Label Member { get; set; }
        public Label Description { get; set; }
        public Button DelButton { get; set; }

        public Ticket()
        {
            // Свойства панели
            Dock = DockStyle.Fill;
            BackColor = GetColor();
            AutoSize = true;
            DoubleBuffered = true;

            // Название, участники
            Title = new Label()
            {
                Name = "Title",
                Text = "Название",
                Font = new Font("Lucida Sans Unicode", 12f, FontStyle.Bold),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height - Size.Height + 5),
                Margin = new Padding(20, 20, 40, 20),
            };

            Description = new Label()
            {
                Name = "Description",
                Text = "Описание",
                Font = new Font("Lucida Sans Unicode", 12f, FontStyle.Bold),
                Margin = new Padding(5),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height / 2),
            };

            Member = new Label()
            {
                Name = "Member",
                Text = "Разработчики",
                Margin = new Padding(5),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height - 5),
            };


            new List<Label> { Title, Description, Member }.ForEach(x =>
            {
                x.ForeColor = Color.Black;
                x.AutoSize = true;
            });

            DelButton = new Button()
            {
                Name = "delButton",
                Text = "Х",
                Font = new Font("Tahoma", 7.5f),
            };

            new List<Button>() { DelButton}.ForEach(x =>
             {
                 x.BackColor = Color.Transparent;
                 x.FlatAppearance.MouseDownBackColor = Color.Transparent;
                 x.FlatAppearance.MouseOverBackColor = Color.Transparent;
                 x.AutoSize = true;
                 x.Size = new Size(15, 15);
                 x.FlatStyle = FlatStyle.Flat;
                 x.FlatAppearance.BorderSize = 0;
                 x.ForeColor = Color.Black;
                 x.MouseEnter += (s, a) => x.ForeColor = Color.Red;
                 x.MouseLeave += (s, a) => x.ForeColor = Color.Black;
             });

            Controls.AddRange(new Control[] { DelButton });
            Controls.AddRange(new Control[] { Title, Description, Member });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            BeginInvoke((MethodInvoker)(() =>
            {
                // Расположение текста
                Title.Location = new Point(Size.Width - Size.Width + 5, Size.Height - Size.Height + 15);
                Description.Location = new Point(Size.Width - Size.Width + 5, Title.Location.Y + 50);
                Member.Location = new Point(Size.Width - Size.Width + 5, Size.Height - 50);

                // Расположение кнопки
                DelButton.Location = new Point(Size.Width - DelButton.Size.Width, 0);
                
                new List<Control> { Title, Description, Member }.ForEach(x => x.MaximumSize = new Size(Size.Width - 5, Size.Height));
            }));
        }
        public static Color GetColor() => Color.Yellow;
    }
}
