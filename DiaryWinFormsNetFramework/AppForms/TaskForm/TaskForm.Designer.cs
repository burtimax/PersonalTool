namespace DiaryWinFormsNetFramework.Plugins.TaskForm
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProjectsPanel = new System.Windows.Forms.Panel();
            this.ProjectsCommands = new System.Windows.Forms.Panel();
            this.ProjectListLabel = new System.Windows.Forms.Label();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.TaskCommands = new System.Windows.Forms.Panel();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.BodyPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ProjectsPanel.SuspendLayout();
            this.ProjectsCommands.SuspendLayout();
            this.TaskCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.ContentPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(1120, 690);
            this.BodyPanel.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Controls.Add(this.splitContainer1);
            this.ContentPanel.Location = new System.Drawing.Point(28, 23);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1064, 643);
            this.ContentPanel.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ProjectsPanel);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.TaskPanel);
            this.splitContainer1.Panel2.Controls.Add(this.TaskCommands);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 643);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 0;
            // 
            // ProjectsPanel
            // 
            this.ProjectsPanel.AutoScroll = true;
            this.ProjectsPanel.Controls.Add(this.ProjectsCommands);
            this.ProjectsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsPanel.Location = new System.Drawing.Point(0, 0);
            this.ProjectsPanel.Name = "ProjectsPanel";
            this.ProjectsPanel.Size = new System.Drawing.Size(324, 643);
            this.ProjectsPanel.TabIndex = 2;
            // 
            // ProjectsCommands
            // 
            this.ProjectsCommands.Controls.Add(this.ProjectListLabel);
            this.ProjectsCommands.Controls.Add(this.AddProjectBtn);
            this.ProjectsCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectsCommands.Location = new System.Drawing.Point(0, 0);
            this.ProjectsCommands.Name = "ProjectsCommands";
            this.ProjectsCommands.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ProjectsCommands.Size = new System.Drawing.Size(324, 42);
            this.ProjectsCommands.TabIndex = 2;
            // 
            // ProjectListLabel
            // 
            this.ProjectListLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProjectListLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProjectListLabel.Location = new System.Drawing.Point(37, 0);
            this.ProjectListLabel.Name = "ProjectListLabel";
            this.ProjectListLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ProjectListLabel.Size = new System.Drawing.Size(304, 37);
            this.ProjectListLabel.TabIndex = 3;
            this.ProjectListLabel.Text = "Список проектов";
            this.ProjectListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.BackgroundImage = global::DiaryWinFormsNetFramework.Properties.Resources.AddButtonWithSpaces;
            this.AddProjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddProjectBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddProjectBtn.FlatAppearance.BorderSize = 0;
            this.AddProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProjectBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectBtn.Location = new System.Drawing.Point(0, 0);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(37, 37);
            this.AddProjectBtn.TabIndex = 2;
            this.AddProjectBtn.UseVisualStyleBackColor = true;
            this.AddProjectBtn.Click += new System.EventHandler(this.AddProjectBtn_Click);
            // 
            // TaskPanel
            // 
            this.TaskPanel.AutoScroll = true;
            this.TaskPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskPanel.Location = new System.Drawing.Point(0, 42);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(706, 601);
            this.TaskPanel.TabIndex = 2;
            // 
            // TaskCommands
            // 
            this.TaskCommands.Controls.Add(this.ProjectNameLabel);
            this.TaskCommands.Controls.Add(this.AddTaskBtn);
            this.TaskCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskCommands.Location = new System.Drawing.Point(0, 0);
            this.TaskCommands.Name = "TaskCommands";
            this.TaskCommands.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.TaskCommands.Size = new System.Drawing.Size(706, 42);
            this.TaskCommands.TabIndex = 0;
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProjectNameLabel.Location = new System.Drawing.Point(37, 0);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ProjectNameLabel.Size = new System.Drawing.Size(371, 37);
            this.ProjectNameLabel.TabIndex = 4;
            this.ProjectNameLabel.Text = "Project name";
            this.ProjectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddTaskBtn.BackgroundImage")));
            this.AddTaskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddTaskBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddTaskBtn.FlatAppearance.BorderSize = 0;
            this.AddTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskBtn.Location = new System.Drawing.Point(0, 0);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(37, 37);
            this.AddTaskBtn.TabIndex = 1;
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTask_ButtonClick);
            // 
            // TaskForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1120, 690);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.BodyPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ProjectsPanel.ResumeLayout(false);
            this.ProjectsCommands.ResumeLayout(false);
            this.TaskCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel ProjectsPanel;
        private System.Windows.Forms.Panel ProjectsCommands;
        private System.Windows.Forms.Panel TaskCommands;
        private System.Windows.Forms.Label ProjectListLabel;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Button AddProjectBtn;
    }
}