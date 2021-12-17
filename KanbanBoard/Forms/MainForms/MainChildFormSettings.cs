using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KanbanBoard.Forms
{
    public partial class MainChildFormSettings : Form
    {
        public MainChildFormSettings()
        {
            InitializeComponent();
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
