﻿using KanbanBoard.Utils;
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
            AddControlToPanel("Название", "", "Участники", column, 1);
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
                    AddControlToPanel("Название", "", "Участники", column, row);
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
                ResizeTable();
            };

            // Изменить название панели
            titlePanel.Click += (s, a) =>
            {
                if (!Application.OpenForms.OfType<ChangePanelNameForm>().Any())
                    new ChangePanelNameForm(this, titlePanel).Show();
            };
        }


        private void AddControlToPanel(Control control, int column, int row)
        {
            control.Name = $"ticket{column}{row}";

            // Нужно ли добавлять доп. строки и/или столбцы
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
            catch (Exception e) { }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ((Control)sender).DoDragDrop(sender, DragDropEffects.All);
        }

        // События на кнопки
        private void SetEventsOnTicket(TicketPanel ticketPanel)
        {
            
            // Вызов редактирования 
            ticketPanel.MouseDown += (sender, args) =>
            {
                // Показ панели. Возврат к тикетам. Масштабируемость
                if (!Application.OpenForms.OfType<TicketsChangeForm>().Any() && args.Button == MouseButtons.Right) new TicketsChangeForm(this, ticketPanel).Show();
            };

            ticketPanel.AddButton.Click += (sender, args) =>
            {
                var contr = ticketPanel.Controls.OfType<CheckBox>().Count();
                if (contr != 8)
                {
                    CheckBox Task = new CheckBox()
                    {
                        Name = "Task",
                        Text = "Задача",
                        Font = new Font("Lucida Sans Unicode", 10f),
                        Margin = new Padding(20, 20, 40, 20),
                        Location = new Point(Size.Width - Size.Width + 10, Size.Height / 2),
                        Top = 40 + contr * 25,
                    };
                    ticketPanel.Controls.Add(Task);
                }
                else
                {
                    MessageBox.Show("Достигнут лимит задач в одном тикете!");
                }
            };

            // Удаление тикета
            ticketPanel.DelButton.Click += (sender, args) => Board.Controls.Remove(ticketPanel);

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
