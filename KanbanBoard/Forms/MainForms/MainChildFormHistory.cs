using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;
using KanbanBoard.Server;
using KanbanBoard.Forms;

namespace KanbanBoard.Forms
{
    public partial class MainChildFormHistory : Form
    {
        public MainChildFormHistory()
        {
            InitializeComponent();
            getProject(Auth.log);
        }

        private void getProject(string login)
        {
            try
            {
                FirebaseResponse res = Firebase.сlient.Get($"Users/{login}/userProjects");
                Data result = res.ResultAs<Data>();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.StackTrace);
            }
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            CreationForm creationForm = new CreationForm();
            creationForm.ShowDialog();
        }
    }
}
