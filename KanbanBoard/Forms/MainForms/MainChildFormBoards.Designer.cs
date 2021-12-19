
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
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.AllowDrop = true;
            this.Board.AutoScroll = true;
            this.Board.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Board.ColumnCount = 1;
            this.Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Board.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.Board.Location = new System.Drawing.Point(0, 0);
            this.Board.Name = "Board";
            this.Board.RowCount = 1;
            this.Board.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Board.Size = new System.Drawing.Size(753, 453);
            this.Board.TabIndex = 0;
            this.Board.DragDrop += new System.Windows.Forms.DragEventHandler(this.Board_DragDrop);
            this.Board.DragEnter += new System.Windows.Forms.DragEventHandler(this.Board_DragEnter);
            this.Board.DragOver += new System.Windows.Forms.DragEventHandler(this.Board_DragOver);
            // 
            // MainChildFormBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(753, 453);
            this.Controls.Add(this.Board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainChildFormBoards";
            this.Text = "MainChildForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Board;
    }
}