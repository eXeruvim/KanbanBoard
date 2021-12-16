using KanbanBoard.Utils;
using System;
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

            Board.ColumnStyles.Clear();
            Board.RowStyles.Clear();
            Board.ColumnCount = 1;
            Board.RowCount = 1;
            //  this.DoubleBuffered = true;
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
            AddControlToPanel("", "", "", column, 1);
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
                    AddControlToPanel("", "", "", column, row);
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

        private void SetEventsOnTicket(TicketPanel ticketPanel)
        {
            // Событие по клику на каждый тикет. Открывает панель для выполнения изменений выбранного тикета
            ticketPanel.Click += (sender, args) =>
            {
                // Показ панели. Возврат к тикетам. Масштабируемость
                if (!Application.OpenForms.OfType<EditPanel>().Any()) new EditPanel(this, ticketPanel).Show();
            };

            // Удаление тикета
            ticketPanel.DelButton.Click += (sender, w) => Board.Controls.Remove(ticketPanel);
        }

    }
}
