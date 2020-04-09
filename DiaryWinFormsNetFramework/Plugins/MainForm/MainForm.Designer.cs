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
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.InputPasswordPanel = new System.Windows.Forms.Panel();
            this.SetPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SetNewPasswordPanel = new System.Windows.Forms.Panel();
            this.SecondPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AppHeaderPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseCircle = new System.Windows.Forms.Button();
            this.btnWrapCircle = new System.Windows.Forms.Button();
            this.btnOpenCircle = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.LeftNavPanel.SuspendLayout();
            this.FormsPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.InputPasswordPanel.SuspendLayout();
            this.SetNewPasswordPanel.SuspendLayout();
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
            this.FormsPanel.Controls.Add(this.PasswordPanel);
            this.FormsPanel.Location = new System.Drawing.Point(79, 0);
            this.FormsPanel.Name = "FormsPanel";
            this.FormsPanel.Size = new System.Drawing.Size(1120, 690);
            this.FormsPanel.TabIndex = 1;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordPanel.Controls.Add(this.InputPasswordPanel);
            this.PasswordPanel.Controls.Add(this.SetNewPasswordPanel);
            this.PasswordPanel.Location = new System.Drawing.Point(277, 215);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(566, 242);
            this.PasswordPanel.TabIndex = 0;
            // 
            // InputPasswordPanel
            // 
            this.InputPasswordPanel.Controls.Add(this.SetPasswordTextBox);
            this.InputPasswordPanel.Controls.Add(this.label4);
            this.InputPasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPasswordPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPasswordPanel.Name = "InputPasswordPanel";
            this.InputPasswordPanel.Size = new System.Drawing.Size(566, 242);
            this.InputPasswordPanel.TabIndex = 0;
            // 
            // SetPasswordTextBox
            // 
            this.SetPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetPasswordTextBox.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPasswordTextBox.Location = new System.Drawing.Point(0, 36);
            this.SetPasswordTextBox.Name = "SetPasswordTextBox";
            this.SetPasswordTextBox.PasswordChar = '*';
            this.SetPasswordTextBox.Size = new System.Drawing.Size(566, 43);
            this.SetPasswordTextBox.TabIndex = 1;
            this.SetPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetPasswordTextBox.TextChanged += new System.EventHandler(this.SetPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(566, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите пароль";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetNewPasswordPanel
            // 
            this.SetNewPasswordPanel.Controls.Add(this.SecondPasswordTextBox);
            this.SetNewPasswordPanel.Controls.Add(this.label3);
            this.SetNewPasswordPanel.Controls.Add(this.FirstPasswordTextBox);
            this.SetNewPasswordPanel.Controls.Add(this.label2);
            this.SetNewPasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetNewPasswordPanel.Location = new System.Drawing.Point(0, 0);
            this.SetNewPasswordPanel.Name = "SetNewPasswordPanel";
            this.SetNewPasswordPanel.Size = new System.Drawing.Size(566, 242);
            this.SetNewPasswordPanel.TabIndex = 1;
            // 
            // SecondPasswordTextBox
            // 
            this.SecondPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondPasswordTextBox.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPasswordTextBox.Location = new System.Drawing.Point(0, 119);
            this.SecondPasswordTextBox.Name = "SecondPasswordTextBox";
            this.SecondPasswordTextBox.PasswordChar = '*';
            this.SecondPasswordTextBox.Size = new System.Drawing.Size(566, 43);
            this.SecondPasswordTextBox.TabIndex = 1;
            this.SecondPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SecondPasswordTextBox.TextChanged += new System.EventHandler(this.SecondPasswordTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(566, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Подтвердите пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstPasswordTextBox
            // 
            this.FirstPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstPasswordTextBox.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPasswordTextBox.Location = new System.Drawing.Point(0, 40);
            this.FirstPasswordTextBox.Name = "FirstPasswordTextBox";
            this.FirstPasswordTextBox.PasswordChar = '*';
            this.FirstPasswordTextBox.Size = new System.Drawing.Size(566, 43);
            this.FirstPasswordTextBox.TabIndex = 2;
            this.FirstPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Создайте новый пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.FormsPanel.ResumeLayout(false);
            this.PasswordPanel.ResumeLayout(false);
            this.InputPasswordPanel.ResumeLayout(false);
            this.InputPasswordPanel.PerformLayout();
            this.SetNewPasswordPanel.ResumeLayout(false);
            this.SetNewPasswordPanel.PerformLayout();
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
        private Panel PasswordPanel;
        private Panel SetNewPasswordPanel;
        private Label label3;
        private TextBox SecondPasswordTextBox;
        private TextBox FirstPasswordTextBox;
        private Label label2;
        private Panel InputPasswordPanel;
        private TextBox SetPasswordTextBox;
        private Label label4;
    }
}

