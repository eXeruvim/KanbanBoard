
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
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.login_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(82, 41);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(76, 25);
            this.login.TabIndex = 0;
            this.login.Text = "Логин";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(82, 82);
            this.password.Name = "password";
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password.Size = new System.Drawing.Size(88, 25);
            this.password.TabIndex = 1;
            this.password.Text = "Пароль";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(198, 83);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(134, 23);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // signin_btn
            // 
            this.signin_btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signin_btn.Location = new System.Drawing.Point(82, 128);
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
            this.signup_btn.Location = new System.Drawing.Point(222, 128);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(109, 33);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = "Регистрация";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.logup_btn_Click);
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEye.Image = global::KanbanBoard.Properties.Resources.eyeFalse;
            this.pictureBoxEye.Location = new System.Drawing.Point(338, 82);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(28, 24);
            this.pictureBoxEye.TabIndex = 6;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxEye_MouseDown);
            this.pictureBoxEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxEye_MouseUp);
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(197, 47);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(135, 23);
            this.login_textbox.TabIndex = 2;
            // 
            // Auth
            // 
            this.AcceptButton = this.signin_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 209);
            this.Controls.Add(this.pictureBoxEye);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.TextBox login_textbox;
    }
}