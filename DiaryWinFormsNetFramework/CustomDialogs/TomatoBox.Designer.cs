namespace DiaryWinFormsNetFramework.CustomDialogs
{
    partial class TomatoBox
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
            this.SuspendLayout();
            // 
            // TomatoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TomatoBox";
            this.Text = "TomatoBox";
            this.Load += new System.EventHandler(this.TomatoBox_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TomatoBox_MouseDown);
            this.MouseLeave += new System.EventHandler(this.TomatoBox_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}