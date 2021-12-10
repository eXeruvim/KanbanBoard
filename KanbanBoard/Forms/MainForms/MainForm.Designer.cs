
namespace KanbanBoard.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_panel = new System.Windows.Forms.Panel();
            this.settings_iconButton = new FontAwesome.Sharp.IconButton();
            this.profile_iconButton = new FontAwesome.Sharp.IconButton();
            this.chat_iconButton = new FontAwesome.Sharp.IconButton();
            this.projects_iconButton = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_iconBtn = new FontAwesome.Sharp.IconButton();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.restore_iconButton = new FontAwesome.Sharp.IconButton();
            this.minimize_iconButton = new FontAwesome.Sharp.IconButton();
            this.exit_iconButton = new FontAwesome.Sharp.IconButton();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.menu_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.upper_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.menu_panel.Controls.Add(this.settings_iconButton);
            this.menu_panel.Controls.Add(this.profile_iconButton);
            this.menu_panel.Controls.Add(this.chat_iconButton);
            this.menu_panel.Controls.Add(this.projects_iconButton);
            this.menu_panel.Controls.Add(this.panel4);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(179, 663);
            this.menu_panel.TabIndex = 0;
            // 
            // settings_iconButton
            // 
            this.settings_iconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_iconButton.FlatAppearance.BorderSize = 0;
            this.settings_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_iconButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settings_iconButton.ForeColor = System.Drawing.Color.Yellow;
            this.settings_iconButton.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.settings_iconButton.IconColor = System.Drawing.Color.Yellow;
            this.settings_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settings_iconButton.IconSize = 45;
            this.settings_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_iconButton.Location = new System.Drawing.Point(0, 309);
            this.settings_iconButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settings_iconButton.Name = "settings_iconButton";
            this.settings_iconButton.Size = new System.Drawing.Size(179, 100);
            this.settings_iconButton.TabIndex = 7;
            this.settings_iconButton.Tag = "Настройки";
            this.settings_iconButton.Text = "Настройки";
            this.settings_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings_iconButton.UseVisualStyleBackColor = true;
            this.settings_iconButton.Click += new System.EventHandler(this.settings_iconButton_Click);
            // 
            // profile_iconButton
            // 
            this.profile_iconButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.profile_iconButton.FlatAppearance.BorderSize = 0;
            this.profile_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_iconButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profile_iconButton.ForeColor = System.Drawing.Color.Yellow;
            this.profile_iconButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.profile_iconButton.IconColor = System.Drawing.Color.Yellow;
            this.profile_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profile_iconButton.IconSize = 40;
            this.profile_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_iconButton.Location = new System.Drawing.Point(0, 563);
            this.profile_iconButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profile_iconButton.Name = "profile_iconButton";
            this.profile_iconButton.Size = new System.Drawing.Size(179, 100);
            this.profile_iconButton.TabIndex = 6;
            this.profile_iconButton.Tag = "Профиль";
            this.profile_iconButton.Text = "Профиль";
            this.profile_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profile_iconButton.UseVisualStyleBackColor = true;
            this.profile_iconButton.Click += new System.EventHandler(this.profile_iconButton_Click);
            // 
            // chat_iconButton
            // 
            this.chat_iconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.chat_iconButton.FlatAppearance.BorderSize = 0;
            this.chat_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chat_iconButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chat_iconButton.ForeColor = System.Drawing.Color.Yellow;
            this.chat_iconButton.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.chat_iconButton.IconColor = System.Drawing.Color.Yellow;
            this.chat_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chat_iconButton.IconSize = 45;
            this.chat_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chat_iconButton.Location = new System.Drawing.Point(0, 209);
            this.chat_iconButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chat_iconButton.Name = "chat_iconButton";
            this.chat_iconButton.Size = new System.Drawing.Size(179, 100);
            this.chat_iconButton.TabIndex = 5;
            this.chat_iconButton.Tag = "Чат";
            this.chat_iconButton.Text = "Чат";
            this.chat_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chat_iconButton.UseVisualStyleBackColor = true;
            this.chat_iconButton.Click += new System.EventHandler(this.chat_iconButton_Click);
            // 
            // projects_iconButton
            // 
            this.projects_iconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.projects_iconButton.FlatAppearance.BorderSize = 0;
            this.projects_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projects_iconButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projects_iconButton.ForeColor = System.Drawing.Color.Yellow;
            this.projects_iconButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.projects_iconButton.IconColor = System.Drawing.Color.Yellow;
            this.projects_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.projects_iconButton.IconSize = 45;
            this.projects_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projects_iconButton.Location = new System.Drawing.Point(0, 109);
            this.projects_iconButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projects_iconButton.Name = "projects_iconButton";
            this.projects_iconButton.Size = new System.Drawing.Size(179, 100);
            this.projects_iconButton.TabIndex = 4;
            this.projects_iconButton.Tag = "Доска";
            this.projects_iconButton.Text = "Доски";
            this.projects_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projects_iconButton.UseVisualStyleBackColor = true;
            this.projects_iconButton.Click += new System.EventHandler(this.projects_iconButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 109);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "K4b4n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_iconBtn
            // 
            this.menu_iconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.menu_iconBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_iconBtn.FlatAppearance.BorderSize = 0;
            this.menu_iconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_iconBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu_iconBtn.ForeColor = System.Drawing.Color.Yellow;
            this.menu_iconBtn.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.menu_iconBtn.IconColor = System.Drawing.Color.Yellow;
            this.menu_iconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_iconBtn.IconSize = 40;
            this.menu_iconBtn.Location = new System.Drawing.Point(0, 0);
            this.menu_iconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menu_iconBtn.Name = "menu_iconBtn";
            this.menu_iconBtn.Size = new System.Drawing.Size(84, 59);
            this.menu_iconBtn.TabIndex = 1;
            this.menu_iconBtn.Tag = "";
            this.menu_iconBtn.UseVisualStyleBackColor = false;
            this.menu_iconBtn.Click += new System.EventHandler(this.menu_iconBtn_Click);
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.upper_panel.Controls.Add(this.menu_iconBtn);
            this.upper_panel.Controls.Add(this.restore_iconButton);
            this.upper_panel.Controls.Add(this.minimize_iconButton);
            this.upper_panel.Controls.Add(this.exit_iconButton);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(179, 0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(861, 59);
            this.upper_panel.TabIndex = 1;
            this.upper_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upper_panel_MouseDown);
            // 
            // restore_iconButton
            // 
            this.restore_iconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restore_iconButton.BackColor = System.Drawing.Color.Blue;
            this.restore_iconButton.FlatAppearance.BorderSize = 0;
            this.restore_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restore_iconButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.restore_iconButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.restore_iconButton.IconColor = System.Drawing.Color.White;
            this.restore_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.restore_iconButton.IconSize = 20;
            this.restore_iconButton.Location = new System.Drawing.Point(789, 0);
            this.restore_iconButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restore_iconButton.Name = "restore_iconButton";
            this.restore_iconButton.Size = new System.Drawing.Size(35, 33);
            this.restore_iconButton.TabIndex = 4;
            this.restore_iconButton.UseVisualStyleBackColor = false;
            this.restore_iconButton.Click += new System.EventHandler(this.restore_iconButton_Click);
            // 
            // minimize_iconButton
            // 
            this.minimize_iconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_iconButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.minimize_iconButton.FlatAppearance.BorderSize = 0;
            this.minimize_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_iconButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimize_iconButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize_iconButton.IconColor = System.Drawing.Color.White;
            this.minimize_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize_iconButton.IconSize = 20;
            this.minimize_iconButton.Location = new System.Drawing.Point(752, 0);
            this.minimize_iconButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimize_iconButton.Name = "minimize_iconButton";
            this.minimize_iconButton.Size = new System.Drawing.Size(35, 33);
            this.minimize_iconButton.TabIndex = 3;
            this.minimize_iconButton.UseVisualStyleBackColor = false;
            this.minimize_iconButton.Click += new System.EventHandler(this.minimize_iconButton_Click);
            // 
            // exit_iconButton
            // 
            this.exit_iconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_iconButton.BackColor = System.Drawing.Color.Red;
            this.exit_iconButton.FlatAppearance.BorderSize = 0;
            this.exit_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_iconButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit_iconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exit_iconButton.IconColor = System.Drawing.Color.White;
            this.exit_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit_iconButton.IconSize = 20;
            this.exit_iconButton.Location = new System.Drawing.Point(826, 0);
            this.exit_iconButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit_iconButton.Name = "exit_iconButton";
            this.exit_iconButton.Size = new System.Drawing.Size(35, 33);
            this.exit_iconButton.TabIndex = 2;
            this.exit_iconButton.UseVisualStyleBackColor = false;
            this.exit_iconButton.Click += new System.EventHandler(this.exit_iconButton_Click);
            // 
            // panel_childForm
            // 
            this.panel_childForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Location = new System.Drawing.Point(179, 59);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(861, 604);
            this.panel_childForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 663);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.menu_panel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menu_panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.upper_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Panel panel_childForm;
        private FontAwesome.Sharp.IconButton projects_iconButton;
        private FontAwesome.Sharp.IconButton menu_iconBtn;
        private FontAwesome.Sharp.IconButton restore_iconButton;
        private FontAwesome.Sharp.IconButton minimize_iconButton;
        private FontAwesome.Sharp.IconButton exit_iconButton;
        private FontAwesome.Sharp.IconButton profile_iconButton;
        private FontAwesome.Sharp.IconButton chat_iconButton;
        private FontAwesome.Sharp.IconButton settings_iconButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}