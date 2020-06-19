namespace DiaryWinFormsNetFramework.UserControls
{
    partial class ProjectItem
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.LeftColorPanel = new System.Windows.Forms.Panel();
            this.BottomColorPanel = new System.Windows.Forms.Panel();
            this.NameTxt = new System.Windows.Forms.Label();
            this.ContextMenuProjectItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxtSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentPanel.SuspendLayout();
            this.ContextMenuProjectItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.Controls.Add(this.LeftColorPanel);
            this.ContentPanel.Controls.Add(this.BottomColorPanel);
            this.ContentPanel.Controls.Add(this.NameTxt);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ContentPanel.Location = new System.Drawing.Point(0, 5);
            this.ContentPanel.MinimumSize = new System.Drawing.Size(300, 80);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(300, 80);
            this.ContentPanel.TabIndex = 0;
            // 
            // LeftColorPanel
            // 
            this.LeftColorPanel.BackColor = System.Drawing.Color.DimGray;
            this.LeftColorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftColorPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftColorPanel.Name = "LeftColorPanel";
            this.LeftColorPanel.Size = new System.Drawing.Size(10, 77);
            this.LeftColorPanel.TabIndex = 0;
            // 
            // BottomColorPanel
            // 
            this.BottomColorPanel.BackColor = System.Drawing.Color.Gray;
            this.BottomColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomColorPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BottomColorPanel.Location = new System.Drawing.Point(0, 77);
            this.BottomColorPanel.Name = "BottomColorPanel";
            this.BottomColorPanel.Size = new System.Drawing.Size(300, 3);
            this.BottomColorPanel.TabIndex = 1;
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.White;
            this.NameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTxt.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.ForeColor = System.Drawing.Color.Black;
            this.NameTxt.Location = new System.Drawing.Point(0, 0);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Padding = new System.Windows.Forms.Padding(20, 0, 0, 3);
            this.NameTxt.Size = new System.Drawing.Size(300, 80);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.Text = "label1";
            this.NameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContextMenuProjectItem
            // 
            this.ContextMenuProjectItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuProjectItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxtSave,
            this.ctxtEdit,
            this.ctxtArchive,
            this.ctxtDelete});
            this.ContextMenuProjectItem.Name = "ContextMenuProjectItem";
            this.ContextMenuProjectItem.Size = new System.Drawing.Size(187, 100);
            // 
            // ctxtSave
            // 
            this.ctxtSave.Name = "ctxtSave";
            this.ctxtSave.Size = new System.Drawing.Size(186, 24);
            this.ctxtSave.Text = "Сохранить";
            this.ctxtSave.Click += new System.EventHandler(this.ctxtSave_Click);
            // 
            // ctxtEdit
            // 
            this.ctxtEdit.Name = "ctxtEdit";
            this.ctxtEdit.Size = new System.Drawing.Size(186, 24);
            this.ctxtEdit.Text = "Редактировать";
            this.ctxtEdit.Click += new System.EventHandler(this.ctxtEdit_Click);
            // 
            // ctxtArchive
            // 
            this.ctxtArchive.Name = "ctxtArchive";
            this.ctxtArchive.Size = new System.Drawing.Size(186, 24);
            this.ctxtArchive.Text = "Архивировать";
            this.ctxtArchive.Click += new System.EventHandler(this.ctxtArchive_Click);
            // 
            // ctxtDelete
            // 
            this.ctxtDelete.Name = "ctxtDelete";
            this.ctxtDelete.Size = new System.Drawing.Size(186, 24);
            this.ctxtDelete.Text = "Удалить проект";
            this.ctxtDelete.Click += new System.EventHandler(this.ctxtDelete_Click);
            // 
            // ProjectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.ContextMenuProjectItem;
            this.Controls.Add(this.ContentPanel);
            this.Name = "ProjectItem";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Size = new System.Drawing.Size(300, 85);
            this.ContentPanel.ResumeLayout(false);
            this.ContextMenuProjectItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label NameTxt;
        private System.Windows.Forms.Panel BottomColorPanel;
        private System.Windows.Forms.Panel LeftColorPanel;
        private System.Windows.Forms.ContextMenuStrip ContextMenuProjectItem;
        private System.Windows.Forms.ToolStripMenuItem ctxtEdit;
        private System.Windows.Forms.ToolStripMenuItem ctxtArchive;
        private System.Windows.Forms.ToolStripMenuItem ctxtDelete;
        private System.Windows.Forms.ToolStripMenuItem ctxtSave;
    }
}
