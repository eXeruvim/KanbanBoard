using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KanbanBoard.Utils
{
    public sealed class Panels : Panel
    {
        public Label TitleColumnLabel { get; set; }
        public Button PlusButton { get; set; }
        public Button DelColumnButton { get; set; }
        public Panels()
        {
            // Свойства панели
            Dock = DockStyle.Fill;
            AutoSize = true;
            DoubleBuffered = true;

            TitleColumnLabel = new Label()
            {
                Dock = DockStyle.Left,
                Text = "Title of Column",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 9.75F, FontStyle.Regular),
                ForeColor = Color.FromArgb(160, 160, 160),
                AutoSize = true,
            };

            PlusButton = new Button()
            {
                Dock = DockStyle.Right,
                Text = "➕",
                Font = new Font("Tahoma", 7.5f),
                Size = new Size(15, 15),
                ForeColor = TicketPanel.GetColor()
            };
            DelColumnButton = new Button()
            {
                Dock = DockStyle.Right,
                Text = "✖",
                Font = PlusButton.Font,
                Size = PlusButton.Size,
                ForeColor = PlusButton.ForeColor
            };

            new List<Button>() { PlusButton, DelColumnButton }.ForEach(x =>
            {
                x.BackColor = Color.Transparent;
                x.FlatAppearance.MouseDownBackColor = Color.Transparent;
                x.FlatAppearance.MouseOverBackColor = Color.Transparent;
                x.AutoSize = true;
                x.Size = new Size(25, 25);
                x.FlatStyle = FlatStyle.Flat;
                x.FlatAppearance.BorderSize = 0;
                x.MouseEnter += (s, a) => x.ForeColor = Color.Red;
                x.MouseLeave += (s, a) => x.ForeColor = TicketPanel.GetColor();
            });

            Controls.AddRange(new Control[] { TitleColumnLabel, PlusButton, DelColumnButton });
        }
    }
}
