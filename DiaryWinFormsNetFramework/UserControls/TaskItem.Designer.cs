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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskItem));
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.DeleteTask = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.StatusCheckBox = new System.Windows.Forms.CheckBox();
            this.AddSubtask = new System.Windows.Forms.Button();
            this.OpenCloseArrow = new System.Windows.Forms.CheckBox();
            this.BottomColorPanel = new System.Windows.Forms.Panel();
            this.ContextMenuTaskItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxtStartTomato = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentPanel.SuspendLayout();
            this.ContextMenuTaskItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContentPanel.BackColor = System.Drawing.Color.White;
            this.ContentPanel.Controls.Add(this.DeleteTask);
            this.ContentPanel.Controls.Add(this.txtName);
            this.ContentPanel.Controls.Add(this.StatusCheckBox);
            this.ContentPanel.Controls.Add(this.AddSubtask);
            this.ContentPanel.Controls.Add(this.BottomColorPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentPanel.Location = new System.Drawing.Point(33, 3);
            this.ContentPanel.MinimumSize = new System.Drawing.Size(100, 35);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(264, 35);
            this.ContentPanel.TabIndex = 2;
            // 
            // DeleteTask
            // 
            this.DeleteTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteTask.BackColor = System.Drawing.Color.Transparent;
            this.DeleteTask.BackgroundImage = global::DiaryWinFormsNetFramework.Properties.Resources.iconDeleteBig;
            this.DeleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteTask.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteTask.FlatAppearance.BorderSize = 0;
            this.DeleteTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTask.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteTask.Location = new System.Drawing.Point(229, 0);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(35, 34);
            this.DeleteTask.TabIndex = 6;
            this.DeleteTask.UseVisualStyleBackColor = false;
            this.DeleteTask.Click += new System.EventHandler(this.DeleteTask_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(70, 0);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.txtName.Size = new System.Drawing.Size(153, 32);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "name";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusCheckBox
            // 
            this.StatusCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.StatusCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StatusCheckBox.BackgroundImage")));
            this.StatusCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StatusCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusCheckBox.FlatAppearance.BorderSize = 0;
            this.StatusCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusCheckBox.Location = new System.Drawing.Point(35, 0);
            this.StatusCheckBox.Name = "StatusCheckBox";
            this.StatusCheckBox.Size = new System.Drawing.Size(36, 34);
            this.StatusCheckBox.TabIndex = 4;
            this.StatusCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StatusCheckBox.UseVisualStyleBackColor = false;
            this.StatusCheckBox.CheckedChanged += new System.EventHandler(this.StatusCheckBox_CheckedChanged);
            // 
            // AddSubtask
            // 
            this.AddSubtask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddSubtask.BackColor = System.Drawing.Color.Transparent;
            this.AddSubtask.BackgroundImage = global::DiaryWinFormsNetFramework.Properties.Resources.AddButtonWithSpaces;
            this.AddSubtask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddSubtask.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddSubtask.FlatAppearance.BorderSize = 0;
            this.AddSubtask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddSubtask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddSubtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSubtask.ForeColor = System.Drawing.Color.Transparent;
            this.AddSubtask.Location = new System.Drawing.Point(0, 0);
            this.AddSubtask.Name = "AddSubtask";
            this.AddSubtask.Size = new System.Drawing.Size(35, 34);
            this.AddSubtask.TabIndex = 1;
            this.AddSubtask.UseVisualStyleBackColor = false;
            this.AddSubtask.Click += new System.EventHandler(this.AddSubTask_Click);
            // 
            // OpenCloseArrow
            // 
            this.OpenCloseArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.OpenCloseArrow.BackColor = System.Drawing.Color.Transparent;
            this.OpenCloseArrow.BackgroundImage = global::DiaryWinFormsNetFramework.Properties.Resources.downArrow;
            this.OpenCloseArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenCloseArrow.Checked = true;
            this.OpenCloseArrow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenCloseArrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenCloseArrow.FlatAppearance.BorderSize = 0;
            this.OpenCloseArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.OpenCloseArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCloseArrow.Location = new System.Drawing.Point(3, 3);
            this.OpenCloseArrow.Name = "OpenCloseArrow";
            this.OpenCloseArrow.Size = new System.Drawing.Size(30, 35);
            this.OpenCloseArrow.TabIndex = 5;
            this.OpenCloseArrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenCloseArrow.UseVisualStyleBackColor = false;
            this.OpenCloseArrow.CheckedChanged += new System.EventHandler(this.OpenCloseArrow_CheckedChanged);
            // 
            // BottomColorPanel
            // 
            this.BottomColorPanel.BackColor = System.Drawing.Color.LightGray;
            this.BottomColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomColorPanel.Location = new System.Drawing.Point(0, 34);
            this.BottomColorPanel.Name = "BottomColorPanel";
            this.BottomColorPanel.Size = new System.Drawing.Size(264, 1);
            this.BottomColorPanel.TabIndex = 3;
            // 
            // ContextMenuTaskItem
            // 
            this.ContextMenuTaskItem.DropShadowEnabled = false;
            this.ContextMenuTaskItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuTaskItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxtStartTomato});
            this.ContextMenuTaskItem.Name = "ContextMenuTaskItem";
            this.ContextMenuTaskItem.Size = new System.Drawing.Size(169, 28);
            // 
            // ctxtStartTomato
            // 
            this.ctxtStartTomato.BackColor = System.Drawing.Color.DarkRed;
            this.ctxtStartTomato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctxtStartTomato.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtStartTomato.ForeColor = System.Drawing.Color.White;
            this.ctxtStartTomato.Name = "ctxtStartTomato";
            this.ctxtStartTomato.Size = new System.Drawing.Size(168, 24);
            this.ctxtStartTomato.Text = "Помидорка";
            this.ctxtStartTomato.Click += new System.EventHandler(this.ctxtStartTomato_Click);
            // 
            // TaskItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.ContextMenuTaskItem;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.OpenCloseArrow);
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "TaskItem";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(300, 41);
            this.ContentPanel.ResumeLayout(false);
            this.ContextMenuTaskItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddSubtask;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.CheckBox StatusCheckBox;
        private System.Windows.Forms.Panel BottomColorPanel;
        private System.Windows.Forms.CheckBox OpenCloseArrow;
        private System.Windows.Forms.Button DeleteTask;
        private System.Windows.Forms.ContextMenuStrip ContextMenuTaskItem;
        private System.Windows.Forms.ToolStripMenuItem ctxtStartTomato;
    }
}
