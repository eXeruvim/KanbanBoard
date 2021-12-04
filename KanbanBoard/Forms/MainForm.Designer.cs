
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.projects_iconButton = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.user_iconButton = new FontAwesome.Sharp.IconButton();
            this.bars_iconBtn = new FontAwesome.Sharp.IconButton();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.restore_iconButton = new FontAwesome.Sharp.IconButton();
            this.minimize_iconButton = new FontAwesome.Sharp.IconButton();
            this.exit_iconButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.upper_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.panel1.Controls.Add(this.projects_iconButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 497);
            this.panel1.TabIndex = 0;
            // 
            // projects_iconButton
            // 
            this.projects_iconButton.FlatAppearance.BorderSize = 0;
            this.projects_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projects_iconButton.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.projects_iconButton.IconColor = System.Drawing.Color.Yellow;
            this.projects_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.projects_iconButton.Location = new System.Drawing.Point(37, 94);
            this.projects_iconButton.Name = "projects_iconButton";
            this.projects_iconButton.Size = new System.Drawing.Size(87, 56);
            this.projects_iconButton.TabIndex = 4;
            this.projects_iconButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.user_iconButton);
            this.panel4.Controls.Add(this.bars_iconBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 87);
            this.panel4.TabIndex = 3;
            // 
            // user_iconButton
            // 
            this.user_iconButton.FlatAppearance.BorderSize = 0;
            this.user_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_iconButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.user_iconButton.IconColor = System.Drawing.Color.Yellow;
            this.user_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.user_iconButton.IconSize = 60;
            this.user_iconButton.Location = new System.Drawing.Point(12, 12);
            this.user_iconButton.Name = "user_iconButton";
            this.user_iconButton.Size = new System.Drawing.Size(83, 72);
            this.user_iconButton.TabIndex = 2;
            this.user_iconButton.UseVisualStyleBackColor = true;
            // 
            // bars_iconBtn
            // 
            this.bars_iconBtn.FlatAppearance.BorderSize = 0;
            this.bars_iconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bars_iconBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bars_iconBtn.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.bars_iconBtn.IconColor = System.Drawing.Color.Yellow;
            this.bars_iconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bars_iconBtn.IconSize = 32;
            this.bars_iconBtn.Location = new System.Drawing.Point(101, 12);
            this.bars_iconBtn.Name = "bars_iconBtn";
            this.bars_iconBtn.Size = new System.Drawing.Size(50, 72);
            this.bars_iconBtn.TabIndex = 1;
            this.bars_iconBtn.UseVisualStyleBackColor = true;
            // 
            // upper_panel
            // 
            this.upper_panel.Controls.Add(this.restore_iconButton);
            this.upper_panel.Controls.Add(this.minimize_iconButton);
            this.upper_panel.Controls.Add(this.exit_iconButton);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(157, 0);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(753, 94);
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
            this.restore_iconButton.Location = new System.Drawing.Point(705, 0);
            this.restore_iconButton.Name = "restore_iconButton";
            this.restore_iconButton.Size = new System.Drawing.Size(25, 25);
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
            this.minimize_iconButton.Location = new System.Drawing.Point(678, 0);
            this.minimize_iconButton.Name = "minimize_iconButton";
            this.minimize_iconButton.Size = new System.Drawing.Size(25, 25);
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
            this.exit_iconButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.exit_iconButton.IconColor = System.Drawing.Color.White;
            this.exit_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit_iconButton.IconSize = 20;
            this.exit_iconButton.Location = new System.Drawing.Point(728, 0);
            this.exit_iconButton.Name = "exit_iconButton";
            this.exit_iconButton.Size = new System.Drawing.Size(25, 25);
            this.exit_iconButton.TabIndex = 2;
            this.exit_iconButton.UseVisualStyleBackColor = false;
            this.exit_iconButton.Click += new System.EventHandler(this.exit_iconButton_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(157, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 403);
            this.panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 497);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.upper_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton projects_iconButton;
        private FontAwesome.Sharp.IconButton user_iconButton;
        private FontAwesome.Sharp.IconButton bars_iconBtn;
        private FontAwesome.Sharp.IconButton restore_iconButton;
        private FontAwesome.Sharp.IconButton minimize_iconButton;
        private FontAwesome.Sharp.IconButton exit_iconButton;
    }
}