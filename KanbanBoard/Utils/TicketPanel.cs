using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KanbanBoard.Utils
{
    public sealed class TicketPanel : Panel
    {
        public Label Title { get; set; }
        public Label Ticket { get; set; }
        public Label People { get; set; }
        public Button DelButton { get; set; }

        public TicketPanel()
        {
            // Свойства панели
            Dock = DockStyle.Fill;
            BackColor = GetColor();
            AutoSize = true;
            DoubleBuffered = true;

            // Заголовок, текст, исполнители (может быть изменено). Из чего-то мб сделать другой контрол
            Title = new Label()
            {
                Name = "Title",
                Text = "Заголовок",
                Font = new Font("Tahoma", 9.25f, FontStyle.Bold),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height - Size.Height + 5),
                Margin = new Padding(20, 20, 40, 20),
            };
            Ticket = new Label()
            {
                Name = "Ticket",
                Text = "Текст тикета",
                Margin = new Padding(5),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height / 2),
            };
            People = new Label()
            {
                Name = "People",
                Text = "Разработчики",
                Margin = new Padding(5),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height - 5),
            };
            new List<Label> { Title, Ticket, People }.ForEach(x =>
            {
                x.ForeColor = Color.Black;
                x.AutoSize = true;
            });

            // Добавляем панель с кнопками перемещений и удаления тикета
            // кнопка удаления тикета, перемещения ВПРАВО, перемещения ВЛЕВО
            DelButton = new Button()
            {
                Name = "delButton",
                Text = "✖",
                Font = new Font("Tahoma", 7.5f),
            };
            new List<Button>() { DelButton }.ForEach(x =>
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
            Controls.AddRange(new Control[] { Title, Ticket, People });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            BeginInvoke((MethodInvoker)(() =>
            {
                // Изменение локаций лейблов в панели
                Title.Location = new Point(Size.Width - Size.Width + 5, Size.Height - Size.Height + 15);
                Ticket.Location = new Point(Size.Width - Size.Width + 5, Title.Location.Y + 50);
                People.Location = new Point(Size.Width - Size.Width + 5, Size.Height - 50);

                // кнопок
                DelButton.Location = new Point(Size.Width - DelButton.Size.Width, 0);
                new List<Control> { Title, Ticket, People }.ForEach(x => x.MaximumSize = new Size(Size.Width - 5, Size.Height));
            }));
        }
        public static Color GetColor() => Color.Yellow;
    }
}
