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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.TopColorPanel = new System.Windows.Forms.Panel();
            this.BottomGradientPanel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.AppHeaderPanel = new System.Windows.Forms.Panel();
            this.BottomColorPanel = new System.Windows.Forms.Panel();
            this.GradientHeaderPanel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnWrapCircle = new Guna.UI.WinForms.GunaCircleButton();
            this.btnOpenCircle = new Guna.UI.WinForms.GunaCircleButton();
            this.btnCloseCircle = new Guna.UI.WinForms.GunaCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.LeftNavPanel = new System.Windows.Forms.Panel();
            this.btnNavItemTasks = new Guna.UI.WinForms.GunaImageButton();
            this.btnNavItemIdeas = new Guna.UI.WinForms.GunaImageButton();
            this.btnNavItemDiary = new Guna.UI.WinForms.GunaImageButton();
            this.btnNavItemSettings = new Guna.UI.WinForms.GunaImageButton();
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
            this.FormEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.MainPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.AppHeaderPanel.SuspendLayout();
            this.GradientHeaderPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.LeftNavPanel.SuspendLayout();
            this.FormsPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.InputPasswordPanel.SuspendLayout();
            this.SetNewPasswordPanel.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.AppHeaderPanel);
            this.MainPanel.Controls.Add(this.BodyPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1200, 750);
            this.MainPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.TopColorPanel);
            this.BottomPanel.Controls.Add(this.BottomGradientPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 730);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1200, 20);
            this.BottomPanel.TabIndex = 1;
            // 
            // TopColorPanel
            // 
            this.TopColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.TopColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopColorPanel.Location = new System.Drawing.Point(0, 0);
            this.TopColorPanel.Name = "TopColorPanel";
            this.TopColorPanel.Size = new System.Drawing.Size(1200, 2);
            this.TopColorPanel.TabIndex = 2;
            // 
            // BottomGradientPanel
            // 
            this.BottomGradientPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomGradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomGradientPanel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.BottomGradientPanel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.BottomGradientPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.BottomGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomGradientPanel.Name = "BottomGradientPanel";
            this.BottomGradientPanel.Size = new System.Drawing.Size(1200, 20);
            this.BottomGradientPanel.TabIndex = 1;
            // 
            // AppHeaderPanel
            // 
            this.AppHeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.AppHeaderPanel.Controls.Add(this.BottomColorPanel);
            this.AppHeaderPanel.Controls.Add(this.GradientHeaderPanel);
            this.AppHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.AppHeaderPanel.Name = "AppHeaderPanel";
            this.AppHeaderPanel.Size = new System.Drawing.Size(1200, 45);
            this.AppHeaderPanel.TabIndex = 0;
            // 
            // BottomColorPanel
            // 
            this.BottomColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.BottomColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomColorPanel.Location = new System.Drawing.Point(0, 43);
            this.BottomColorPanel.Name = "BottomColorPanel";
            this.BottomColorPanel.Size = new System.Drawing.Size(1200, 2);
            this.BottomColorPanel.TabIndex = 1;
            // 
            // GradientHeaderPanel
            // 
            this.GradientHeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.GradientHeaderPanel.Controls.Add(this.TopPanel);
            this.GradientHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradientHeaderPanel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.GradientHeaderPanel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.GradientHeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GradientHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.GradientHeaderPanel.Name = "GradientHeaderPanel";
            this.GradientHeaderPanel.Size = new System.Drawing.Size(1200, 45);
            this.GradientHeaderPanel.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.btnWrapCircle);
            this.TopPanel.Controls.Add(this.btnOpenCircle);
            this.TopPanel.Controls.Add(this.btnCloseCircle);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 25);
            this.TopPanel.TabIndex = 0;
            // 
            // btnWrapCircle
            // 
            this.btnWrapCircle.AnimationHoverSpeed = 0.07F;
            this.btnWrapCircle.AnimationSpeed = 0.03F;
            this.btnWrapCircle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(64)))));
            this.btnWrapCircle.BorderColor = System.Drawing.Color.Black;
            this.btnWrapCircle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnWrapCircle.FocusedColor = System.Drawing.Color.Empty;
            this.btnWrapCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWrapCircle.ForeColor = System.Drawing.Color.White;
            this.btnWrapCircle.Image = null;
            this.btnWrapCircle.ImageSize = new System.Drawing.Size(52, 52);
            this.btnWrapCircle.Location = new System.Drawing.Point(35, 5);
            this.btnWrapCircle.Name = "btnWrapCircle";
            this.btnWrapCircle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(64)))));
            this.btnWrapCircle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnWrapCircle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnWrapCircle.OnHoverImage = null;
            this.btnWrapCircle.OnPressedColor = System.Drawing.Color.Black;
            this.btnWrapCircle.Size = new System.Drawing.Size(20, 20);
            this.btnWrapCircle.TabIndex = 1000002;
            this.btnWrapCircle.Click += new System.EventHandler(this.btnWrapCircle_Click);
            // 
            // btnOpenCircle
            // 
            this.btnOpenCircle.AnimationHoverSpeed = 0.07F;
            this.btnOpenCircle.AnimationSpeed = 0.03F;
            this.btnOpenCircle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(200)))), ((int)(((byte)(72)))));
            this.btnOpenCircle.BorderColor = System.Drawing.Color.Black;
            this.btnOpenCircle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpenCircle.FocusedColor = System.Drawing.Color.Empty;
            this.btnOpenCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenCircle.ForeColor = System.Drawing.Color.White;
            this.btnOpenCircle.Image = null;
            this.btnOpenCircle.ImageSize = new System.Drawing.Size(52, 52);
            this.btnOpenCircle.Location = new System.Drawing.Point(62, 5);
            this.btnOpenCircle.Name = "btnOpenCircle";
            this.btnOpenCircle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(200)))), ((int)(((byte)(72)))));
            this.btnOpenCircle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOpenCircle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOpenCircle.OnHoverImage = null;
            this.btnOpenCircle.OnPressedColor = System.Drawing.Color.Black;
            this.btnOpenCircle.Size = new System.Drawing.Size(20, 20);
            this.btnOpenCircle.TabIndex = 1000001;
            this.btnOpenCircle.Click += new System.EventHandler(this.btnOpenCircle_Click);
            // 
            // btnCloseCircle
            // 
            this.btnCloseCircle.AnimationHoverSpeed = 0.07F;
            this.btnCloseCircle.AnimationSpeed = 0.03F;
            this.btnCloseCircle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnCloseCircle.BorderColor = System.Drawing.Color.Black;
            this.btnCloseCircle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCloseCircle.FocusedColor = System.Drawing.Color.Empty;
            this.btnCloseCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseCircle.ForeColor = System.Drawing.Color.White;
            this.btnCloseCircle.Image = null;
            this.btnCloseCircle.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCloseCircle.Location = new System.Drawing.Point(8, 5);
            this.btnCloseCircle.Name = "btnCloseCircle";
            this.btnCloseCircle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(87)))), ((int)(((byte)(84)))));
            this.btnCloseCircle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCloseCircle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCloseCircle.OnHoverImage = null;
            this.btnCloseCircle.OnPressedColor = System.Drawing.Color.Black;
            this.btnCloseCircle.Size = new System.Drawing.Size(20, 20);
            this.btnCloseCircle.TabIndex = 1000000;
            this.btnCloseCircle.Click += new System.EventHandler(this.btnCloseCircle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(1105, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Burtimax";
            // 
            // BodyPanel
            // 
            this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyPanel.Controls.Add(this.LeftNavPanel);
            this.BodyPanel.Controls.Add(this.FormsPanel);
            this.BodyPanel.Location = new System.Drawing.Point(0, 45);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1200, 685);
            this.BodyPanel.TabIndex = 1;
            // 
            // LeftNavPanel
            // 
            this.LeftNavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftNavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LeftNavPanel.Controls.Add(this.btnNavItemTasks);
            this.LeftNavPanel.Controls.Add(this.btnNavItemIdeas);
            this.LeftNavPanel.Controls.Add(this.btnNavItemDiary);
            this.LeftNavPanel.Controls.Add(this.btnNavItemSettings);
            this.LeftNavPanel.Controls.Add(this.panel1);
            this.LeftNavPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftNavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftNavPanel.Name = "LeftNavPanel";
            this.LeftNavPanel.Size = new System.Drawing.Size(65, 685);
            this.LeftNavPanel.TabIndex = 0;
            // 
            // btnNavItemTasks
            // 
            this.btnNavItemTasks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNavItemTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavItemTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnNavItemTasks.Image")));
            this.btnNavItemTasks.ImageSize = new System.Drawing.Size(53, 53);
            this.btnNavItemTasks.Location = new System.Drawing.Point(0, 189);
            this.btnNavItemTasks.Name = "btnNavItemTasks";
            this.btnNavItemTasks.OnHoverImage = null;
            this.btnNavItemTasks.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnNavItemTasks.Size = new System.Drawing.Size(63, 63);
            this.btnNavItemTasks.TabIndex = 7;
            this.btnNavItemTasks.Click += new System.EventHandler(this.btnNavItemTasks_Click);
            // 
            // btnNavItemIdeas
            // 
            this.btnNavItemIdeas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNavItemIdeas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavItemIdeas.Image = ((System.Drawing.Image)(resources.GetObject("btnNavItemIdeas.Image")));
            this.btnNavItemIdeas.ImageSize = new System.Drawing.Size(53, 53);
            this.btnNavItemIdeas.Location = new System.Drawing.Point(0, 126);
            this.btnNavItemIdeas.Name = "btnNavItemIdeas";
            this.btnNavItemIdeas.OnHoverImage = null;
            this.btnNavItemIdeas.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnNavItemIdeas.Size = new System.Drawing.Size(63, 63);
            this.btnNavItemIdeas.TabIndex = 6;
            this.btnNavItemIdeas.Click += new System.EventHandler(this.btnNavItemIdeas_Click);
            // 
            // btnNavItemDiary
            // 
            this.btnNavItemDiary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNavItemDiary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavItemDiary.Image = ((System.Drawing.Image)(resources.GetObject("btnNavItemDiary.Image")));
            this.btnNavItemDiary.ImageSize = new System.Drawing.Size(53, 53);
            this.btnNavItemDiary.Location = new System.Drawing.Point(0, 63);
            this.btnNavItemDiary.Name = "btnNavItemDiary";
            this.btnNavItemDiary.OnHoverImage = null;
            this.btnNavItemDiary.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnNavItemDiary.Size = new System.Drawing.Size(63, 63);
            this.btnNavItemDiary.TabIndex = 5;
            this.btnNavItemDiary.Click += new System.EventHandler(this.btnNavItemDiary_Click);
            // 
            // btnNavItemSettings
            // 
            this.btnNavItemSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNavItemSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavItemSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnNavItemSettings.Image")));
            this.btnNavItemSettings.ImageSize = new System.Drawing.Size(53, 53);
            this.btnNavItemSettings.Location = new System.Drawing.Point(0, 0);
            this.btnNavItemSettings.Name = "btnNavItemSettings";
            this.btnNavItemSettings.OnHoverImage = null;
            this.btnNavItemSettings.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnNavItemSettings.Size = new System.Drawing.Size(63, 63);
            this.btnNavItemSettings.TabIndex = 4;
            this.btnNavItemSettings.Click += new System.EventHandler(this.btnNavItemSettings_Click);
            // 
            // FormsPanel
            // 
            this.FormsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.FormsPanel.Controls.Add(this.PasswordPanel);
            this.FormsPanel.Location = new System.Drawing.Point(65, 0);
            this.FormsPanel.Name = "FormsPanel";
            this.FormsPanel.Size = new System.Drawing.Size(1135, 685);
            this.FormsPanel.TabIndex = 1;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordPanel.Controls.Add(this.InputPasswordPanel);
            this.PasswordPanel.Controls.Add(this.SetNewPasswordPanel);
            this.PasswordPanel.Location = new System.Drawing.Point(322, 215);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(483, 237);
            this.PasswordPanel.TabIndex = 0;
            // 
            // InputPasswordPanel
            // 
            this.InputPasswordPanel.Controls.Add(this.gunaElipsePanel1);
            this.InputPasswordPanel.Controls.Add(this.label4);
            this.InputPasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPasswordPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPasswordPanel.Name = "InputPasswordPanel";
            this.InputPasswordPanel.Size = new System.Drawing.Size(483, 237);
            this.InputPasswordPanel.TabIndex = 0;
            // 
            // SetPasswordTextBox
            // 
            this.SetPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetPasswordTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.SetPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SetPasswordTextBox.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.SetPasswordTextBox.Location = new System.Drawing.Point(66, 2);
            this.SetPasswordTextBox.Name = "SetPasswordTextBox";
            this.SetPasswordTextBox.PasswordChar = '*';
            this.SetPasswordTextBox.Size = new System.Drawing.Size(352, 36);
            this.SetPasswordTextBox.TabIndex = 1;
            this.SetPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetPasswordTextBox.TextChanged += new System.EventHandler(this.SetPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(483, 36);
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
            this.SetNewPasswordPanel.Size = new System.Drawing.Size(483, 237);
            this.SetNewPasswordPanel.TabIndex = 1;
            // 
            // SecondPasswordTextBox
            // 
            this.SecondPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondPasswordTextBox.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPasswordTextBox.Location = new System.Drawing.Point(0, 119);
            this.SecondPasswordTextBox.Name = "SecondPasswordTextBox";
            this.SecondPasswordTextBox.PasswordChar = '*';
            this.SecondPasswordTextBox.Size = new System.Drawing.Size(483, 43);
            this.SecondPasswordTextBox.TabIndex = 2;
            this.SecondPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SecondPasswordTextBox.TextChanged += new System.EventHandler(this.SecondPasswordTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 36);
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
            this.FirstPasswordTextBox.Size = new System.Drawing.Size(483, 43);
            this.FirstPasswordTextBox.TabIndex = 1;
            this.FirstPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Создайте новый пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEllipse
            // 
            this.FormEllipse.ElipseRadius = 10;
            this.FormEllipse.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(63, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 685);
            this.panel1.TabIndex = 8;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Gainsboro;
            this.gunaElipsePanel1.Controls.Add(this.SetPasswordTextBox);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 36);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(483, 40);
            this.gunaElipsePanel1.TabIndex = 5;
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
            this.BottomPanel.ResumeLayout(false);
            this.AppHeaderPanel.ResumeLayout(false);
            this.GradientHeaderPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.LeftNavPanel.ResumeLayout(false);
            this.FormsPanel.ResumeLayout(false);
            this.PasswordPanel.ResumeLayout(false);
            this.InputPasswordPanel.ResumeLayout(false);
            this.SetNewPasswordPanel.ResumeLayout(false);
            this.SetNewPasswordPanel.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Panel AppHeaderPanel;
        private Panel BodyPanel;
        private Panel TopPanel;
        private Label label1;
        private Panel FormsPanel;
        private Panel LeftNavPanel;
        private Panel PasswordPanel;
        private Panel SetNewPasswordPanel;
        private Label label3;
        private TextBox SecondPasswordTextBox;
        private TextBox FirstPasswordTextBox;
        private Label label2;
        private Panel InputPasswordPanel;
        private TextBox SetPasswordTextBox;
        private Label label4;
        private Bunifu.Framework.UI.BunifuElipse FormEllipse;
        private Panel BottomColorPanel;
        private Guna.UI.WinForms.GunaGradient2Panel GradientHeaderPanel;
        private Guna.UI.WinForms.GunaGradient2Panel BottomGradientPanel;
        private Panel BottomPanel;
        private Panel TopColorPanel;
        private Guna.UI.WinForms.GunaCircleButton btnCloseCircle;
        private Guna.UI.WinForms.GunaCircleButton btnWrapCircle;
        private Guna.UI.WinForms.GunaCircleButton btnOpenCircle;
        private Guna.UI.WinForms.GunaImageButton btnNavItemSettings;
        private Guna.UI.WinForms.GunaImageButton btnNavItemTasks;
        private Guna.UI.WinForms.GunaImageButton btnNavItemIdeas;
        private Guna.UI.WinForms.GunaImageButton btnNavItemDiary;
        private Panel panel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
    }
}

