
namespace KanbanBoard.Forms
{
    partial class MainChildFormBoards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChildFormBoards));
            this.Board = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Board.SuspendLayout();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.AllowDrop = true;
            this.Board.AutoScroll = true;
            this.Board.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Board.ColumnCount = 1;
            this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Board.Controls.Add(this.label1, 0, 0);
            this.Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Board.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.Board.Location = new System.Drawing.Point(0, 0);
            this.Board.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Board.Name = "Board";
            this.Board.RowCount = 1;
            this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Board.Size = new System.Drawing.Size(861, 604);
            this.Board.TabIndex = 0;
            this.Board.DragDrop += new System.Windows.Forms.DragEventHandler(this.Board_DragDrop);
            this.Board.DragEnter += new System.Windows.Forms.DragEventHandler(this.Board_DragEnter);
            this.Board.DragOver += new System.Windows.Forms.DragEventHandler(this.Board_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // MainChildFormBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(861, 604);
            this.Controls.Add(this.Board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainChildFormBoards";
            this.Text = "MainChildForm1";
            this.Board.ResumeLayout(false);
            this.Board.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Board;
        private System.Windows.Forms.Label label1;
    }
}