
namespace KanbanBoard.Forms
{
    partial class Auth
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
            this.password = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.signin_btn = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.eye_iconButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.Yellow;
            this.login.Location = new System.Drawing.Point(59, 21);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(76, 25);
            this.login.TabIndex = 0;
            this.login.Text = "Логин";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.Color.Yellow;
            this.password.Location = new System.Drawing.Point(59, 62);
            this.password.Name = "password";
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password.Size = new System.Drawing.Size(88, 25);
            this.password.TabIndex = 1;
            this.password.Text = "Пароль";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(175, 63);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(134, 23);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // signin_btn
            // 
            this.signin_btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signin_btn.Location = new System.Drawing.Point(59, 108);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(109, 32);
            this.signin_btn.TabIndex = 4;
            this.signin_btn.Text = "Войти";
            this.signin_btn.UseVisualStyleBackColor = true;
            this.signin_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signup_btn.Location = new System.Drawing.Point(200, 107);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(109, 33);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = "Регистрация";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.logup_btn_Click);
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(174, 27);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(135, 23);
            this.login_textbox.TabIndex = 2;
            // 
            // eye_iconButton
            // 
            this.eye_iconButton.FlatAppearance.BorderSize = 0;
            this.eye_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eye_iconButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.eye_iconButton.IconColor = System.Drawing.Color.White;
            this.eye_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eye_iconButton.IconSize = 30;
            this.eye_iconButton.Location = new System.Drawing.Point(315, 62);
            this.eye_iconButton.Name = "eye_iconButton";
            this.eye_iconButton.Size = new System.Drawing.Size(30, 25);
            this.eye_iconButton.TabIndex = 7;
            this.eye_iconButton.UseVisualStyleBackColor = true;
            this.eye_iconButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eye_iconButton_MouseDown);
            this.eye_iconButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.eye_iconButton_MouseUp);
            // 
            // Auth
            // 
            this.AcceptButton = this.signin_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(365, 182);
            this.Controls.Add(this.eye_iconButton);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox login_textbox;
        private FontAwesome.Sharp.IconButton eye_iconButton;
    }
}