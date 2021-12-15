
namespace KanbanBoard.Forms
{
    partial class SignUp
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
            this.login = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.accept_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.captcha_textBox = new System.Windows.Forms.TextBox();
            this.reload_iconButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.Yellow;
            this.login.Location = new System.Drawing.Point(28, 41);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(83, 25);
            this.login.TabIndex = 0;
            this.login.Text = "Логин:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.Yellow;
            this.email.Location = new System.Drawing.Point(28, 80);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(86, 25);
            this.email.TabIndex = 1;
            this.email.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(28, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.Yellow;
            this.name.Location = new System.Drawing.Point(28, 7);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 25);
            this.name.TabIndex = 3;
            this.name.Text = "Имя:";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_textBox.Location = new System.Drawing.Point(150, 7);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(112, 23);
            this.name_textBox.TabIndex = 4;
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_textBox.Location = new System.Drawing.Point(150, 46);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(112, 23);
            this.login_textBox.TabIndex = 5;
            // 
            // email_textBox
            // 
            this.email_textBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_textBox.Location = new System.Drawing.Point(150, 85);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(112, 23);
            this.email_textBox.TabIndex = 6;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_textBox.Location = new System.Drawing.Point(150, 123);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(112, 23);
            this.pass_textBox.TabIndex = 7;
            this.pass_textBox.UseSystemPasswordChar = true;
            // 
            // accept_btn
            // 
            this.accept_btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accept_btn.Location = new System.Drawing.Point(32, 266);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(75, 25);
            this.accept_btn.TabIndex = 8;
            this.accept_btn.Text = "Принять";
            this.accept_btn.UseVisualStyleBackColor = true;
            this.accept_btn.Click += new System.EventHandler(this.acceptBtn);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_btn.Location = new System.Drawing.Point(175, 266);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(87, 25);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(35, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 63);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // captcha_textBox
            // 
            this.captcha_textBox.Location = new System.Drawing.Point(35, 222);
            this.captcha_textBox.Name = "captcha_textBox";
            this.captcha_textBox.Size = new System.Drawing.Size(169, 26);
            this.captcha_textBox.TabIndex = 11;
            // 
            // reload_iconButton
            // 
            this.reload_iconButton.BackColor = System.Drawing.Color.Transparent;
            this.reload_iconButton.FlatAppearance.BorderSize = 0;
            this.reload_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reload_iconButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reload_iconButton.ForeColor = System.Drawing.Color.Yellow;
            this.reload_iconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.reload_iconButton.IconColor = System.Drawing.Color.Black;
            this.reload_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reload_iconButton.IconSize = 50;
            this.reload_iconButton.Location = new System.Drawing.Point(210, 152);
            this.reload_iconButton.Name = "reload_iconButton";
            this.reload_iconButton.Size = new System.Drawing.Size(52, 63);
            this.reload_iconButton.TabIndex = 12;
            this.reload_iconButton.Text = "";
            this.reload_iconButton.UseVisualStyleBackColor = false;
            this.reload_iconButton.Click += new System.EventHandler(this.reload_iconButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(289, 340);
            this.Controls.Add(this.reload_iconButton);
            this.Controls.Add(this.captcha_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.login);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            this.Load += new System.EventHandler(this.LogUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Button accept_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox captcha_textBox;
        private FontAwesome.Sharp.IconButton reload_iconButton;
    }
}