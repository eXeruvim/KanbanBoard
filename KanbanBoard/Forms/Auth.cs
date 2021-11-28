using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KanbanBoard.Forms
{
    public partial class Auth : Form
    {
        public static string usernamepass;

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "EalE4Ra04uGQuLuA0zEhemNqzL2q0kAxzhJxHZrt",
            BasePath = "https://kanbanboard-c892f-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        public Auth()
        {
            InitializeComponent();
        }
        private void logup_btn_Click(object sender, EventArgs e)
        {
            SignUp logUpForm = new SignUp();
            this.Hide();
            logUpForm.ShowDialog();
            this.Close();
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_textbox.Text) || string.IsNullOrEmpty(password_textbox.Text))
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                FirebaseResponse response = client.Get("Users/");
                Dictionary<string, Data> result = response.ResultAs<Dictionary<string, Data>>();

                foreach(var get in result)
                {
                    string userResult = get.Value.login;
                    string passResult = get.Value.password;

                    if (login_textbox.Text == userResult)
                    {
                        if (password_textbox.Text == passResult)
                        {
                            MessageBox.Show("Добро пожаловать, " + login_textbox.Text + ". Снова. ");
                            usernamepass = login_textbox.Text;
                            // Вызов нового окна
                            // Закрытие / Скрытие  этого окна
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь " + login_textbox.Text + " не обнаружен :(");
                    }
                }
            }
        }
        public void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxEye.Image = Properties.Resources.eyeTrue;
            password_textbox.UseSystemPasswordChar = false;
        }
        public void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            password_textbox.UseSystemPasswordChar = true;
            pictureBoxEye.Image = Properties.Resources.eyeFalse;
        }
        public void auth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Добро пожаловать, хуила");
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {
                    // че-нибудь
                }
            }
            catch
            {
                MessageBox.Show("Connection fail :(");
            }
        }
    }
}
