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
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.InnerButtonsPanel = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.GoalLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ForwardButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.StartStopCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.TopLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.InnerButtonsPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.MainPanel.Controls.Add(this.ContentPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(770, 212);
            this.MainPanel.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.ButtonsPanel);
            this.ContentPanel.Controls.Add(this.TimeLabel);
            this.ContentPanel.Controls.Add(this.GoalLabel);
            this.ContentPanel.Controls.Add(this.topPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(770, 212);
            this.ContentPanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.InnerButtonsPanel);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 153);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(770, 48);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // InnerButtonsPanel
            // 
            this.InnerButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InnerButtonsPanel.Controls.Add(this.ForwardButton);
            this.InnerButtonsPanel.Controls.Add(this.RestartButton);
            this.InnerButtonsPanel.Controls.Add(this.StartStopCheckBox);
            this.InnerButtonsPanel.Location = new System.Drawing.Point(295, 7);
            this.InnerButtonsPanel.Name = "InnerButtonsPanel";
            this.InnerButtonsPanel.Size = new System.Drawing.Size(174, 40);
            this.InnerButtonsPanel.TabIndex = 5;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeLabel.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(0, 90);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(770, 63);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "24:56";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GoalLabel
            // 
            this.GoalLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GoalLabel.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalLabel.ForeColor = System.Drawing.Color.White;
            this.GoalLabel.Location = new System.Drawing.Point(0, 33);
            this.GoalLabel.Name = "GoalLabel";
            this.GoalLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.GoalLabel.Size = new System.Drawing.Size(770, 57);
            this.GoalLabel.TabIndex = 2;
            this.GoalLabel.Text = "задача задача задача задача задача задача задача задача задача задача ";
            this.GoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.TopLabel);
            this.topPanel.Controls.Add(this.CloseButton);
            this.topPanel.Controls.Add(this.EditButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(770, 33);
            this.topPanel.TabIndex = 1;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImage = global::DiaryWinFormsNetFramework.Properties.Resources.ForwardWhiteIcon;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.Location = new System.Drawing.Point(134, 0);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(40, 40);
            this.ForwardButton.TabIndex = 5;
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RestartButton.BackgroundImage = global::DiaryWinFormsNetFramework.Properties.Resources.RestartWhiteIcon;
            this.RestartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RestartButton.FlatAppearance.BorderSize = 0;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Location = new System.Drawing.Point(67, 0);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(42, 40);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // StartStopCheckBox
            // 
            this.StartStopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.StartStopCheckBox.BackgroundImage = global::DiaryWinFormsNetFramework.Properties.Resources.PlayWhiteIcon;
            this.StartStopCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartStopCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartStopCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartStopCheckBox.FlatAppearance.BorderSize = 0;
            this.StartStopCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStopCheckBox.Location = new System.Drawing.Point(0, 0);
            this.StartStopCheckBox.Name = "StartStopCheckBox";
            this.StartStopCheckBox.Size = new System.Drawing.Size(40, 40);
            this.StartStopCheckBox.TabIndex = 4;
            this.StartStopCheckBox.UseVisualStyleBackColor = true;
            this.StartStopCheckBox.CheckedChanged += new System.EventHandler(this.StartStopCheckBox_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::DiaryWinFormsNetFramework.Properties.Resources.closeWhiteIcon1;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(737, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 33);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackgroundImage = global::DiaryWinFormsNetFramework.Properties.Resources.editWhiteIcon;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(0, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(33, 33);
            this.EditButton.TabIndex = 1;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // TopLabel
            // 
            this.TopLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabel.ForeColor = System.Drawing.Color.White;
            this.TopLabel.Location = new System.Drawing.Point(33, 0);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(704, 33);
            this.TopLabel.TabIndex = 3;
            this.TopLabel.Text = "FOCUS";
            this.TopLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TomatoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(770, 212);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TomatoBox";
            this.Text = "TomatoBox";
            this.Load += new System.EventHandler(this.TomatoBox_Load);
            this.MainPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.InnerButtonsPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label GoalLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel InnerButtonsPanel;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.CheckBox StartStopCheckBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TopLabel;
    }
}