namespace DiaryWinFormsNetFramework.Plugins.IdeaForm
{
    partial class IdeasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdeasForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.IdeasListPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelIdeas = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.CreateIdeaPanel = new System.Windows.Forms.Panel();
            this.CreateIdeaElementsPanel = new System.Windows.Forms.Panel();
            this.btnSaveIdea = new System.Windows.Forms.Button();
            this.IdeaMark = new System.Windows.Forms.ComboBox();
            this.IdeaSection = new System.Windows.Forms.ComboBox();
            this.IdeaDescription = new System.Windows.Forms.RichTextBox();
            this.IdeaTitleBackPanel = new System.Windows.Forms.Panel();
            this.IdeaTitle = new System.Windows.Forms.TextBox();
            this.SearchShowIdeaPanel = new System.Windows.Forms.Panel();
            this.ShowIdeaDataPanel = new System.Windows.Forms.Panel();
            this.btnDeleteIdea = new System.Windows.Forms.Button();
            this.btnChangeIdeaData = new System.Windows.Forms.Button();
            this.ShowIdeaMark = new System.Windows.Forms.ComboBox();
            this.ShowIdeaSection = new System.Windows.Forms.ComboBox();
            this.ShowIdeaDescription = new System.Windows.Forms.RichTextBox();
            this.ShowTitleBackPanel = new System.Windows.Forms.Panel();
            this.ShowIdeaTitle = new System.Windows.Forms.TextBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddIdea = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.IdeasListPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.CreateIdeaPanel.SuspendLayout();
            this.CreateIdeaElementsPanel.SuspendLayout();
            this.IdeaTitleBackPanel.SuspendLayout();
            this.SearchShowIdeaPanel.SuspendLayout();
            this.ShowIdeaDataPanel.SuspendLayout();
            this.ShowTitleBackPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ContentPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1102, 643);
            this.MainPanel.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.Controls.Add(this.RightPanel);
            this.ContentPanel.Controls.Add(this.LeftPanel);
            this.ContentPanel.Location = new System.Drawing.Point(12, 12);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1078, 619);
            this.ContentPanel.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RightPanel.Controls.Add(this.IdeasListPanel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(593, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(485, 619);
            this.RightPanel.TabIndex = 1;
            // 
            // IdeasListPanel
            // 
            this.IdeasListPanel.Controls.Add(this.flowLayoutPanelIdeas);
            this.IdeasListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdeasListPanel.Location = new System.Drawing.Point(0, 0);
            this.IdeasListPanel.Name = "IdeasListPanel";
            this.IdeasListPanel.Size = new System.Drawing.Size(485, 619);
            this.IdeasListPanel.TabIndex = 1;
            // 
            // flowLayoutPanelIdeas
            // 
            this.flowLayoutPanelIdeas.AutoScroll = true;
            this.flowLayoutPanelIdeas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanelIdeas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelIdeas.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelIdeas.Name = "flowLayoutPanelIdeas";
            this.flowLayoutPanelIdeas.Size = new System.Drawing.Size(485, 619);
            this.flowLayoutPanelIdeas.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftPanel.Controls.Add(this.CreateIdeaPanel);
            this.LeftPanel.Controls.Add(this.SearchShowIdeaPanel);
            this.LeftPanel.Controls.Add(this.ButtonsPanel);
            this.LeftPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(585, 616);
            this.LeftPanel.TabIndex = 2;
            // 
            // CreateIdeaPanel
            // 
            this.CreateIdeaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateIdeaPanel.BackColor = System.Drawing.Color.Transparent;
            this.CreateIdeaPanel.Controls.Add(this.CreateIdeaElementsPanel);
            this.CreateIdeaPanel.Location = new System.Drawing.Point(0, 58);
            this.CreateIdeaPanel.Name = "CreateIdeaPanel";
            this.CreateIdeaPanel.Size = new System.Drawing.Size(585, 555);
            this.CreateIdeaPanel.TabIndex = 2;
            // 
            // CreateIdeaElementsPanel
            // 
            this.CreateIdeaElementsPanel.Controls.Add(this.btnSaveIdea);
            this.CreateIdeaElementsPanel.Controls.Add(this.IdeaMark);
            this.CreateIdeaElementsPanel.Controls.Add(this.IdeaSection);
            this.CreateIdeaElementsPanel.Controls.Add(this.IdeaDescription);
            this.CreateIdeaElementsPanel.Controls.Add(this.IdeaTitleBackPanel);
            this.CreateIdeaElementsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateIdeaElementsPanel.Location = new System.Drawing.Point(0, 0);
            this.CreateIdeaElementsPanel.Name = "CreateIdeaElementsPanel";
            this.CreateIdeaElementsPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.CreateIdeaElementsPanel.Size = new System.Drawing.Size(585, 555);
            this.CreateIdeaElementsPanel.TabIndex = 0;
            // 
            // btnSaveIdea
            // 
            this.btnSaveIdea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveIdea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveIdea.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSaveIdea.FlatAppearance.BorderSize = 3;
            this.btnSaveIdea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSaveIdea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveIdea.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveIdea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSaveIdea.Location = new System.Drawing.Point(421, 364);
            this.btnSaveIdea.Name = "btnSaveIdea";
            this.btnSaveIdea.Size = new System.Drawing.Size(134, 51);
            this.btnSaveIdea.TabIndex = 5;
            this.btnSaveIdea.Text = "ADD IDEA";
            this.btnSaveIdea.UseVisualStyleBackColor = true;
            this.btnSaveIdea.Click += new System.EventHandler(this.btnSaveIdea_Click);
            // 
            // IdeaMark
            // 
            this.IdeaMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdeaMark.BackColor = System.Drawing.Color.LightGray;
            this.IdeaMark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IdeaMark.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaMark.FormattingEnabled = true;
            this.IdeaMark.Location = new System.Drawing.Point(401, 116);
            this.IdeaMark.Name = "IdeaMark";
            this.IdeaMark.Size = new System.Drawing.Size(154, 36);
            this.IdeaMark.TabIndex = 2;
            // 
            // IdeaSection
            // 
            this.IdeaSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdeaSection.BackColor = System.Drawing.Color.LightGray;
            this.IdeaSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IdeaSection.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaSection.FormattingEnabled = true;
            this.IdeaSection.Location = new System.Drawing.Point(30, 117);
            this.IdeaSection.Name = "IdeaSection";
            this.IdeaSection.Size = new System.Drawing.Size(365, 36);
            this.IdeaSection.TabIndex = 1;
            // 
            // IdeaDescription
            // 
            this.IdeaDescription.AcceptsTab = true;
            this.IdeaDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdeaDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IdeaDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdeaDescription.BulletIndent = 1;
            this.IdeaDescription.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IdeaDescription.Location = new System.Drawing.Point(33, 159);
            this.IdeaDescription.Name = "IdeaDescription";
            this.IdeaDescription.Size = new System.Drawing.Size(522, 196);
            this.IdeaDescription.TabIndex = 3;
            this.IdeaDescription.Text = "";
            // 
            // IdeaTitleBackPanel
            // 
            this.IdeaTitleBackPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdeaTitleBackPanel.BackColor = System.Drawing.Color.LightGray;
            this.IdeaTitleBackPanel.Controls.Add(this.IdeaTitle);
            this.IdeaTitleBackPanel.Location = new System.Drawing.Point(30, 30);
            this.IdeaTitleBackPanel.Name = "IdeaTitleBackPanel";
            this.IdeaTitleBackPanel.Size = new System.Drawing.Size(525, 80);
            this.IdeaTitleBackPanel.TabIndex = 6;
            // 
            // IdeaTitle
            // 
            this.IdeaTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdeaTitle.BackColor = System.Drawing.Color.LightGray;
            this.IdeaTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdeaTitle.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaTitle.Location = new System.Drawing.Point(20, 25);
            this.IdeaTitle.Name = "IdeaTitle";
            this.IdeaTitle.Size = new System.Drawing.Size(485, 29);
            this.IdeaTitle.TabIndex = 0;
            this.IdeaTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchShowIdeaPanel
            // 
            this.SearchShowIdeaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchShowIdeaPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchShowIdeaPanel.Controls.Add(this.ShowIdeaDataPanel);
            this.SearchShowIdeaPanel.Location = new System.Drawing.Point(0, 53);
            this.SearchShowIdeaPanel.Name = "SearchShowIdeaPanel";
            this.SearchShowIdeaPanel.Size = new System.Drawing.Size(585, 557);
            this.SearchShowIdeaPanel.TabIndex = 3;
            // 
            // ShowIdeaDataPanel
            // 
            this.ShowIdeaDataPanel.Controls.Add(this.btnDeleteIdea);
            this.ShowIdeaDataPanel.Controls.Add(this.btnChangeIdeaData);
            this.ShowIdeaDataPanel.Controls.Add(this.ShowIdeaMark);
            this.ShowIdeaDataPanel.Controls.Add(this.ShowIdeaSection);
            this.ShowIdeaDataPanel.Controls.Add(this.ShowIdeaDescription);
            this.ShowIdeaDataPanel.Controls.Add(this.ShowTitleBackPanel);
            this.ShowIdeaDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowIdeaDataPanel.Location = new System.Drawing.Point(0, 0);
            this.ShowIdeaDataPanel.Name = "ShowIdeaDataPanel";
            this.ShowIdeaDataPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.ShowIdeaDataPanel.Size = new System.Drawing.Size(585, 557);
            this.ShowIdeaDataPanel.TabIndex = 0;
            // 
            // btnDeleteIdea
            // 
            this.btnDeleteIdea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteIdea.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteIdea.FlatAppearance.BorderSize = 3;
            this.btnDeleteIdea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDeleteIdea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteIdea.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIdea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteIdea.Location = new System.Drawing.Point(30, 361);
            this.btnDeleteIdea.Name = "btnDeleteIdea";
            this.btnDeleteIdea.Size = new System.Drawing.Size(134, 51);
            this.btnDeleteIdea.TabIndex = 7;
            this.btnDeleteIdea.Text = "DELETE";
            this.btnDeleteIdea.UseVisualStyleBackColor = true;
            this.btnDeleteIdea.Click += new System.EventHandler(this.btnDeleteIdea_Click);
            // 
            // btnChangeIdeaData
            // 
            this.btnChangeIdeaData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeIdeaData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangeIdeaData.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnChangeIdeaData.FlatAppearance.BorderSize = 3;
            this.btnChangeIdeaData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnChangeIdeaData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChangeIdeaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeIdeaData.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeIdeaData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChangeIdeaData.Location = new System.Drawing.Point(421, 364);
            this.btnChangeIdeaData.Name = "btnChangeIdeaData";
            this.btnChangeIdeaData.Size = new System.Drawing.Size(134, 51);
            this.btnChangeIdeaData.TabIndex = 5;
            this.btnChangeIdeaData.Text = "SAVE";
            this.btnChangeIdeaData.UseVisualStyleBackColor = true;
            this.btnChangeIdeaData.Click += new System.EventHandler(this.btnChangeIdeaData_Click);
            // 
            // ShowIdeaMark
            // 
            this.ShowIdeaMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowIdeaMark.BackColor = System.Drawing.Color.LightGray;
            this.ShowIdeaMark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowIdeaMark.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIdeaMark.FormattingEnabled = true;
            this.ShowIdeaMark.Location = new System.Drawing.Point(401, 116);
            this.ShowIdeaMark.Name = "ShowIdeaMark";
            this.ShowIdeaMark.Size = new System.Drawing.Size(154, 36);
            this.ShowIdeaMark.TabIndex = 2;
            // 
            // ShowIdeaSection
            // 
            this.ShowIdeaSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowIdeaSection.BackColor = System.Drawing.Color.LightGray;
            this.ShowIdeaSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowIdeaSection.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIdeaSection.FormattingEnabled = true;
            this.ShowIdeaSection.Location = new System.Drawing.Point(30, 117);
            this.ShowIdeaSection.Name = "ShowIdeaSection";
            this.ShowIdeaSection.Size = new System.Drawing.Size(365, 36);
            this.ShowIdeaSection.TabIndex = 1;
            // 
            // ShowIdeaDescription
            // 
            this.ShowIdeaDescription.AcceptsTab = true;
            this.ShowIdeaDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowIdeaDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowIdeaDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowIdeaDescription.BulletIndent = 1;
            this.ShowIdeaDescription.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIdeaDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ShowIdeaDescription.Location = new System.Drawing.Point(33, 159);
            this.ShowIdeaDescription.Name = "ShowIdeaDescription";
            this.ShowIdeaDescription.Size = new System.Drawing.Size(522, 196);
            this.ShowIdeaDescription.TabIndex = 3;
            this.ShowIdeaDescription.Text = "";
            // 
            // ShowTitleBackPanel
            // 
            this.ShowTitleBackPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowTitleBackPanel.BackColor = System.Drawing.Color.LightGray;
            this.ShowTitleBackPanel.Controls.Add(this.ShowIdeaTitle);
            this.ShowTitleBackPanel.Location = new System.Drawing.Point(30, 30);
            this.ShowTitleBackPanel.Name = "ShowTitleBackPanel";
            this.ShowTitleBackPanel.Size = new System.Drawing.Size(525, 80);
            this.ShowTitleBackPanel.TabIndex = 6;
            // 
            // ShowIdeaTitle
            // 
            this.ShowIdeaTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowIdeaTitle.BackColor = System.Drawing.Color.LightGray;
            this.ShowIdeaTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowIdeaTitle.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIdeaTitle.Location = new System.Drawing.Point(20, 25);
            this.ShowIdeaTitle.Name = "ShowIdeaTitle";
            this.ShowIdeaTitle.Size = new System.Drawing.Size(485, 29);
            this.ShowIdeaTitle.TabIndex = 0;
            this.ShowIdeaTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonsPanel.Controls.Add(this.btnSearch);
            this.ButtonsPanel.Controls.Add(this.btnAddIdea);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(585, 52);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(60, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 52);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddIdea
            // 
            this.btnAddIdea.BackColor = System.Drawing.Color.Transparent;
            this.btnAddIdea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddIdea.BackgroundImage")));
            this.btnAddIdea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddIdea.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddIdea.FlatAppearance.BorderSize = 0;
            this.btnAddIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIdea.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIdea.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddIdea.Location = new System.Drawing.Point(0, 0);
            this.btnAddIdea.Name = "btnAddIdea";
            this.btnAddIdea.Size = new System.Drawing.Size(60, 52);
            this.btnAddIdea.TabIndex = 5;
            this.btnAddIdea.UseVisualStyleBackColor = false;
            this.btnAddIdea.Click += new System.EventHandler(this.btnAddIdea_Click);
            // 
            // IdeasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 643);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IdeasForm";
            this.Text = "IdeasForm";
            this.Load += new System.EventHandler(this.IdeasForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.IdeasListPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.CreateIdeaPanel.ResumeLayout(false);
            this.CreateIdeaElementsPanel.ResumeLayout(false);
            this.IdeaTitleBackPanel.ResumeLayout(false);
            this.IdeaTitleBackPanel.PerformLayout();
            this.SearchShowIdeaPanel.ResumeLayout(false);
            this.ShowIdeaDataPanel.ResumeLayout(false);
            this.ShowTitleBackPanel.ResumeLayout(false);
            this.ShowTitleBackPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel CreateIdeaElementsPanel;
        private System.Windows.Forms.Panel CreateIdeaPanel;
        private System.Windows.Forms.Panel IdeasListPanel;
        private System.Windows.Forms.ComboBox IdeaSection;
        private System.Windows.Forms.TextBox IdeaTitle;
        private System.Windows.Forms.RichTextBox IdeaDescription;
        private System.Windows.Forms.ComboBox IdeaMark;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnAddIdea;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSaveIdea;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelIdeas;
        private System.Windows.Forms.Panel IdeaTitleBackPanel;
        private System.Windows.Forms.Panel SearchShowIdeaPanel;
        private System.Windows.Forms.Panel ShowIdeaDataPanel;
        private System.Windows.Forms.Button btnChangeIdeaData;
        private System.Windows.Forms.ComboBox ShowIdeaMark;
        private System.Windows.Forms.ComboBox ShowIdeaSection;
        private System.Windows.Forms.RichTextBox ShowIdeaDescription;
        private System.Windows.Forms.Panel ShowTitleBackPanel;
        private System.Windows.Forms.TextBox ShowIdeaTitle;
        private System.Windows.Forms.Button btnDeleteIdea;
    }
}