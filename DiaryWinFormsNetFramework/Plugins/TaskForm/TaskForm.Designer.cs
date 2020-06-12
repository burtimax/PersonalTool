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
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProjectsPanel = new System.Windows.Forms.Panel();
            this.ProjectsCommands = new System.Windows.Forms.Panel();
            this.TaskCommands = new System.Windows.Forms.Panel();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.BodyPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.TaskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ProjectsPanel.SuspendLayout();
            this.ProjectsCommands.SuspendLayout();
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
            this.ContentPanel.Controls.Add(this.splitContainer1);
            this.ContentPanel.Location = new System.Drawing.Point(28, 23);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1064, 643);
            this.ContentPanel.TabIndex = 4;
            // 
            // TaskPanel
            // 
            this.TaskPanel.AutoScroll = true;
            this.TaskPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TaskPanel.Controls.Add(this.TaskCommands);
            this.TaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(706, 643);
            this.TaskPanel.TabIndex = 2;
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Location = new System.Drawing.Point(220, 3);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(131, 47);
            this.AddTaskBtn.TabIndex = 1;
            this.AddTaskBtn.Text = "Add Task";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTask_Click);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TaskPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 643);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 0;
            // 
            // ProjectsPanel
            // 
            this.ProjectsPanel.Controls.Add(this.ProjectsCommands);
            this.ProjectsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsPanel.Location = new System.Drawing.Point(0, 0);
            this.ProjectsPanel.Name = "ProjectsPanel";
            this.ProjectsPanel.Size = new System.Drawing.Size(354, 643);
            this.ProjectsPanel.TabIndex = 2;
            // 
            // ProjectsCommands
            // 
            this.ProjectsCommands.Controls.Add(this.AddProjectBtn);
            this.ProjectsCommands.Controls.Add(this.AddTaskBtn);
            this.ProjectsCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectsCommands.Location = new System.Drawing.Point(0, 0);
            this.ProjectsCommands.Name = "ProjectsCommands";
            this.ProjectsCommands.Size = new System.Drawing.Size(354, 55);
            this.ProjectsCommands.TabIndex = 2;
            // 
            // TaskCommands
            // 
            this.TaskCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskCommands.Location = new System.Drawing.Point(0, 0);
            this.TaskCommands.Name = "TaskCommands";
            this.TaskCommands.Size = new System.Drawing.Size(706, 55);
            this.TaskCommands.TabIndex = 0;
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.Location = new System.Drawing.Point(3, 5);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(88, 47);
            this.AddProjectBtn.TabIndex = 2;
            this.AddProjectBtn.Text = "Add project";
            this.AddProjectBtn.UseVisualStyleBackColor = true;
            this.AddProjectBtn.Click += new System.EventHandler(this.AddProjectBtn_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1120, 690);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "SettingsForm";
            this.BodyPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.TaskPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ProjectsPanel.ResumeLayout(false);
            this.ProjectsCommands.ResumeLayout(false);
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
        private System.Windows.Forms.Button AddProjectBtn;
    }
}