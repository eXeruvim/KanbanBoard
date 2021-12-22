using KanbanBoard.Utils;
using System;
using System.Windows.Forms;

namespace KanbanBoard.Forms
{
    public partial class ChangeTicketForm : Form
    {
        public new MainChildFormBoards Owner { get; }
        private readonly Ticket _ticket;

        public ChangeTicketForm(MainChildFormBoards owner, Ticket ticket)
        {
            Owner = owner;
            _ticket = ticket;
            InitializeComponent();

            Resize += (o, eventArgs) => ChangingPanel.ToCenter(this);

            KeyDown += (s, a) => {
                if (a.KeyValue == (int)Keys.Enter || a.KeyValue == (int)Keys.Escape) SaveChangesButton.PerformClick();
            };
        }

        // Изменяем при нажатии на кнопку сохранения
        private void SaveChangesButton_Click(object sender, EventArgs e) => Close();

        // Показываем значения лейблов тикета
        private void TicketsChangeForm_Load(object sender, EventArgs e)
        {
            ChangingTitleTextBox.Text = _ticket.Title.Text;
            ChangeTicketForm_richTextBox.Text = _ticket.Description.Text;
            ChangingMemberTextBox.Text = _ticket.Member.Text;
        }

        // Сохранить при закрытии
        private void TicketsChangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ticket.Title.Text = ChangingTitleTextBox.Text;
            _ticket.Description.Text = ChangeTicketForm_richTextBox.Text;
            _ticket.Member.Text = ChangingMemberTextBox.Text;
        }
    }
}
