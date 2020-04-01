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
            this.panelDirectorySetting = new System.Windows.Forms.Panel();
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.labelDirectorySetting = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BodyPanel.SuspendLayout();
            this.LayoutPanelSettings.SuspendLayout();
            this.panelDirectorySetting.SuspendLayout();
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
            this.LayoutPanelSettings.Controls.Add(this.panelDirectorySetting);
            this.LayoutPanelSettings.Controls.Add(this.panel2);
            this.LayoutPanelSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayoutPanelSettings.Location = new System.Drawing.Point(44, 43);
            this.LayoutPanelSettings.Name = "LayoutPanelSettings";
            this.LayoutPanelSettings.Size = new System.Drawing.Size(1033, 606);
            this.LayoutPanelSettings.TabIndex = 0;
            // 
            // panelDirectorySetting
            // 
            this.panelDirectorySetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDirectorySetting.Controls.Add(this.btnOpenFolderDialog);
            this.panelDirectorySetting.Controls.Add(this.labelDirectorySetting);
            this.panelDirectorySetting.Location = new System.Drawing.Point(3, 3);
            this.panelDirectorySetting.Name = "panelDirectorySetting";
            this.panelDirectorySetting.Size = new System.Drawing.Size(1030, 65);
            this.panelDirectorySetting.TabIndex = 0;
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(985, 12);
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 690);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.BodyPanel.ResumeLayout(false);
            this.LayoutPanelSettings.ResumeLayout(false);
            this.panelDirectorySetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelSettings;
        private System.Windows.Forms.Panel panelDirectorySetting;
        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.Label labelDirectorySetting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
    }
}