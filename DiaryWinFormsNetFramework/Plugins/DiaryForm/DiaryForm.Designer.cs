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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaryForm));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.TabContentPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.StoryTextContainer = new DiaryWinFormsNetFramework.UserControls.TextContainer();
            this.IdeaTextContainer = new DiaryWinFormsNetFramework.UserControls.TextContainer();
            this.AchievemantsTextContainer = new DiaryWinFormsNetFramework.UserControls.TextContainer();
            this.TabPanel = new System.Windows.Forms.Panel();
            this.TabAwards = new System.Windows.Forms.RadioButton();
            this.TabIdea = new System.Windows.Forms.RadioButton();
            this.TabStory = new System.Windows.Forms.RadioButton();
            this.BodyPanel.SuspendLayout();
            this.TabContentPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.btnSaveText);
            this.BodyPanel.Controls.Add(this.TabContentPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1120, 690);
            this.BodyPanel.TabIndex = 0;
            // 
            // btnSaveText
            // 
            this.btnSaveText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveText.BackgroundImage")));
            this.btnSaveText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveText.FlatAppearance.BorderSize = 0;
            this.btnSaveText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveText.Location = new System.Drawing.Point(1032, 628);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(50, 50);
            this.btnSaveText.TabIndex = 3;
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TabContentPanel
            // 
            this.TabContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TabContentPanel.Controls.Add(this.ContentPanel);
            this.TabContentPanel.Controls.Add(this.TabPanel);
            this.TabContentPanel.Location = new System.Drawing.Point(35, 12);
            this.TabContentPanel.Name = "TabContentPanel";
            this.TabContentPanel.Size = new System.Drawing.Size(1050, 611);
            this.TabContentPanel.TabIndex = 2;
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
            // DiaryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1120, 690);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiaryForm";
            this.Text = "DiaryForm";
            this.Load += new System.EventHandler(this.DiaryForm_Load);
            this.BodyPanel.ResumeLayout(false);
            this.TabContentPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.TabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private UserControls.TextContainer IdeaTextContainer;
        private System.Windows.Forms.Panel TabContentPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel TabPanel;
        private System.Windows.Forms.RadioButton TabAwards;
        private System.Windows.Forms.RadioButton TabIdea;
        private System.Windows.Forms.RadioButton TabStory;
        private UserControls.TextContainer StoryTextContainer;
        private UserControls.TextContainer AchievemantsTextContainer;
        private System.Windows.Forms.Button btnSaveText;
    }
}