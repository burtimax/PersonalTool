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
            this.LayoutPanelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSettingsDirectory = new System.Windows.Forms.Label();
            this.panelDirectorySetting = new System.Windows.Forms.Panel();
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.labelDirectorySetting = new System.Windows.Forms.Label();
            this.labelStoryDirectory = new System.Windows.Forms.Label();
            this.panelDirectoryStories = new System.Windows.Forms.Panel();
            this.btnOpenFolderDialogForStories = new System.Windows.Forms.Button();
            this.labelDirectoryStories = new System.Windows.Forms.Label();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BodyPanel.SuspendLayout();
            this.LayoutPanelSettings.SuspendLayout();
            this.panelDirectorySetting.SuspendLayout();
            this.panelDirectoryStories.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.LayoutPanelSettings);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1120, 690);
            this.BodyPanel.TabIndex = 0;
            // 
            // LayoutPanelSettings
            // 
            this.LayoutPanelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanelSettings.Controls.Add(this.labelSettingsDirectory);
            this.LayoutPanelSettings.Controls.Add(this.panelDirectorySetting);
            this.LayoutPanelSettings.Controls.Add(this.labelStoryDirectory);
            this.LayoutPanelSettings.Controls.Add(this.panelDirectoryStories);
            this.LayoutPanelSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayoutPanelSettings.Location = new System.Drawing.Point(44, 43);
            this.LayoutPanelSettings.Name = "LayoutPanelSettings";
            this.LayoutPanelSettings.Size = new System.Drawing.Size(1033, 606);
            this.LayoutPanelSettings.TabIndex = 0;
            // 
            // labelSettingsDirectory
            // 
            this.labelSettingsDirectory.AutoSize = true;
            this.labelSettingsDirectory.Location = new System.Drawing.Point(3, 0);
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
            this.panelDirectorySetting.Location = new System.Drawing.Point(3, 20);
            this.panelDirectorySetting.Name = "panelDirectorySetting";
            this.panelDirectorySetting.Size = new System.Drawing.Size(1030, 65);
            this.panelDirectorySetting.TabIndex = 0;
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(971, 12);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(40, 40);
            this.btnOpenFolderDialog.TabIndex = 1;
            this.btnOpenFolderDialog.Text = "...";
            this.btnOpenFolderDialog.UseVisualStyleBackColor = true;
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnOpenFolderDialog_Click);
            // 
            // labelDirectorySetting
            // 
            this.labelDirectorySetting.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectorySetting.Location = new System.Drawing.Point(3, -2);
            this.labelDirectorySetting.Name = "labelDirectorySetting";
            this.labelDirectorySetting.Size = new System.Drawing.Size(962, 65);
            this.labelDirectorySetting.TabIndex = 0;
            this.labelDirectorySetting.Text = "default directory";
            this.labelDirectorySetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStoryDirectory
            // 
            this.labelStoryDirectory.AutoSize = true;
            this.labelStoryDirectory.Location = new System.Drawing.Point(3, 88);
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
            this.panelDirectoryStories.Location = new System.Drawing.Point(3, 108);
            this.panelDirectoryStories.Name = "panelDirectoryStories";
            this.panelDirectoryStories.Size = new System.Drawing.Size(1030, 65);
            this.panelDirectoryStories.TabIndex = 2;
            // 
            // btnOpenFolderDialogForStories
            // 
            this.btnOpenFolderDialogForStories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderDialogForStories.Location = new System.Drawing.Point(971, 12);
            this.btnOpenFolderDialogForStories.Name = "btnOpenFolderDialogForStories";
            this.btnOpenFolderDialogForStories.Size = new System.Drawing.Size(40, 40);
            this.btnOpenFolderDialogForStories.TabIndex = 1;
            this.btnOpenFolderDialogForStories.Text = "...";
            this.btnOpenFolderDialogForStories.UseVisualStyleBackColor = true;
            this.btnOpenFolderDialogForStories.Click += new System.EventHandler(this.btnOpenFolderDialogForStories_Click);
            // 
            // labelDirectoryStories
            // 
            this.labelDirectoryStories.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectoryStories.Location = new System.Drawing.Point(3, -2);
            this.labelDirectoryStories.Name = "labelDirectoryStories";
            this.labelDirectoryStories.Size = new System.Drawing.Size(962, 65);
            this.labelDirectoryStories.TabIndex = 0;
            this.labelDirectoryStories.Text = "default directory";
            this.labelDirectoryStories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.LayoutPanelSettings.ResumeLayout(false);
            this.LayoutPanelSettings.PerformLayout();
            this.panelDirectorySetting.ResumeLayout(false);
            this.panelDirectoryStories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelSettings;
        private System.Windows.Forms.Panel panelDirectorySetting;
        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.Label labelDirectorySetting;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Panel panelDirectoryStories;
        private System.Windows.Forms.Button btnOpenFolderDialogForStories;
        private System.Windows.Forms.Label labelDirectoryStories;
        private System.Windows.Forms.Label labelSettingsDirectory;
        private System.Windows.Forms.Label labelStoryDirectory;
    }
}