namespace DiaryWinFormsNetFramework.UserControls
{
    partial class TaskItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddSubtask = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddSubtask
            // 
            this.AddSubtask.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddSubtask.Location = new System.Drawing.Point(533, 0);
            this.AddSubtask.Name = "AddSubtask";
            this.AddSubtask.Size = new System.Drawing.Size(77, 35);
            this.AddSubtask.TabIndex = 1;
            this.AddSubtask.Text = "Add";
            this.AddSubtask.UseVisualStyleBackColor = true;
            this.AddSubtask.Click += new System.EventHandler(this.AddSubtask_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContentPanel.Controls.Add(this.AddSubtask);
            this.ContentPanel.Controls.Add(this.txtName);
            this.ContentPanel.Location = new System.Drawing.Point(3, 3);
            this.ContentPanel.MinimumSize = new System.Drawing.Size(100, 35);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(610, 35);
            this.ContentPanel.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(533, 30);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "label label label label label label label label label label ";
            // 
            // TaskItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ContentPanel);
            this.Name = "TaskItem";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(928, 40);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddSubtask;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label txtName;
    }
}
