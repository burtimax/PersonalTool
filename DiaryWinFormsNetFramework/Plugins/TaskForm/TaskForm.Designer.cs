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
            this.AddTask = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BodyPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
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
            this.ContentPanel.Controls.Add(this.TaskPanel);
            this.ContentPanel.Controls.Add(this.AddTask);
            this.ContentPanel.Controls.Add(this.button2);
            this.ContentPanel.Location = new System.Drawing.Point(28, 23);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1064, 643);
            this.ContentPanel.TabIndex = 4;
            // 
            // TaskPanel
            // 
            this.TaskPanel.AutoScroll = true;
            this.TaskPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TaskPanel.Location = new System.Drawing.Point(39, 56);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(984, 561);
            this.TaskPanel.TabIndex = 2;
            // 
            // AddTask
            // 
            this.AddTask.Location = new System.Drawing.Point(3, 3);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(131, 47);
            this.AddTask.TabIndex = 1;
            this.AddTask.Text = "Add Task";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel TaskPanel;
    }
}