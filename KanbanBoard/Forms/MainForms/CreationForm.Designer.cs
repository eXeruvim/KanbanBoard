
namespace KanbanBoard.Forms
{
    partial class CreationForm
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
            this.PN_textBox = new System.Windows.Forms.TextBox();
            this.PN_label = new System.Windows.Forms.Label();
            this.key_richTextBox = new System.Windows.Forms.RichTextBox();
            this.AC_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PN_textBox
            // 
            this.PN_textBox.Location = new System.Drawing.Point(233, 28);
            this.PN_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PN_textBox.Name = "PN_textBox";
            this.PN_textBox.Size = new System.Drawing.Size(312, 27);
            this.PN_textBox.TabIndex = 0;
            // 
            // PN_label
            // 
            this.PN_label.AutoSize = true;
            this.PN_label.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PN_label.ForeColor = System.Drawing.Color.Yellow;
            this.PN_label.Location = new System.Drawing.Point(29, 28);
            this.PN_label.Name = "PN_label";
            this.PN_label.Size = new System.Drawing.Size(198, 23);
            this.PN_label.TabIndex = 1;
            this.PN_label.Text = "Название проекта:";
            // 
            // key_richTextBox
            // 
            this.key_richTextBox.Location = new System.Drawing.Point(233, 85);
            this.key_richTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.key_richTextBox.Name = "key_richTextBox";
            this.key_richTextBox.ReadOnly = true;
            this.key_richTextBox.Size = new System.Drawing.Size(529, 27);
            this.key_richTextBox.TabIndex = 2;
            this.key_richTextBox.Text = "";
            // 
            // AC_button
            // 
            this.AC_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.AC_button.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AC_button.ForeColor = System.Drawing.Color.Yellow;
            this.AC_button.Location = new System.Drawing.Point(566, 24);
            this.AC_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AC_button.Name = "AC_button";
            this.AC_button.Size = new System.Drawing.Size(196, 35);
            this.AC_button.TabIndex = 3;
            this.AC_button.Text = "Сгенерировать ключ";
            this.AC_button.UseVisualStyleBackColor = false;
            this.AC_button.Click += new System.EventHandler(this.AC_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(29, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ключ проекта:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(349, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AC_button);
            this.Controls.Add(this.key_richTextBox);
            this.Controls.Add(this.PN_label);
            this.Controls.Add(this.PN_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создать проект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PN_textBox;
        private System.Windows.Forms.Label PN_label;
        private System.Windows.Forms.RichTextBox key_richTextBox;
        private System.Windows.Forms.Button AC_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}