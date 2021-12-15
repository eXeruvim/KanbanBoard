using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KanbanBoard.Utils;

namespace KanbanBoard.Forms
{
    public partial class MainForm : Form
    {
        private int borderSize = 2;
        public MainForm()
        {
            InitializeComponent();
            SlideToLeftMenu();
            OpenChildForm(new MainChildFormBoards());
            SetDoubleBuffered(menu_panel);
            SetDoubleBuffered(this);

            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(23, 21, 32);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        



        private void upper_panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void user_iconButton_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if(m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch(this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void minimize_iconButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
        private void restore_iconButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else 
                this.WindowState = FormWindowState.Normal;
        }

        private void exit_iconButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_iconBtn_Click(object sender, EventArgs e)
        {
            SlideToLeftMenu();
        }

        private void SlideToLeftMenu()
        {
            if (this.menu_panel.Width >= 180)
            {
                menu_panel.Width = 100;
                menu_iconBtn.Dock = DockStyle.Top;
                foreach (Button menubtn in menu_panel.Controls.OfType<Button>())
                {
                    menubtn.Text = "";
                    menubtn.ImageAlign = ContentAlignment.MiddleCenter;
                    menubtn.Padding = new Padding(0);
                }
                menu_iconBtn.Dock = DockStyle.Left;
            }
            else
            {
                menu_panel.Width = 180;
                menu_iconBtn.Dock = DockStyle.None;
                foreach (Button menubtn in menu_panel.Controls.OfType<Button>())
                {
                    menubtn.Text = "   " + menubtn.Tag.ToString();
                    menubtn.ImageAlign = ContentAlignment.MiddleLeft;
                    menubtn.Padding = new Padding(10,0,0,0);
                }
         
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_childForm.Controls.Add(childForm);
            panel_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void projects_iconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainChildFormBoards());
            
        }

        private void chat_iconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainChildFormChat());
        }

        private void settings_iconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainChildFormSettings());
        }

        private void profile_iconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainChildFormProfile());
        }

        private void add_iconButton_Click(object sender, EventArgs e)
        {
            Program.mainChildFormBoards.add();
        }


        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            var aProp = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            aProp?.SetValue(c, true, null);
        }
    }
}
