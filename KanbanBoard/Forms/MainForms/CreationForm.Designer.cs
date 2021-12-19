
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
            this.SuspendLayout();
            // 
            // PN_textBox
            // 
            this.PN_textBox.Location = new System.Drawing.Point(165, 22);
            this.PN_textBox.Name = "PN_textBox";
            this.PN_textBox.Size = new System.Drawing.Size(100, 23);
            this.PN_textBox.TabIndex = 0;
            // 
            // PN_label
            // 
            this.PN_label.AutoSize = true;
            this.PN_label.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PN_label.ForeColor = System.Drawing.Color.Yellow;
            this.PN_label.Location = new System.Drawing.Point(3, 22);
            this.PN_label.Name = "PN_label";
            this.PN_label.Size = new System.Drawing.Size(156, 20);
            this.PN_label.TabIndex = 1;
            this.PN_label.Text = "Название проекта";
            // 
            // key_richTextBox
            // 
            this.key_richTextBox.Location = new System.Drawing.Point(59, 51);
            this.key_richTextBox.Name = "key_richTextBox";
            this.key_richTextBox.ReadOnly = true;
            this.key_richTextBox.Size = new System.Drawing.Size(206, 66);
            this.key_richTextBox.TabIndex = 2;
            this.key_richTextBox.Text = "";
            // 
            // AC_button
            // 
            this.AC_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.AC_button.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AC_button.ForeColor = System.Drawing.Color.Yellow;
            this.AC_button.Location = new System.Drawing.Point(105, 123);
            this.AC_button.Name = "AC_button";
            this.AC_button.Size = new System.Drawing.Size(90, 31);
            this.AC_button.TabIndex = 3;
            this.AC_button.Text = "Создать";
            this.AC_button.UseVisualStyleBackColor = false;
            this.AC_button.Click += new System.EventHandler(this.AC_button_Click);
            // 
            // CreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(293, 172);
            this.Controls.Add(this.AC_button);
            this.Controls.Add(this.key_richTextBox);
            this.Controls.Add(this.PN_label);
            this.Controls.Add(this.PN_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PN_textBox;
        private System.Windows.Forms.Label PN_label;
        private System.Windows.Forms.RichTextBox key_richTextBox;
        private System.Windows.Forms.Button AC_button;
    }
}