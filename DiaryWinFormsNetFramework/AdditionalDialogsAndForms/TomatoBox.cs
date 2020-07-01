using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryClassLibStandart.Class.TaskClass;
using DiaryClassLibStandart.Helpers;
using DiaryWinFormsNetFramework.HelpersConstants;
using DiaryWinFormsNetFramework.Properties;

namespace DiaryWinFormsNetFramework.CustomDialogs
{
    public partial class TomatoBox : Form
    {
        public static TomatoBox ActiveBox;

        private int hideWidth;
        private int hideHeight;
        private int showWidth;
        private int showHeight;
        private int centerLeft;


        public Pomodoro Pomodoro;
        
        public TomatoBox(string goalString)
        {
            InitializeComponent();
            Init(goalString);
        }


        private void TomatoBox_Load(object sender, EventArgs e)
        {

        }

        private void Init(string goalString)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;

            this.hideWidth = this.Width;
            this.showWidth = this.Width;
            this.showHeight = this.Height;
            this.hideHeight = 4;
            this.centerLeft = Convert.ToInt32(Math.Round(Screen.PrimaryScreen.Bounds.Width / 2.0 - this.Width / 2.0));
            this.MainPanel.MouseDown += MainPanelOnMouseDown;
            this.MouseDown += MainPanelOnMouseDown;
            this.GoalLabel.Text = goalString;
            SetBroadenSize();

            this.Pomodoro = new Pomodoro(goalString);
            this.Pomodoro.OnStateChange -= OnPomodoroStateChanged;
            this.Pomodoro.OnStateChange += OnPomodoroStateChanged;
            this.Pomodoro.OnTimeFinish -= OnPomodoroTimeFinish;
            this.Pomodoro.OnTimeFinish += OnPomodoroTimeFinish;

            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.TopLabel.Text = "PAUSE";

        }

        private void MainPanelOnMouseDown(object sender, MouseEventArgs e)
        {
            this.SetBroadenSize();
        }


        public static void ShowTomato(string goalString)
        {
            if(TomatoBox.ActiveBox != null)
            {
                HelperDialog.ShowWarningDialog($"Уже активна другая задача [{TomatoBox.ActiveBox?.Pomodoro?.Goal}]", "Запущена другая задача!");
                return;
            }

            TomatoBox box = new TomatoBox(goalString);


            //Button acceptBtn = new Button();
            
            //acceptBtn.Click += delegate(object sender, EventArgs args)
            //{
            //    box.CloseForm();
            //};

            //Button declineBtn = new Button();
            //declineBtn.Click += delegate(object sender, EventArgs args) { box.CloseForm(); };

            //box.AcceptButton = acceptBtn;
            //box.CancelButton = declineBtn;
            box.ShowInTaskbar = false;
            TomatoBox.ActiveBox = box;
            box.ShowDialog();
            //box.Show();

        }

        private void SetHidenSize()
        {
            if (this.Width == this.hideWidth && 
                this.Height == this.hideHeight &&
                this.Left == this.centerLeft) return;
            HelperForm.DeactivateControl(this.ContentPanel);
            this.Width = this.hideWidth;
            this.Height = this.hideHeight;
            this.Left = this.centerLeft;
            this.Top = -2;
        }

        private void SetBroadenSize()
        {
            if (this.Width == this.showWidth && 
                this.Height == this.showHeight &&
                this.Left == this.centerLeft) return;
            HelperForm.ActivateControl(this.ContentPanel);
            this.Width = this.showWidth;
            this.Height = this.showHeight;

            this.Left = this.centerLeft;
            this.Top = -2;
        }

        private void CloseForm()
        {
            TomatoBox.ActiveBox = null;
            this.Close();
            this.Dispose();
        }


        /// <summary>
        /// Edit task Name (Goal Name)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            var res = HelperDialog.ShowInputBox("Введите название задачи!", this.GoalLabel.Text);
            if (res.Status != DialogResult.OK || string.IsNullOrWhiteSpace(res.Value)) return;

            this.GoalLabel.Text = res.Value;
        }


        /// <summary>
        /// Start/Stop Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartStopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                checkBox.BackgroundImage = Resources.StopWhiteIcon;
                this.Pomodoro.Start();
            }
            else
            {
                checkBox.BackgroundImage = Resources.PlayWhiteIcon;
                this.Pomodoro.Stop();
                this.TopLabel.Text = "PAUSE";
            }
        }


        /// <summary>
        /// Restart Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.Pomodoro.Restart();
            this.StartStopCheckBox.Checked = false;
            this.TopLabel.Text = "PAUSE";
        }

        /// <summary>
        /// Forward Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            this.Pomodoro.ForwardToNextState();
            this.StartStopCheckBox.Checked = false;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Space)
            {
                this.SetHidenSize();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        /// <summary>
        /// Событие таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.TimeLabel.Text = this.Pomodoro.CountDownTimeString;
            this.Pomodoro.CountDown(this.Timer.Interval);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }


        private void OnPomodoroStateChanged(object sender, PomodoroState prevState, PomodoroState curState)
        {
            switch (curState)
            {
                case PomodoroState.RelaxStopping:
                    this.StartStopCheckBox.Checked = false;
                    SetFormColor(Color.FromArgb(31, 66, 135));
                    this.TopLabel.Text = "PAUSE";
                    break;
                case PomodoroState.Relaxing:
                    SetFormColor(Color.FromArgb(31,66,135));
                    this.TopLabel.Text = "RELAX";
                    break;
                case PomodoroState.WorkStopping:
                    this.StartStopCheckBox.Checked = false;
                    SetFormColor(Color.FromArgb(217, 83, 79));
                    this.TopLabel.Text = "PAUSE";
                    break;
                case PomodoroState.Working:
                    SetFormColor(Color.FromArgb(217, 83, 79));
                    this.TopLabel.Text = "FOCUS";
                    break;
            }
        }

        private void SetFormColor(Color color)
        {
            this.BackColor = color;
            this.MainPanel.BackColor = color;
        }

        private void OnPomodoroTimeFinish(object sender)
        {
            PlayClockAlarm();
        }

        private void PlayClockAlarm()
        {
            System.Media.SoundPlayer soundPlayer = new SoundPlayer(Resources.ClockAlarm);
            soundPlayer.Play();
        }
    }
}
