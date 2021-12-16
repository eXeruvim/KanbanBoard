using KanbanBoard.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.Forms
{
    public partial class MainChildFormBoards : Form
    {
        public MainChildFormBoards()
        {
            InitializeComponent();
            SetDoubleBuffered(Board);
            Program.mainChildFormBoards = this;
            Board.ColumnStyles.Clear();
            Board.RowStyles.Clear();
            Board.ColumnCount = 1;
            Board.RowCount = 1;
            //  this.DoubleBuffered = true;
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(Board, true, null);
            Board.Resize += (s, a) => ResizeTable();
        }
        Point downPoint;
        bool moved;
        Dictionary<TableLayoutPanelCellPosition, Rectangle> dict = new Dictionary<TableLayoutPanelCellPosition, Rectangle>();

        public void AddPanel()
        {
            var column = 0;
            for (var boardColumns = 0; boardColumns <= Board.ColumnStyles.Count; boardColumns++)
            {
                if (!(Board.GetControlFromPosition(boardColumns, 0) is null))
                    continue;

                column = Board.ColumnStyles.Count;
                break;
            }

            if (Board.ColumnStyles.Count > 1 && column == 0)
                column = Board.ColumnStyles.Count;
            AddTitleToPanel("Название", column);
            AddControlToPanel("Название", "Описание", "Участники", column, 1);
        }

        private void AddTitleToPanel(string textOfLabel, int column)
        {
            var titlePanel = new Panels { Name = $"title{column}{0}" };
            titlePanel.TitleColumnLabel.Text = textOfLabel;


            Board.SuspendLayout();
            if (Board.ColumnStyles.Count <= column)
            {
                Board.ColumnCount++;
                Board.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
            Board.Controls.Add(titlePanel, column, 0);
            Board.ResumeLayout();

            // Изменить заголовок
            titlePanel.TitleColumnLabel.Click += (s, a) =>
            {
                if (!Application.OpenForms.OfType<ChangeTitleForm>().Any())
                    new ChangeTitleForm(this, titlePanel).Show();
            };

            // Добавляем события на кнопки
            titlePanel.PlusButton.Click += (s, a) =>
            {
                for (var row = 1; row <= Board.RowStyles.Count; row++)
                {
                    if (!(Board.GetControlFromPosition(column, row) is null)) continue;
                    AddControlToPanel("Название", "Описание", "Участники", column, row);
                    break;
                }
            };

            // Удалить колонку
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
                        AddControlToPanel(Board.GetControlFromPosition(col, row), col - 1, row);
                    }
                }

                if (Board.ColumnStyles.Count == Board.ColumnCount) Board.ColumnStyles.RemoveAt(Board.ColumnCount - 1);
                Board.ColumnCount--;
                ResizeTable();
            };

            // Изменить заголовок
            titlePanel.Click += (s, a) =>
            {
                if (!Application.OpenForms.OfType<ChangeTitleForm>().Any())
                    new ChangeTitleForm(this, titlePanel).Show();
            };
        }


        private void AddControlToPanel(Control control, int column, int row)
        {
            // Инициализация имени панели тикета
            control.Name = $"ticket{column}{row}";

            // Нужно ли добавлять доп. строки и/или колонки
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

        private void AddControlToPanel(string title, string ticket, string people, int column, int row)
        {
            var control = new TicketPanel();
            control.Title.Text = title;
            control.Ticket.Text = ticket;
            control.People.Text = people;
            SetEventsOnTicket(control);
            //SetEvents(control);
            // Инициализация имени панели тикета
            control.Name = $"ticket{column}{row}";

            // Нужно ли добавлять доп. строки и/или колонки
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

                // Строки
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
            catch (Exception e) { Console.WriteLine("Ошибка" + e.Message); }
        }

        private void SetEvents(TicketPanel panel)
        {

            panel.MouseDown += Panel_MouseDown;
            /*panel.MouseMove += Panel_MouseMove;
            panel.MouseUp += Panel_MouseUp;
            */
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            Control panel = sender as Control;
            if (moved)
            {
                SetControl(panel, e.Location);
                panel.Parent = Board;
                moved = false;
                ResizeTable();
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ((Control)sender).DoDragDrop(sender, DragDropEffects.All);
            /*
            Control panel = sender as Control;
            panel.Parent = this;
            panel.BringToFront();
            downPoint = e.Location;
            ResizeTable();
            */
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Control panel = sender as Control;
            if (e.Button == MouseButtons.Left)
            {
                panel.Left += e.X - downPoint.X;
                panel.Top += e.Y - downPoint.Y;
                moved = true;
                Board.Invalidate();
                ResizeTable();
            }
        }
        private void SetControl(Control c, Point position)
        {
            Point localPoint = Board.PointToClient(c.PointToScreen(position));
            var keyValue = dict.FirstOrDefault(e => e.Value.Contains(localPoint));
            if (!keyValue.Equals(default(KeyValuePair<TableLayoutPanelCellPosition, Rectangle>)))
            {
                Board.SetCellPosition(c, keyValue.Key);
                ResizeTable();
            }
        }

        // События на кнопки
        private void SetEventsOnTicket(TicketPanel ticketPanel)
        {
            
            // Событие по клику на каждый тикет. Открывает панель для выполнения изменений выбранного тикета
            ticketPanel.MouseDown += (sender, args) =>
            {
                // Показ панели. Возврат к тикетам. Масштабируемость
                if (!Application.OpenForms.OfType<TicketsChangeForm>().Any() && args.Button == MouseButtons.Right) new TicketsChangeForm(this, ticketPanel).Show();
            };
            // Удаление тикета
            ticketPanel.DelButton.Click += (sender, w) => Board.Controls.Remove(ticketPanel);

            ticketPanel.MouseDown += Panel_MouseDown;
        }

        private void Board_DragEnter(object sender, DragEventArgs e)
        {
           if (e.Data.GetDataPresent(typeof(TicketPanel)))
               e.Effect = DragDropEffects.All;
        }
        Point ptOriginal = Point.Empty;
        private void Board_DragOver(object sender, DragEventArgs e)
        {
            ((Control)e.Data.GetData(typeof(TicketPanel))).Location =
            this.PointToClient(new Point(e.X - ptOriginal.X, e.Y - ptOriginal.Y));
            ((Control)e.Data.GetData(typeof(TicketPanel))).BringToFront();
        }

        private void Board_DragDrop(object sender, DragEventArgs e)
        {
            TicketPanel ticketpanel = e.Data.GetData(typeof(TicketPanel)) as TicketPanel;
            Point loc = this.Board.PointToClient(new Point(e.X, e.Y));
            int columnInd = -1;
            int rowInd = -1;
            int x = 0;
            int y = 0;
            while(columnInd <= this.Board.ColumnStyles.Count)
            {
                if (loc.X < x)
                {
                    break;
                }
                columnInd++;
                x += this.Board.GetColumnWidths()[columnInd];
            }
            while(rowInd <= this.Board.RowStyles.Count)
            {
                if (loc.Y < y)
                {
                    break;
                }
                rowInd++;
                y += this.Board.GetRowHeights()[rowInd];
            }
            this.Board.Controls.Add(ticketpanel, columnInd, rowInd);
        }
    }
}
