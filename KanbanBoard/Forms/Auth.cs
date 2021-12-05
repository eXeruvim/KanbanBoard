using FireSharp;
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

        public static IFirebaseClient client;

        public Auth()
        {
            InitializeComponent();
        }

        private void logup_btn_Click(object sender, EventArgs e)
        {
            SignUp logUpForm = new SignUp();
            this.Hide();
            logUpForm.ShowDialog();
        }
        private async void login_btn_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(login_textbox.Text) &&
               string.IsNullOrWhiteSpace(password_textbox.Text))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            #endregion

            String login = login_textbox.Text;
            FirebaseResponse response = await client.GetAsync(@"Users/" + login_textbox.Text);
            Data res = response.ResultAs<Data>();
            Data current_data = new Data()
            {
                login = login_textbox.Text,
                password = password_textbox.Text
            };

            if (Data.isEquals(res, current_data))
            {
                MainForm main = new MainForm();
                this.Hide();
                main.ShowDialog();
            }
            else { Data.ShowError(); }
            
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
        private void Auth_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(
                    new FirebaseConfig
                    {
                        AuthSecret = "EalE4Ra04uGQuLuA0zEhemNqzL2q0kAxzhJxHZrt",
                        BasePath = "https://kanbanboard-c892f-default-rtdb.europe-west1.firebasedatabase.app/"
                    });
            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }
    }
}
