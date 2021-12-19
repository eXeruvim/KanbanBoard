using FireSharp.Response;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using KanbanBoard.Server;

namespace KanbanBoard.Forms
{
    public partial class MainChildFormSettings : Form
    {
        public MainChildFormSettings()
        {
            InitializeComponent();
            label8.Text = Auth.mail;
            label7.Text = Auth.user;
            label9.Text = Auth.log;
        }

        private void github_iconButton_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://github.com/eXeruvim/KanbanBoard/";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
