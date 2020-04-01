namespace DiaryWinFormsNetFramework.UserControls
{
    partial class MainNavItem
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
            this.RadioButton = new System.Windows.Forms.RadioButton();
            this.NavItemPanel = new System.Windows.Forms.Panel();
            this.NavItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioButton
            // 
            this.RadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButton.AutoSize = true;
            this.RadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RadioButton.FlatAppearance.BorderSize = 2;
            this.RadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButton.Location = new System.Drawing.Point(0, 0);
            this.RadioButton.Name = "RadioButton";
            this.RadioButton.Size = new System.Drawing.Size(60, 60);
            this.RadioButton.TabIndex = 0;
            this.RadioButton.TabStop = true;
            this.RadioButton.UseVisualStyleBackColor = true;
            // 
            // NavItemPanel
            // 
            this.NavItemPanel.Controls.Add(this.RadioButton);
            this.NavItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavItemPanel.Location = new System.Drawing.Point(0, 0);
            this.NavItemPanel.Name = "NavItemPanel";
            this.NavItemPanel.Size = new System.Drawing.Size(60, 60);
            this.NavItemPanel.TabIndex = 1;
            // 
            // MainNavItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NavItemPanel);
            this.Name = "MainNavItem";
            this.Size = new System.Drawing.Size(60, 60);
            this.NavItemPanel.ResumeLayout(false);
            this.NavItemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioButton;
        private System.Windows.Forms.Panel NavItemPanel;
    }
}
