using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Linq;
using KanbanBoard.Server;

namespace KanbanBoard.Forms
{
    public partial class Auth : Form
    {
        public static string mail { get; set; }
        public static string user { get; set; }
        public static string log { get; set; }

        IFirebaseConfig config = new FirebaseConfig
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
        }
        private async void login_btn_Click(object sender, EventArgs e)
        {
            signin_btn.Enabled = false;
            #region Condition
            if (string.IsNullOrWhiteSpace(login_textbox.Text) &&
               string.IsNullOrWhiteSpace(password_textbox.Text))
            {
                MessageBox.Show("Введите логин и пароль");
                signin_btn.Enabled = true;
                return;
            }
            #endregion
            FirebaseResponse response = await client.GetAsync(@"Users/" + login_textbox.Text);
            Data result = response.ResultAs<Data>();

            Data current_data = new Data()
            {
                login = login_textbox.Text,
                password = Encrypting.sha256(password_textbox.Text)
            };

                    
            if (Data.isEquals(result, current_data))
            {  
                Data data = response.ResultAs<Data>();
                mail = data.email;
                user = data.name;
                log = data.login;

                this.Hide();
                signin_btn.Enabled = true;
                MainForm main = new MainForm();
                main.ShowDialog();
            }

            else { 
                Data.ShowError();
                signin_btn.Enabled = true;
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }

        private void eye_iconButton_MouseDown(object sender, MouseEventArgs e)
        {
            eye_iconButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            password_textbox.UseSystemPasswordChar = false;
        }

        private void eye_iconButton_MouseUp(object sender, MouseEventArgs e)
        {
            eye_iconButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            password_textbox.UseSystemPasswordChar = true;
        }


     
    }
}
