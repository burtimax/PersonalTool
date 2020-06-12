namespace DiaryWinFormsNetFramework.CustomDialogs
{
    partial class InputBox
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.CaptionPanel = new System.Windows.Forms.Panel();
            this.CaptionTxt = new System.Windows.Forms.TextBox();
            this.ContentPanel.SuspendLayout();
            this.CaptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Controls.Add(this.InputTxt);
            this.ContentPanel.Controls.Add(this.CaptionPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.MinimumSize = new System.Drawing.Size(500, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(506, 51);
            this.ContentPanel.TabIndex = 0;
            // 
            // InputTxt
            // 
            this.InputTxt.BackColor = System.Drawing.Color.White;
            this.InputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputTxt.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTxt.Location = new System.Drawing.Point(0, 24);
            this.InputTxt.MinimumSize = new System.Drawing.Size(500, 25);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(504, 25);
            this.InputTxt.TabIndex = 1;
            this.InputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaptionPanel
            // 
            this.CaptionPanel.AutoSize = true;
            this.CaptionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CaptionPanel.Controls.Add(this.CaptionTxt);
            this.CaptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptionPanel.Location = new System.Drawing.Point(0, 0);
            this.CaptionPanel.MinimumSize = new System.Drawing.Size(500, 20);
            this.CaptionPanel.Name = "CaptionPanel";
            this.CaptionPanel.Size = new System.Drawing.Size(504, 24);
            this.CaptionPanel.TabIndex = 1;
            // 
            // CaptionTxt
            // 
            this.CaptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaptionTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptionTxt.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionTxt.Location = new System.Drawing.Point(0, 0);
            this.CaptionTxt.MinimumSize = new System.Drawing.Size(500, 20);
            this.CaptionTxt.Name = "CaptionTxt";
            this.CaptionTxt.ReadOnly = true;
            this.CaptionTxt.Size = new System.Drawing.Size(504, 24);
            this.CaptionTxt.TabIndex = 0;
            this.CaptionTxt.Text = "Caption";
            this.CaptionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(506, 53);
            this.Controls.Add(this.ContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(506, 50);
            this.Name = "InputBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.CaptionPanel.ResumeLayout(false);
            this.CaptionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Panel CaptionPanel;
        private System.Windows.Forms.TextBox CaptionTxt;
    }
}