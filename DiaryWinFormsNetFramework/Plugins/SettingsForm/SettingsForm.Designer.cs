namespace DiaryWinFormsNetFramework.Plugins.SettingsForm
{
    partial class SettingsForm
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
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.labelSettingsDirectory = new System.Windows.Forms.Label();
            this.panelDirectorySetting = new System.Windows.Forms.Panel();
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.labelDirectorySetting = new System.Windows.Forms.Label();
            this.labelStoryDirectory = new System.Windows.Forms.Label();
            this.panelDirectoryStories = new System.Windows.Forms.Panel();
            this.btnOpenFolderDialogForStories = new System.Windows.Forms.Button();
            this.labelDirectoryStories = new System.Windows.Forms.Label();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BodyPanel.SuspendLayout();
            this.panelDirectorySetting.SuspendLayout();
            this.panelDirectoryStories.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.panel2);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1120, 690);
            this.BodyPanel.TabIndex = 0;
            // 
            // labelSettingsDirectory
            // 
            this.labelSettingsDirectory.AutoSize = true;
            this.labelSettingsDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSettingsDirectory.Location = new System.Drawing.Point(0, 0);
            this.labelSettingsDirectory.Name = "labelSettingsDirectory";
            this.labelSettingsDirectory.Size = new System.Drawing.Size(189, 17);
            this.labelSettingsDirectory.TabIndex = 2;
            this.labelSettingsDirectory.Text = "Application settings directory";
            // 
            // panelDirectorySetting
            // 
            this.panelDirectorySetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDirectorySetting.Controls.Add(this.btnOpenFolderDialog);
            this.panelDirectorySetting.Controls.Add(this.labelDirectorySetting);
            this.panelDirectorySetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDirectorySetting.Location = new System.Drawing.Point(0, 17);
            this.panelDirectorySetting.Name = "panelDirectorySetting";
            this.panelDirectorySetting.Size = new System.Drawing.Size(1064, 37);
            this.panelDirectorySetting.TabIndex = 0;
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolderDialog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenFolderDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(1007, -1);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(56, 37);
            this.btnOpenFolderDialog.TabIndex = 1;
            this.btnOpenFolderDialog.Text = "...";
            this.btnOpenFolderDialog.UseVisualStyleBackColor = false;
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnOpenFolderDialog_Click);
            // 
            // labelDirectorySetting
            // 
            this.labelDirectorySetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirectorySetting.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectorySetting.Location = new System.Drawing.Point(-1, 0);
            this.labelDirectorySetting.Name = "labelDirectorySetting";
            this.labelDirectorySetting.Size = new System.Drawing.Size(1002, 35);
            this.labelDirectorySetting.TabIndex = 0;
            this.labelDirectorySetting.Text = "default directory";
            this.labelDirectorySetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStoryDirectory
            // 
            this.labelStoryDirectory.AutoSize = true;
            this.labelStoryDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStoryDirectory.Location = new System.Drawing.Point(0, 54);
            this.labelStoryDirectory.Name = "labelStoryDirectory";
            this.labelStoryDirectory.Size = new System.Drawing.Size(129, 17);
            this.labelStoryDirectory.TabIndex = 3;
            this.labelStoryDirectory.Text = "Story files directory";
            // 
            // panelDirectoryStories
            // 
            this.panelDirectoryStories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDirectoryStories.Controls.Add(this.btnOpenFolderDialogForStories);
            this.panelDirectoryStories.Controls.Add(this.labelDirectoryStories);
            this.panelDirectoryStories.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDirectoryStories.Location = new System.Drawing.Point(0, 71);
            this.panelDirectoryStories.Name = "panelDirectoryStories";
            this.panelDirectoryStories.Size = new System.Drawing.Size(1064, 37);
            this.panelDirectoryStories.TabIndex = 2;
            // 
            // btnOpenFolderDialogForStories
            // 
            this.btnOpenFolderDialogForStories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolderDialogForStories.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenFolderDialogForStories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderDialogForStories.Location = new System.Drawing.Point(1007, -1);
            this.btnOpenFolderDialogForStories.Name = "btnOpenFolderDialogForStories";
            this.btnOpenFolderDialogForStories.Size = new System.Drawing.Size(56, 37);
            this.btnOpenFolderDialogForStories.TabIndex = 1;
            this.btnOpenFolderDialogForStories.Text = "...";
            this.btnOpenFolderDialogForStories.UseVisualStyleBackColor = false;
            this.btnOpenFolderDialogForStories.Click += new System.EventHandler(this.btnOpenFolderDialogForStories_Click);
            // 
            // labelDirectoryStories
            // 
            this.labelDirectoryStories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirectoryStories.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectoryStories.Location = new System.Drawing.Point(0, 0);
            this.labelDirectoryStories.Name = "labelDirectoryStories";
            this.labelDirectoryStories.Size = new System.Drawing.Size(1001, 35);
            this.labelDirectoryStories.TabIndex = 0;
            this.labelDirectoryStories.Text = "default directory";
            this.labelDirectoryStories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panelDirectoryStories);
            this.panel2.Controls.Add(this.labelStoryDirectory);
            this.panel2.Controls.Add(this.panelDirectorySetting);
            this.panel2.Controls.Add(this.labelSettingsDirectory);
            this.panel2.Location = new System.Drawing.Point(28, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 509);
            this.panel2.TabIndex = 4;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1120, 690);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.BodyPanel.ResumeLayout(false);
            this.panelDirectorySetting.ResumeLayout(false);
            this.panelDirectoryStories.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Panel panelDirectorySetting;
        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.Label labelDirectorySetting;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Panel panelDirectoryStories;
        private System.Windows.Forms.Button btnOpenFolderDialogForStories;
        private System.Windows.Forms.Label labelDirectoryStories;
        private System.Windows.Forms.Label labelSettingsDirectory;
        private System.Windows.Forms.Label labelStoryDirectory;
        private System.Windows.Forms.Panel panel2;
    }
}