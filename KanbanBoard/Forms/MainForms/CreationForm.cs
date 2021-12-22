using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class CreationForm : Form
    {
        string key;
        public CreationForm()
        {
            InitializeComponent();
        }

        private void AC_button_Click(object sender, EventArgs e)
        {
            if (PN_textBox.Text == "")
            {
                MessageBox.Show("Введите название проекта!", "Ошибка");
            }
            else
            {

                key = Encrypting.sha256(PN_textBox.Text + Auth.log);
                key_richTextBox.Text = key;
                ProjectInfo userinfo = new ProjectInfo()
                {
                    projectKey = key,
                    projectName = PN_textBox.Text,
                };
                ProjectInfo info = new ProjectInfo()
                {
                    projectCreator = Auth.log,
                    projectKey = key,
                    projectName = PN_textBox.Text,
                };

                // string auf = GetRandomColour().ToString();

                Users us = new Users()
                {
                    login = Auth.log,
                    name = Auth.user,
                   // userColor = auf,
                };

                var setter = Firebase.client.Set("Projects/" + key, info);
                var setter1 = Firebase.client.Set("Users/"+ Auth.log + "/userProjects/" + key, userinfo);
                var setter2 = Firebase.client.Set("Projects/" + key + "/UserInDesk/" + Auth.log, us);
            }
            
        }

       /* private static readonly Random rand = new Random();

        private Color GetRandomColour()
        {
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        } */ 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
