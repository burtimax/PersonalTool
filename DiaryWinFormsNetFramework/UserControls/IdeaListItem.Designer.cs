namespace DiaryWinFormsNetFramework.UserControls
{
    partial class IdeaListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Mark = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomLine = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(50, 0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Title.Size = new System.Drawing.Size(350, 50);
            this.Title.TabIndex = 1;
            this.Title.Text = "title";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Mark
            // 
            this.Mark.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Mark.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mark.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Mark.ForeColor = System.Drawing.Color.White;
            this.Mark.Location = new System.Drawing.Point(0, 0);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(50, 50);
            this.Mark.TabIndex = 2;
            this.Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomLine);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.Mark);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(400, 50);
            this.MainPanel.TabIndex = 3;
            // 
            // BottomLine
            // 
            this.BottomLine.BackColor = System.Drawing.Color.Gray;
            this.BottomLine.Location = new System.Drawing.Point(50, 49);
            this.BottomLine.Name = "BottomLine";
            this.BottomLine.Size = new System.Drawing.Size(350, 1);
            this.BottomLine.TabIndex = 3;
            // 
            // IdeaListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "IdeaListItem";
            this.Size = new System.Drawing.Size(400, 50);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BottomLine;
    }
}
