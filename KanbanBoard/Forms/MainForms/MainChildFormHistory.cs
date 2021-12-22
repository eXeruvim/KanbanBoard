using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;
using KanbanBoard.Server;
using KanbanBoard.Forms;
using System.Collections.Generic;

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
            
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            CreationForm creationForm = new CreationForm();
            creationForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
