﻿namespace DiaryWinFormsNetFramework.UserControls
{
    partial class ProjectItem
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.NameTxt = new System.Windows.Forms.Label();
            this.BottomColorPanel = new System.Windows.Forms.Panel();
            this.LeftColorPanel = new System.Windows.Forms.Panel();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.Controls.Add(this.LeftColorPanel);
            this.ContentPanel.Controls.Add(this.BottomColorPanel);
            this.ContentPanel.Controls.Add(this.NameTxt);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ContentPanel.Location = new System.Drawing.Point(0, 5);
            this.ContentPanel.MinimumSize = new System.Drawing.Size(300, 80);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(300, 80);
            this.ContentPanel.TabIndex = 0;
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.White;
            this.NameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTxt.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.ForeColor = System.Drawing.Color.Black;
            this.NameTxt.Location = new System.Drawing.Point(0, 0);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Padding = new System.Windows.Forms.Padding(20, 0, 0, 3);
            this.NameTxt.Size = new System.Drawing.Size(300, 80);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.Text = "label1";
            this.NameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomColorPanel
            // 
            this.BottomColorPanel.BackColor = System.Drawing.Color.Gray;
            this.BottomColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomColorPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BottomColorPanel.Location = new System.Drawing.Point(0, 77);
            this.BottomColorPanel.Name = "BottomColorPanel";
            this.BottomColorPanel.Size = new System.Drawing.Size(300, 3);
            this.BottomColorPanel.TabIndex = 1;
            // 
            // LeftColorPanel
            // 
            this.LeftColorPanel.BackColor = System.Drawing.Color.DimGray;
            this.LeftColorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftColorPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftColorPanel.Name = "LeftColorPanel";
            this.LeftColorPanel.Size = new System.Drawing.Size(10, 77);
            this.LeftColorPanel.TabIndex = 0;
            // 
            // ProjectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ContentPanel);
            this.Name = "ProjectItem";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Size = new System.Drawing.Size(300, 85);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label NameTxt;
        private System.Windows.Forms.Panel BottomColorPanel;
        private System.Windows.Forms.Panel LeftColorPanel;
    }
}
