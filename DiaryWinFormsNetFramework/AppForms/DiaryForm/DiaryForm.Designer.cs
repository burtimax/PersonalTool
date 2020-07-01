using DiaryWinFormsNetFramework.Plugins.BaseForm;

namespace DiaryWinFormsNetFramework.View
{
    partial class DiaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaryForm));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.btnOpenWritePanel = new System.Windows.Forms.Button();
            this.btnOpenStoragePanel = new System.Windows.Forms.Button();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.TabWriterPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.StoryTextContainer = new DiaryWinFormsNetFramework.UserControls.TextContainer();
            this.IdeaTextContainer = new DiaryWinFormsNetFramework.UserControls.TextContainer();
            this.AchievemantsTextContainer = new DiaryWinFormsNetFramework.UserControls.TextContainer();
            this.TabPanel = new System.Windows.Forms.Panel();
            this.TabAwards = new System.Windows.Forms.RadioButton();
            this.TabIdea = new System.Windows.Forms.RadioButton();
            this.TabStory = new System.Windows.Forms.RadioButton();
            this.TabReaderPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listBoxDocuments = new System.Windows.Forms.ListBox();
            this.TextContainerDocumentContent = new DiaryWinFormsNetFramework.UserControls.TextContainer();
            this.diaryFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BodyPanel.SuspendLayout();
            this.TabWriterPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.TabReaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaryFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyPanel.Controls.Add(this.btnOpenWritePanel);
            this.BodyPanel.Controls.Add(this.btnOpenStoragePanel);
            this.BodyPanel.Controls.Add(this.btnSaveText);
            this.BodyPanel.Controls.Add(this.TabWriterPanel);
            this.BodyPanel.Controls.Add(this.TabReaderPanel);
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1120, 690);
            this.BodyPanel.TabIndex = 0;
            // 
            // btnOpenWritePanel
            // 
            this.btnOpenWritePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenWritePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenWritePanel.BackgroundImage")));
            this.btnOpenWritePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenWritePanel.FlatAppearance.BorderSize = 0;
            this.btnOpenWritePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenWritePanel.Location = new System.Drawing.Point(35, 631);
            this.btnOpenWritePanel.Name = "btnOpenWritePanel";
            this.btnOpenWritePanel.Size = new System.Drawing.Size(41, 47);
            this.btnOpenWritePanel.TabIndex = 6;
            this.btnOpenWritePanel.UseVisualStyleBackColor = true;
            this.btnOpenWritePanel.Click += new System.EventHandler(this.btnOpenWritePanel_Click);
            // 
            // btnOpenStoragePanel
            // 
            this.btnOpenStoragePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenStoragePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenStoragePanel.BackgroundImage")));
            this.btnOpenStoragePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenStoragePanel.FlatAppearance.BorderSize = 0;
            this.btnOpenStoragePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenStoragePanel.Location = new System.Drawing.Point(89, 629);
            this.btnOpenStoragePanel.Name = "btnOpenStoragePanel";
            this.btnOpenStoragePanel.Size = new System.Drawing.Size(54, 54);
            this.btnOpenStoragePanel.TabIndex = 5;
            this.btnOpenStoragePanel.UseVisualStyleBackColor = true;
            this.btnOpenStoragePanel.Click += new System.EventHandler(this.btnOpenStoragePanel_Click);
            // 
            // btnSaveText
            // 
            this.btnSaveText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveText.BackgroundImage")));
            this.btnSaveText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveText.FlatAppearance.BorderSize = 0;
            this.btnSaveText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveText.Location = new System.Drawing.Point(1042, 639);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(43, 39);
            this.btnSaveText.TabIndex = 3;
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TabWriterPanel
            // 
            this.TabWriterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabWriterPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TabWriterPanel.Controls.Add(this.ContentPanel);
            this.TabWriterPanel.Controls.Add(this.TabPanel);
            this.TabWriterPanel.Location = new System.Drawing.Point(35, 12);
            this.TabWriterPanel.Name = "TabWriterPanel";
            this.TabWriterPanel.Size = new System.Drawing.Size(1050, 611);
            this.TabWriterPanel.TabIndex = 2;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.Controls.Add(this.StoryTextContainer);
            this.ContentPanel.Controls.Add(this.IdeaTextContainer);
            this.ContentPanel.Controls.Add(this.AchievemantsTextContainer);
            this.ContentPanel.Location = new System.Drawing.Point(3, 45);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1044, 563);
            this.ContentPanel.TabIndex = 1;
            // 
            // StoryTextContainer
            // 
            this.StoryTextContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoryTextContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StoryTextContainer.BackColor = System.Drawing.Color.White;
            this.StoryTextContainer.ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StoryTextContainer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoryTextContainer.Location = new System.Drawing.Point(0, 0);
            this.StoryTextContainer.Margin = new System.Windows.Forms.Padding(0);
            this.StoryTextContainer.Name = "StoryTextContainer";
            this.StoryTextContainer.Size = new System.Drawing.Size(1044, 563);
            this.StoryTextContainer.TabIndex = 1;
            this.StoryTextContainer.Title = "Story";
            // 
            // IdeaTextContainer
            // 
            this.IdeaTextContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdeaTextContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IdeaTextContainer.BackColor = System.Drawing.Color.White;
            this.IdeaTextContainer.ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdeaTextContainer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaTextContainer.Location = new System.Drawing.Point(0, 0);
            this.IdeaTextContainer.Margin = new System.Windows.Forms.Padding(0);
            this.IdeaTextContainer.Name = "IdeaTextContainer";
            this.IdeaTextContainer.Size = new System.Drawing.Size(1044, 563);
            this.IdeaTextContainer.TabIndex = 0;
            this.IdeaTextContainer.Title = "Idea";
            // 
            // AchievemantsTextContainer
            // 
            this.AchievemantsTextContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AchievemantsTextContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AchievemantsTextContainer.BackColor = System.Drawing.Color.White;
            this.AchievemantsTextContainer.ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AchievemantsTextContainer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchievemantsTextContainer.Location = new System.Drawing.Point(0, 0);
            this.AchievemantsTextContainer.Margin = new System.Windows.Forms.Padding(0);
            this.AchievemantsTextContainer.Name = "AchievemantsTextContainer";
            this.AchievemantsTextContainer.Size = new System.Drawing.Size(1044, 563);
            this.AchievemantsTextContainer.TabIndex = 2;
            this.AchievemantsTextContainer.Title = "Awards";
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.TabAwards);
            this.TabPanel.Controls.Add(this.TabIdea);
            this.TabPanel.Controls.Add(this.TabStory);
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabPanel.Location = new System.Drawing.Point(0, 0);
            this.TabPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(1050, 45);
            this.TabPanel.TabIndex = 2;
            // 
            // TabAwards
            // 
            this.TabAwards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TabAwards.Appearance = System.Windows.Forms.Appearance.Button;
            this.TabAwards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TabAwards.FlatAppearance.BorderSize = 0;
            this.TabAwards.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.TabAwards.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.TabAwards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabAwards.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabAwards.Location = new System.Drawing.Point(229, 15);
            this.TabAwards.Margin = new System.Windows.Forms.Padding(0);
            this.TabAwards.Name = "TabAwards";
            this.TabAwards.Size = new System.Drawing.Size(113, 36);
            this.TabAwards.TabIndex = 2;
            this.TabAwards.TabStop = true;
            this.TabAwards.Text = "Awards";
            this.TabAwards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TabAwards.UseVisualStyleBackColor = false;
            // 
            // TabIdea
            // 
            this.TabIdea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TabIdea.Appearance = System.Windows.Forms.Appearance.Button;
            this.TabIdea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TabIdea.FlatAppearance.BorderSize = 0;
            this.TabIdea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.TabIdea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.TabIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabIdea.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabIdea.Location = new System.Drawing.Point(116, 15);
            this.TabIdea.Margin = new System.Windows.Forms.Padding(0);
            this.TabIdea.Name = "TabIdea";
            this.TabIdea.Size = new System.Drawing.Size(113, 36);
            this.TabIdea.TabIndex = 1;
            this.TabIdea.TabStop = true;
            this.TabIdea.Text = "Idea";
            this.TabIdea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TabIdea.UseVisualStyleBackColor = false;
            // 
            // TabStory
            // 
            this.TabStory.Appearance = System.Windows.Forms.Appearance.Button;
            this.TabStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TabStory.FlatAppearance.BorderSize = 0;
            this.TabStory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.TabStory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.TabStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabStory.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabStory.Location = new System.Drawing.Point(3, 15);
            this.TabStory.Margin = new System.Windows.Forms.Padding(0);
            this.TabStory.Name = "TabStory";
            this.TabStory.Size = new System.Drawing.Size(113, 36);
            this.TabStory.TabIndex = 0;
            this.TabStory.TabStop = true;
            this.TabStory.Text = "Story";
            this.TabStory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TabStory.UseVisualStyleBackColor = false;
            // 
            // TabReaderPanel
            // 
            this.TabReaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabReaderPanel.Controls.Add(this.splitContainer);
            this.TabReaderPanel.Location = new System.Drawing.Point(35, 12);
            this.TabReaderPanel.Name = "TabReaderPanel";
            this.TabReaderPanel.Size = new System.Drawing.Size(1050, 608);
            this.TabReaderPanel.TabIndex = 4;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listBoxDocuments);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.TextContainerDocumentContent);
            this.splitContainer.Size = new System.Drawing.Size(1050, 608);
            this.splitContainer.SplitterDistance = 282;
            this.splitContainer.TabIndex = 0;
            // 
            // listBoxDocuments
            // 
            this.listBoxDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDocuments.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDocuments.FormattingEnabled = true;
            this.listBoxDocuments.ItemHeight = 23;
            this.listBoxDocuments.Location = new System.Drawing.Point(0, 0);
            this.listBoxDocuments.Name = "listBoxDocuments";
            this.listBoxDocuments.Size = new System.Drawing.Size(282, 608);
            this.listBoxDocuments.TabIndex = 0;
            this.listBoxDocuments.SelectedIndexChanged += new System.EventHandler(this.listBoxDocuments_SelectedIndexChanged);
            // 
            // TextContainerDocumentContent
            // 
            this.TextContainerDocumentContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TextContainerDocumentContent.BackColor = System.Drawing.Color.White;
            this.TextContainerDocumentContent.ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.TextContainerDocumentContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextContainerDocumentContent.Location = new System.Drawing.Point(0, 0);
            this.TextContainerDocumentContent.Name = "TextContainerDocumentContent";
            this.TextContainerDocumentContent.Size = new System.Drawing.Size(764, 608);
            this.TextContainerDocumentContent.TabIndex = 0;
            this.TextContainerDocumentContent.Title = "Document content";
            // 
            // diaryFormBindingSource
            // 
            this.diaryFormBindingSource.DataSource = typeof(DiaryWinFormsNetFramework.View.DiaryForm);
            // 
            // DiaryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1120, 690);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiaryForm";
            this.Text = "DiaryForm";
            this.Load += new System.EventHandler(this.DiaryForm_Load);
            this.BodyPanel.ResumeLayout(false);
            this.TabWriterPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.TabPanel.ResumeLayout(false);
            this.TabReaderPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diaryFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private UserControls.TextContainer IdeaTextContainer;
        private System.Windows.Forms.Panel TabWriterPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel TabPanel;
        private System.Windows.Forms.RadioButton TabAwards;
        private System.Windows.Forms.RadioButton TabIdea;
        private System.Windows.Forms.RadioButton TabStory;
        private UserControls.TextContainer StoryTextContainer;
        private UserControls.TextContainer AchievemantsTextContainer;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Panel TabReaderPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox listBoxDocuments;
        private UserControls.TextContainer TextContainerDocumentContent;
        private System.Windows.Forms.BindingSource diaryFormBindingSource;
        private System.Windows.Forms.Button btnOpenWritePanel;
        private System.Windows.Forms.Button btnOpenStoragePanel;
    }
}