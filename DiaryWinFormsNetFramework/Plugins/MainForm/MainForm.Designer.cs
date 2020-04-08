using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace DiaryWinFormsNetFramework
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.LeftNavPanel = new System.Windows.Forms.Panel();
            this.btnNavItemDiary = new System.Windows.Forms.Button();
            this.btnNavItemSettings = new System.Windows.Forms.Button();
            this.FormsPanel = new System.Windows.Forms.Panel();
            this.AppHeaderPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseCircle = new System.Windows.Forms.Button();
            this.btnWrapCircle = new System.Windows.Forms.Button();
            this.btnOpenCircle = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.LeftNavPanel.SuspendLayout();
            this.AppHeaderPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.BodyPanel);
            this.MainPanel.Controls.Add(this.AppHeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1200, 750);
            this.MainPanel.TabIndex = 0;
            // 
            // BodyPanel
            // 
            this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyPanel.Controls.Add(this.LeftNavPanel);
            this.BodyPanel.Controls.Add(this.FormsPanel);
            this.BodyPanel.Location = new System.Drawing.Point(0, 60);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1200, 690);
            this.BodyPanel.TabIndex = 1;
            // 
            // LeftNavPanel
            // 
            this.LeftNavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftNavPanel.BackColor = System.Drawing.Color.LightGray;
            this.LeftNavPanel.Controls.Add(this.btnNavItemDiary);
            this.LeftNavPanel.Controls.Add(this.btnNavItemSettings);
            this.LeftNavPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftNavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftNavPanel.Name = "LeftNavPanel";
            this.LeftNavPanel.Size = new System.Drawing.Size(80, 690);
            this.LeftNavPanel.TabIndex = 0;
            // 
            // btnNavItemDiary
            // 
            this.btnNavItemDiary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNavItemDiary.BackgroundImage")));
            this.btnNavItemDiary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNavItemDiary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavItemDiary.Location = new System.Drawing.Point(0, 80);
            this.btnNavItemDiary.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavItemDiary.Name = "btnNavItemDiary";
            this.btnNavItemDiary.Size = new System.Drawing.Size(80, 80);
            this.btnNavItemDiary.TabIndex = 0;
            this.btnNavItemDiary.UseVisualStyleBackColor = true;
            this.btnNavItemDiary.Click += new System.EventHandler(this.btnNavItemDiary_Click);
            // 
            // btnNavItemSettings
            // 
            this.btnNavItemSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNavItemSettings.BackgroundImage")));
            this.btnNavItemSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNavItemSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavItemSettings.Location = new System.Drawing.Point(0, 0);
            this.btnNavItemSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavItemSettings.Name = "btnNavItemSettings";
            this.btnNavItemSettings.Size = new System.Drawing.Size(80, 80);
            this.btnNavItemSettings.TabIndex = 1;
            this.btnNavItemSettings.UseVisualStyleBackColor = true;
            this.btnNavItemSettings.Click += new System.EventHandler(this.btnNavItemSettings_Click);
            // 
            // FormsPanel
            // 
            this.FormsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.FormsPanel.Location = new System.Drawing.Point(79, 0);
            this.FormsPanel.Name = "FormsPanel";
            this.FormsPanel.Size = new System.Drawing.Size(1120, 690);
            this.FormsPanel.TabIndex = 1;
            // 
            // AppHeaderPanel
            // 
            this.AppHeaderPanel.BackColor = System.Drawing.Color.LightGray;
            this.AppHeaderPanel.Controls.Add(this.TopPanel);
            this.AppHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.AppHeaderPanel.Name = "AppHeaderPanel";
            this.AppHeaderPanel.Size = new System.Drawing.Size(1200, 60);
            this.AppHeaderPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.btnCloseCircle);
            this.TopPanel.Controls.Add(this.btnWrapCircle);
            this.TopPanel.Controls.Add(this.btnOpenCircle);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 26);
            this.TopPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1101, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Burtimax";
            // 
            // btnCloseCircle
            // 
            this.btnCloseCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseCircle.BackgroundImage")));
            this.btnCloseCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseCircle.FlatAppearance.BorderSize = 0;
            this.btnCloseCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCircle.Location = new System.Drawing.Point(6, 4);
            this.btnCloseCircle.Name = "btnCloseCircle";
            this.btnCloseCircle.Size = new System.Drawing.Size(20, 20);
            this.btnCloseCircle.TabIndex = 0;
            this.btnCloseCircle.UseVisualStyleBackColor = false;
            this.btnCloseCircle.Click += new System.EventHandler(this.btnCloseCircle_Click);
            // 
            // btnWrapCircle
            // 
            this.btnWrapCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnWrapCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWrapCircle.BackgroundImage")));
            this.btnWrapCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWrapCircle.FlatAppearance.BorderSize = 0;
            this.btnWrapCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrapCircle.Location = new System.Drawing.Point(33, 4);
            this.btnWrapCircle.Name = "btnWrapCircle";
            this.btnWrapCircle.Size = new System.Drawing.Size(20, 20);
            this.btnWrapCircle.TabIndex = 1;
            this.btnWrapCircle.UseVisualStyleBackColor = false;
            // 
            // btnOpenCircle
            // 
            this.btnOpenCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenCircle.BackgroundImage")));
            this.btnOpenCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenCircle.FlatAppearance.BorderSize = 0;
            this.btnOpenCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCircle.Location = new System.Drawing.Point(61, 4);
            this.btnOpenCircle.Name = "btnOpenCircle";
            this.btnOpenCircle.Size = new System.Drawing.Size(20, 20);
            this.btnOpenCircle.TabIndex = 2;
            this.btnOpenCircle.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.LeftNavPanel.ResumeLayout(false);
            this.AppHeaderPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Panel AppHeaderPanel;
        private Panel BodyPanel;
        private Panel TopPanel;
        private Button btnCloseCircle;
        private Button btnWrapCircle;
        private Button btnOpenCircle;
        private Label label1;
        private Panel FormsPanel;
        private Panel LeftNavPanel;
        private Button btnNavItemDiary;
        private Button btnNavItemSettings;
    }
}

