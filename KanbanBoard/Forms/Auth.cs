using System;
using System.Drawing;
using System.Windows.Forms;

namespace KanbanBoard.Forms
{
    public partial class Auth : Form
    {

        public Auth()
        {
            InitializeComponent();
  
            pictureBoxEye.MouseDown += new MouseEventHandler(pictureBoxEye_MouseDown);
            pictureBoxEye.MouseUp += new MouseEventHandler(pictureBoxEye_MouseUp);
        }

        private void logup_btn_Click(object sender, EventArgs e)
        {
            SignUp logUpForm = new SignUp();
            logUpForm.ShowDialog();
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать, хуила");
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
    }
}
