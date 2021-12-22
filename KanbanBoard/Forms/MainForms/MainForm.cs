using System;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KanbanBoard.Utils;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KanbanBoard.Forms
{
    public partial class MainForm : Form
    {
        private int borderSize = 2;



        public MainForm()
        {
            InitializeComponent();
            CustomDesignMenu();
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
            if (this.menu_panel.Width >= 190)
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
                menu_panel.Width = 190;
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
            ShowSubMenu(submenu_boards);
            add_iconButton.Visible = true;
        }

        private void chat_iconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainChildFormChat());
            add_iconButton.Visible = false;
        }

        private void settings_iconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainChildFormSettings());
            add_iconButton.Visible = false;
        }

        private void profile_iconButton_Click(object sender, EventArgs e)
        {
            add_iconButton.Visible = false;
            ShowSubMenu(submenu_profile);
        }

        private void add_iconButton_Click(object sender, EventArgs e)
        {
            Program.mainChildFormBoards.AddPanel();
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
        
        private void CustomDesignMenu()
        {
            submenu_profile.Visible = false;
            submenu_boards.Visible = false;
        }

        private void HideSubMenu()
        {
            if (submenu_boards.Visible == true)
            {
                submenu_boards.Visible = false;
            }
            if (submenu_profile.Visible == true)
            {
                submenu_profile.Visible = false;
            }

            
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else

                SubMenu.Visible = false;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainChildFormProfile());
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            this.Hide();
            auth.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            add_iconButton.Visible = false;
            OpenChildForm(new OurBoards());

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            add_iconButton.Visible = true;
            ConnectBoardDialog condialog = new ConnectBoardDialog();
            condialog.ShowDialog();

        }

        private void chat_iconButton_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new MainChildFormBoards());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void projects_list_DropDown(object sender, EventArgs e)
        {
            FirebaseResponse res = Firebase.client.Get(@"Projects/");
            Dictionary<string, UserBoards> data = JsonConvert.DeserializeObject<Dictionary<string, UserBoards>>(res.Body.ToString());
            UpdateRTB(data);
        }

        void UpdateRTB(Dictionary<string, UserBoards> record)
        {
            projects_list.Items.Clear();

            foreach (var item in record)
            {
                projects_list.Items.Add(item.Value.projectKey);
            }
        }

        private void projects_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainChildFormBoards.key = projects_list.Text;
        }

        private void open_project_Click(object sender, EventArgs e)
        {
            MainChildFormBoards.key = projects_list.Text;
            Program.mainChildFormBoards.StartDynamicCreate();
            OpenChildForm(new MainChildFormBoards());
        }

        private void create_project_Click(object sender, EventArgs e)
        {
            if (projects_list.Text == "")
            {
                CreationForm CF = new CreationForm();
                CF.ShowDialog();
            }
        }
    }
}
