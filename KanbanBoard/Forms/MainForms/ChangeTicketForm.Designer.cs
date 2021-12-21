namespace KanbanBoard.Forms
{
    partial class ChangeTicketForm
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
            this.ChangingPanel = new System.Windows.Forms.Panel();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ChangingPeopleLabel = new System.Windows.Forms.Label();
            this.ChangingTitleLabel = new System.Windows.Forms.Label();
            this.ChangingPeopleTextBox = new System.Windows.Forms.TextBox();
            this.ChangingTitleTextBox = new System.Windows.Forms.TextBox();
            this.ChangingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangingPanel
            // 
            this.ChangingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ChangingPanel.Controls.Add(this.SaveChangesButton);
            this.ChangingPanel.Controls.Add(this.ChangingPeopleLabel);
            this.ChangingPanel.Controls.Add(this.ChangingTitleLabel);
            this.ChangingPanel.Controls.Add(this.ChangingPeopleTextBox);
            this.ChangingPanel.Controls.Add(this.ChangingTitleTextBox);
            this.ChangingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangingPanel.Location = new System.Drawing.Point(0, 0);
            this.ChangingPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChangingPanel.Name = "ChangingPanel";
            this.ChangingPanel.Size = new System.Drawing.Size(443, 207);
            this.ChangingPanel.TabIndex = 1;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveChangesButton.FlatAppearance.BorderSize = 0;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveChangesButton.ForeColor = System.Drawing.Color.Yellow;
            this.SaveChangesButton.Location = new System.Drawing.Point(0, 163);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(443, 44);
            this.SaveChangesButton.TabIndex = 6;
            this.SaveChangesButton.Text = "Сохранить";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // ChangingPeopleLabel
            // 
            this.ChangingPeopleLabel.AutoSize = true;
            this.ChangingPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangingPeopleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ChangingPeopleLabel.Location = new System.Drawing.Point(158, 103);
            this.ChangingPeopleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangingPeopleLabel.Name = "ChangingPeopleLabel";
            this.ChangingPeopleLabel.Size = new System.Drawing.Size(147, 29);
            this.ChangingPeopleLabel.TabIndex = 5;
            this.ChangingPeopleLabel.Text = "Участники";
            this.ChangingPeopleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangingTitleLabel
            // 
            this.ChangingTitleLabel.AutoSize = true;
            this.ChangingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangingTitleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ChangingTitleLabel.Location = new System.Drawing.Point(171, 29);
            this.ChangingTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangingTitleLabel.Name = "ChangingTitleLabel";
            this.ChangingTitleLabel.Size = new System.Drawing.Size(134, 29);
            this.ChangingTitleLabel.TabIndex = 3;
            this.ChangingTitleLabel.Text = "Название";
            // 
            // ChangingPeopleTextBox
            // 
            this.ChangingPeopleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangingPeopleTextBox.Location = new System.Drawing.Point(98, 135);
            this.ChangingPeopleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChangingPeopleTextBox.Name = "ChangingPeopleTextBox";
            this.ChangingPeopleTextBox.Size = new System.Drawing.Size(275, 26);
            this.ChangingPeopleTextBox.TabIndex = 3;
            // 
            // ChangingTitleTextBox
            // 
            this.ChangingTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangingTitleTextBox.Location = new System.Drawing.Point(98, 61);
            this.ChangingTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChangingTitleTextBox.Multiline = true;
            this.ChangingTitleTextBox.Name = "ChangingTitleTextBox";
            this.ChangingTitleTextBox.Size = new System.Drawing.Size(275, 39);
            this.ChangingTitleTextBox.TabIndex = 1;
            // 
            // ChangeTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(443, 207);
            this.Controls.Add(this.ChangingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ChangeTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить тикет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketsChangeForm_FormClosing);
            this.Load += new System.EventHandler(this.TicketsChangeForm_Load);
            this.ChangingPanel.ResumeLayout(false);
            this.ChangingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChangingPanel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Label ChangingPeopleLabel;
        private System.Windows.Forms.Label ChangingTitleLabel;
        private System.Windows.Forms.TextBox ChangingPeopleTextBox;
        private System.Windows.Forms.TextBox ChangingTitleTextBox;
    }
}