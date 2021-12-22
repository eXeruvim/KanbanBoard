using KanbanBoard.Server;
using KanbanBoard.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Runtime.InteropServices;
using KanbanBoard.Utils;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace KanbanBoard.Forms
{
    public partial class MainChildFormBoards : Form
    {
        public static string key { get; set; }
        private int Counter, TickCount;


        public MainChildFormBoards()
        {
            InitializeComponent();
            SetDoubleBuffered(Board);
            Program.mainChildFormBoards = this;
            Board.ColumnStyles.Clear();
            Board.RowStyles.Clear();
            Board.ColumnCount = 1;
            Board.RowCount = 1;
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(Board, true, null);
            Board.Resize += (s, a) => ResizeTable();
        }

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

            // Изменить название
            titlePanel.TitleColumnLabel.Click += (s, a) =>
            {
                if (!Application.OpenForms.OfType<ChangePanelNameForm>().Any())
                    new ChangePanelNameForm(this, titlePanel).Show();
            };

            // Добавить строку
            titlePanel.PlusButton.Click += (s, a) =>
            {
                for (var row = 1; row <= Board.RowStyles.Count; row++)
                {
                    if (!(Board.GetControlFromPosition(column, row) is null)) continue;
                    AddControlToPanel("Название", "Описание", "Участники", column, row);
                    break;
                }
            };

            // Удалить столбец
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
                if (Board.Controls.Count == 0)
                {
                    Board.ColumnStyles.Clear();
                    Board.RowStyles.Clear();
                    Board.ColumnCount = 1;
                    Board.RowCount = 1;
                }
                ResizeTable();
            };

            // Изменить название панели
            titlePanel.Click += (s, a) =>
            {
                if (!Application.OpenForms.OfType<ChangePanelNameForm>().Any())
                    new ChangePanelNameForm(this, titlePanel).Show();
            };
            //SaveIn(key); // для теста
        }


        private void AddControlToPanel(Control control, int column, int row)
        {
            control.Name = $"ticket{column}{row}";

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

        private void AddControlToPanel(string title, string description, string member, int column, int row)
        {
            var control = new Ticket();
            control.Title.Text = title;
            control.Description.Text = description;
            control.Member.Text = member;
            SetEvents(control);

            control.Name = $"ticket{column}{row}";

            // Нужно ли добавлять что-то
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
                Board.Controls.OfType<Ticket>().ToList().ForEach(x => x.Width = Board.Width / Board.ColumnCount);
                Board.RowStyles[0].SizeType = SizeType.Absolute;
                Board.RowStyles[0].Height = 25;

                foreach (var row in Board.RowStyles.Cast<RowStyle>().ToList().Skip(1))
                {
                    row.SizeType = SizeType.Percent;
                    row.Height = 5;
                }

                Board.Controls.OfType<Ticket>().ToList().ForEach(x =>
                {
                    if (Board.GetCellPosition(x).Row != 0) x.Height = Board.Height / Board.RowCount;
                });
                SaveIn(key);
            }
            catch (Exception e) { }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ((Control)sender).DoDragDrop(sender, DragDropEffects.All);
        }

        // События на кнопки
        private void SetEvents(Ticket ticketPanel)
        {

            // Вызов редактирования 
            ticketPanel.MouseDown += (sender, args) =>
            {
                if (!Application.OpenForms.OfType<ChangeTicketForm>().Any() && args.Button == MouseButtons.Right) new ChangeTicketForm(this, ticketPanel).Show();
            };

            // Удаление столбца
            ticketPanel.DelButton.Click += (sender, args) => Board.Controls.Remove(ticketPanel);

            ticketPanel.MouseDown += Panel_MouseDown;
        }

        private void Board_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Ticket)))
                e.Effect = DragDropEffects.All;
        }

        Point ptOriginal = Point.Empty;

        private void Board_DragOver(object sender, DragEventArgs e)
        {
            ((Control)e.Data.GetData(typeof(Ticket))).Location =
            this.PointToClient(new Point(e.X - ptOriginal.X, e.Y - ptOriginal.Y));
            ((Control)e.Data.GetData(typeof(Ticket))).BringToFront();
        }

        private void Board_DragDrop(object sender, DragEventArgs e)
        {
            Ticket ticketpanel = e.Data.GetData(typeof(Ticket)) as Ticket;
            Point loc = this.Board.PointToClient(new Point(e.X, e.Y));
            int columnInd = -1;
            int rowInd = -1;
            int x = 0;
            int y = 0;
            while (columnInd <= this.Board.ColumnStyles.Count)
            {
                if (loc.X < x)
                {
                    break;
                }
                columnInd++;
                x += this.Board.GetColumnWidths()[columnInd];
            }
            while (rowInd <= this.Board.RowStyles.Count)
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


        private void SaveIn(string project)
        {
            if (Board.Controls.Count == 0) return;
            var allData = new Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>>();
            var projectName = project;
            var columnDate = new Dictionary<string, List<Dictionary<string, string>>>();
            for (var column = 0; column < Board.ColumnStyles.Count; column++)
            {
                var ticket = new List<Dictionary<string, string>>();

                for (var row = 1; row < Board.RowStyles.Count; row++)
                {
                    if (Board.GetControlFromPosition(column, row) != null)
                        ticket.Add(new Dictionary<string, string>()
                        {
                            {"Title", ((Ticket)Board.GetControlFromPosition(column, row)).Title.Text},
                            {"Description", ((Ticket)Board.GetControlFromPosition(column, row)).Description.Text },
                            {"Member", ((Ticket)Board.GetControlFromPosition(column, row)).Member.Text}
                        });
                }

                if ((Panels)Board.GetControlFromPosition(column, 0) != null)
                    columnDate.Add($"{column + 1}-" + ((Panels)Board.GetControlFromPosition(column, 0)).TitleColumnLabel.Text, ticket);
            }
            allData.Add(projectName, columnDate);
            // Сохранение в Firebase
            Firebase.Save(allData);
        }
    }
}
