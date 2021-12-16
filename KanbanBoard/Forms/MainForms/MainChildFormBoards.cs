using KanbanBoard.Forms.MainForms;
using KanbanBoard.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KanbanBoard.Forms
{
    public partial class MainChildFormBoards : Form
    {
        public MainChildFormBoards()
        {
            Program.mainChildFormBoards = this;
            InitializeComponent();
            SetDoubleBuffered(Board);

            Board.ColumnStyles.Clear();
            Board.RowStyles.Clear();
            Board.ColumnCount = 1;
            Board.RowCount = 1;
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(Board, true, null);
            Board.Resize += (s, a) => ResizeTable();
        }

        Point downPoint;
        bool moved;
        Dictionary<TableLayoutPanelCellPosition, Rectangle> dict = new Dictionary<TableLayoutPanelCellPosition, Rectangle>();

        public void addPanel()
        {
            int column = 0;
            for (int boardColumns = 0; boardColumns <= Board.ColumnStyles.Count; boardColumns++)
            {
                if (!(Board.GetControlFromPosition(boardColumns, 0) is null))
                    continue;

                column = Board.ColumnStyles.Count;
                break;
            }

            if (Board.ColumnStyles.Count > 1 && column == 0)
                column = Board.ColumnStyles.Count;

            addTitle("Название", column);
            addControl("Название", "Описание", "Участники", column, 1);
        }

        private void addTitle(String textOfLabel, int column)
        {
            var titlePanel = new TitlePanel { Name = $"title{column}{0}" };
            titlePanel.TitleColumnLabel.Text = textOfLabel;


            Board.SuspendLayout();
            if (Board.ColumnStyles.Count <= column)
            {
                Board.ColumnCount++;
                Board.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
            Board.Controls.Add(titlePanel, column, 0);
            Board.ResumeLayout();

            titlePanel.TitleColumnLabel.Click += (s, a) =>
            {
                if (!Application.OpenForms.OfType<ChangeTitleForm>().Any())
                    new ChangeTitleForm(this, titlePanel).Show();
            };
            // Кнопки
            titlePanel.PlusButton.Click += (s, a) =>
            {
                for (var row = 1; row <= Board.RowStyles.Count; row++)
                {
                    if (!(Board.GetControlFromPosition(column, row) is null)) continue;
                    addControl("", "", "", column, row);
                    break;
                }
            };
            // Удалить
            titlePanel.DelColumnButton.Click += (s, a) =>
            {
                for (var i = 1; i < Board.ColumnStyles.Count; i++)
                {
                    var control = Board.GetControlFromPosition(Board.GetPositionFromControl(titlePanel).Column, i);
                    Board.Controls.Remove(control);
                }

                var col = Board.GetPositionFromControl(titlePanel).Column;
                Board.Controls.Remove(titlePanel);

                for (; col < Board.ColumnStyles.Count; col++)
                {
                    for (var row = 0; row < Board.RowStyles.Count; row++)
                    {
                        if (Board.GetControlFromPosition(col, row) == null) continue;
                        addControl(Board.GetControlFromPosition(col, row), col - 1, row);
                    }
                }

                if (Board.ColumnStyles.Count == Board.ColumnCount) Board.ColumnStyles.RemoveAt(Board.ColumnCount - 1);
                Board.ColumnCount--;
                ResizeTable();
            };
            titlePanel.Click += (s, a) =>
            {
                if (!Application.OpenForms.OfType<ChangeTitleForm>().Any())
                    new ChangeTitleForm(this, titlePanel).Show();
            };
        }


        private void addControl(Control control, int column, int row)
        {
            control.Name = $"ticket{column}{row}";

            // Проверка на необходимость увеличения размеров TableLayoutPanel
            if (Board.RowStyles.Count <= row)
            {
                Board.RowCount++;
                Board.RowStyles.Add(new RowStyle(SizeType.Percent));
            }

            if (Board.ColumnStyles.Count <= column)
            {
                Board.ColumnCount++;
                Board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            }

            Board.SuspendLayout();
            Board.Controls.Add(control, column, row);
            Board.ResumeLayout();

            ResizeTable();
        }

        private void addControl(string title, string ticket, string people, int column, int row)
        {
            var control = new TicketPanel();
            control.Title.Text = title;
            control.Ticket.Text = ticket;
            control.People.Text = people;
            SetEventsOnPanel(control);

            control.Name = $"ticket{column}{row}";

            // Проверка на необходимость увеличения размеров TableLayoutPanel
            if (Board.RowStyles.Count <= row)
            {
                Board.RowCount++;
                Board.RowStyles.Add(new RowStyle(SizeType.Percent));
            }

            if (Board.ColumnStyles.Count <= column)
            {
                Board.ColumnCount++;
                Board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            }

            Board.SuspendLayout();
            Board.Controls.Add(control, column, row);
            Board.ResumeLayout();

            ResizeTable();
        }

        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            var aProp = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            aProp?.SetValue(c, true, null);
        }

        private void ResizeTable()
        {
            try
            {
                foreach (ColumnStyle column in Board.ColumnStyles)
                {
                    column.SizeType = SizeType.Percent;
                    column.Width = 25;
                }
                Board.Controls.OfType<TicketPanel>().ToList().ForEach(x => x.Width = Board.Width / Board.ColumnCount);
                Board.RowStyles[0].SizeType = SizeType.Absolute;
                Board.RowStyles[0].Height = 25;

                foreach (var row in Board.RowStyles.Cast<RowStyle>().ToList().Skip(1))
                {
                    row.SizeType = SizeType.Percent;
                    row.Height = 5;
                }

                Board.Controls.OfType<TicketPanel>().ToList().ForEach(x =>
                {
                    if (Board.GetCellPosition(x).Row != 0) x.Height = Board.Height / Board.RowCount;
                });
            }
            catch (Exception e) {}
        }


        private void SetEventsOnPanel(TicketPanel ticketPanel)
        {
            ticketPanel.MouseDown += TicketPanel_MouseDown;

            ticketPanel.MouseMove += TicketPanel_MouseMove;

            ticketPanel.MouseUp += TicketPanel_MouseUp;

            ticketPanel.DoubleClick += (sender, args) =>
            {
                // Показ панели. Возврат к тикетам. Масштабируемость
                if (!Application.OpenForms.OfType<TicketsChangeForm>().Any()) new TicketsChangeForm(this, ticketPanel).Show();
            };

            ticketPanel.DelButton.Click += (sender, w) => Board.Controls.Remove(ticketPanel);
        }

        private void TicketPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Control panel = sender as Control;
            if (moved)
            {
                SetControl(panel, e.Location);
                panel.Parent = Board;
                ResizeTable();
                moved = false;
            }
        }

       
        private void SetControl(Control c, Point position)
        {
            Point localPoint = Board.PointToClient(c.PointToScreen(position));
            var keyValue = dict.FirstOrDefault(e => e.Value.Contains(localPoint));
            if (!keyValue.Equals(default(KeyValuePair<TableLayoutPanelCellPosition, Rectangle>)))
            {
                Board.SetCellPosition(c, keyValue.Key);
            }
        }

        private void TicketPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Control panel = sender as Control;
            if (e.Button == MouseButtons.Left)
            {
                panel.Left += e.X - downPoint.X;
                panel.Top += e.Y - downPoint.Y;
                moved = true;
                ResizeTable();
                Board.Invalidate();
            }
        }

        private void TicketPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Control panel = sender as Control;
            panel.Parent = this;
            panel.BringToFront();
            downPoint = e.Location;
            ResizeTable();
        }

        private void Board_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            dict[new TableLayoutPanelCellPosition(e.Column, e.Row)] = e.CellBounds;
            if (moved)
            {
                if (e.CellBounds.Contains(Board.PointToClient(MousePosition)))
                {
                    e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds);
                }
            }
        }
    }
}
