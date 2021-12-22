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
            this.description_label = new System.Windows.Forms.Label();
            this.ChangeTicketForm_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ChangingMemberLabel = new System.Windows.Forms.Label();
            this.ChangingTitleLabel = new System.Windows.Forms.Label();
            this.ChangingMemberTextBox = new System.Windows.Forms.TextBox();
            this.ChangingTitleTextBox = new System.Windows.Forms.TextBox();
            this.ChangingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangingPanel
            // 
            this.ChangingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ChangingPanel.Controls.Add(this.description_label);
            this.ChangingPanel.Controls.Add(this.ChangeTicketForm_richTextBox);
            this.ChangingPanel.Controls.Add(this.SaveChangesButton);
            this.ChangingPanel.Controls.Add(this.ChangingMemberLabel);
            this.ChangingPanel.Controls.Add(this.ChangingTitleLabel);
            this.ChangingPanel.Controls.Add(this.ChangingMemberTextBox);
            this.ChangingPanel.Controls.Add(this.ChangingTitleTextBox);
            this.ChangingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangingPanel.Location = new System.Drawing.Point(0, 0);
            this.ChangingPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChangingPanel.Name = "ChangingPanel";
            this.ChangingPanel.Size = new System.Drawing.Size(282, 309);
            this.ChangingPanel.TabIndex = 1;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.description_label.ForeColor = System.Drawing.Color.Yellow;
            this.description_label.Location = new System.Drawing.Point(74, 74);
            this.description_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(139, 29);
            this.description_label.TabIndex = 8;
            this.description_label.Text = "Описание";
            this.description_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangeTicketForm_richTextBox
            // 
            this.ChangeTicketForm_richTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeTicketForm_richTextBox.Location = new System.Drawing.Point(4, 106);
            this.ChangeTicketForm_richTextBox.Name = "ChangeTicketForm_richTextBox";
            this.ChangeTicketForm_richTextBox.Size = new System.Drawing.Size(275, 100);
            this.ChangeTicketForm_richTextBox.TabIndex = 7;
            this.ChangeTicketForm_richTextBox.Text = "";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveChangesButton.FlatAppearance.BorderSize = 0;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveChangesButton.ForeColor = System.Drawing.Color.Yellow;
            this.SaveChangesButton.Location = new System.Drawing.Point(0, 273);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(282, 36);
            this.SaveChangesButton.TabIndex = 6;
            this.SaveChangesButton.Text = "Сохранить";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // ChangingMemberLabel
            // 
            this.ChangingMemberLabel.AutoSize = true;
            this.ChangingMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangingMemberLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ChangingMemberLabel.Location = new System.Drawing.Point(66, 209);
            this.ChangingMemberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangingMemberLabel.Name = "ChangingMemberLabel";
            this.ChangingMemberLabel.Size = new System.Drawing.Size(147, 29);
            this.ChangingMemberLabel.TabIndex = 5;
            this.ChangingMemberLabel.Text = "Участники";
            this.ChangingMemberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangingTitleLabel
            // 
            this.ChangingTitleLabel.AutoSize = true;
            this.ChangingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangingTitleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ChangingTitleLabel.Location = new System.Drawing.Point(79, 0);
            this.ChangingTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangingTitleLabel.Name = "ChangingTitleLabel";
            this.ChangingTitleLabel.Size = new System.Drawing.Size(134, 29);
            this.ChangingTitleLabel.TabIndex = 3;
            this.ChangingTitleLabel.Text = "Название";
            // 
            // ChangingMemberTextBox
            // 
            this.ChangingMemberTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangingMemberTextBox.Location = new System.Drawing.Point(4, 241);
            this.ChangingMemberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChangingMemberTextBox.Name = "ChangingMemberTextBox";
            this.ChangingMemberTextBox.Size = new System.Drawing.Size(275, 33);
            this.ChangingMemberTextBox.TabIndex = 3;
            // 
            // ChangingTitleTextBox
            // 
            this.ChangingTitleTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangingTitleTextBox.Location = new System.Drawing.Point(4, 32);
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
            this.ClientSize = new System.Drawing.Size(282, 309);
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
        private System.Windows.Forms.Label ChangingMemberLabel;
        private System.Windows.Forms.Label ChangingTitleLabel;
        private System.Windows.Forms.TextBox ChangingMemberTextBox;
        private System.Windows.Forms.TextBox ChangingTitleTextBox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.RichTextBox ChangeTicketForm_richTextBox;
    }
}