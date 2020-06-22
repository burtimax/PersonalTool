using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DiaryClassLibStandart.Class.TaskClass
{
    public class Pomodoro
    {
        /// <summary>
        /// Time For Work in Milliseconds
        /// </summary>
        public int TimeForWork { get { return _timeForWork; } }
        public int _timeForWork = 25 * 60 * 1000;

        /// <summary>
        /// Time for relax in milliseconds
        /// </summary>
        public int TimeForRelax { get { return _timeForRelax; } }
        public int _timeForRelax = 5 * 60 * 1000; //milliseconds


        public delegate void PomodoroStateChange(object sender, PomodoroState prevState, PomodoroState curState);
        public event PomodoroStateChange OnStateChange;

        public delegate void PomodoroTimeFinish(object sender);
        public event PomodoroTimeFinish OnTimeFinish;
        
        private PomodoroState _pomodoroState;
        /// <summary>
        /// Статус помодоро
        /// </summary>
        public PomodoroState State
        {
            get { return _pomodoroState; }
            set
            {
                var prevState = _pomodoroState;
                this._pomodoroState = value;
                this.OnStateChange?.Invoke(this, prevState, value);
            }
        }

        /// <summary>
        /// Current countdown Time in milliseconds 
        /// </summary>
        public int CountdownTime;

        public string Goal = null;

        public int CurrentCircle = 1;

        public Pomodoro()
        {
            this._pomodoroState = PomodoroState.ShutDown;
            this.CountdownTime = _timeForWork;
            this.OnStateChange -= OnPomodoroStateChange;
            this.OnStateChange += OnPomodoroStateChange;
            this.Goal = "ЗАДАЧА";
        }

        public Pomodoro(string goalString) : this()
        {
            this.Goal = goalString;
        }

        public Pomodoro(int timeForWork, int timeForRelax) : this()
        {
            this._timeForWork = timeForWork;
            this._timeForRelax = timeForRelax;
        }

        public Pomodoro(string goalString, int timeForWork, int timeForRelax) : this(timeForWork, timeForRelax)
        {
            this.Goal = goalString;
        }

        /// <summary>
        /// Запустить помодоро
        /// </summary>
        public void Start()
        {
            switch (this.State)
            {
                case PomodoroState.ShutDown:
                    this.CountdownTime = this.TimeForWork;
                    this.State = PomodoroState.Working;
                    break;
                case PomodoroState.RelaxStopping:
                    this.State = PomodoroState.Relaxing;
                    break;
                case PomodoroState.WorkStopping:
                    this.State = PomodoroState.Working;
                    break;
            }
        }

        /// <summary>
        /// Остановить помодоро
        /// </summary>
        public void Stop()
        {
            switch (this.State)
            {
                case PomodoroState.Working:
                    this.State = PomodoroState.WorkStopping;
                    break;
                case PomodoroState.Relaxing:
                    this.State = PomodoroState.RelaxStopping;
                    break;
            }
        }

        /// <summary>
        /// Уменьшить время (счетчик)
        /// </summary>
        /// <param name="milliseconds"></param>
        public void CountDown(int milliseconds = 1000)
        {
            //Усеньшить счетчик
            if (this.State == PomodoroState.Working ||
                this.State == PomodoroState.Relaxing)
            {
                this.CountdownTime -= milliseconds;
            }
            else
            {
                //Если статус другой, то не можем трогать счетчик
                return;
            }

            //Если счетчик <=0, то поменять статус и обновить счетчик.
            if (this.CountdownTime < 0)
            {
                OnTimeFinish?.Invoke(this);
                switch (this.State)
                {
                    case PomodoroState.Relaxing:
                        this.State = PomodoroState.WorkStopping;
                        this.CountdownTime = _timeForWork;
                        break;
                    case PomodoroState.Working:
                        this.State = PomodoroState.RelaxStopping;
                        this.CountdownTime = _timeForRelax;
                        break;
                }
                
            }
        }

        /// <summary>
        /// Внутренний обработчик события изменения статуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="prevstate"></param>
        /// <param name="curstate"></param>
        private void OnPomodoroStateChange(object sender, PomodoroState prevstate, PomodoroState curstate)
        {
            //Устанавливаем время счетчику при изменениях состояний

            if (prevstate != PomodoroState.RelaxStopping && curstate == PomodoroState.Relaxing)
            {
                this.CountdownTime = this._timeForRelax;
            }

            if (prevstate != PomodoroState.WorkStopping && curstate == PomodoroState.Working)
            {
                this.CountdownTime = this._timeForWork;
            }
        }


        public string CountDownTimeString
        {
            get
            {
                int mins = this.CountdownTime / 1000 / 60;
                int secs = this.CountdownTime % (1000 * 60) / 1000;
                string res = (mins / 10).ToString() + (mins % 10).ToString() + ":" + (secs / 10).ToString() +
                             (secs % 10).ToString();
                return res;
            }
        }

        public void Restart()
        {
            switch (State)
            {
                case PomodoroState.RelaxStopping:
                case PomodoroState.Relaxing:
                    this.CountdownTime = _timeForRelax;
                    this.State = PomodoroState.RelaxStopping;
                    break;
                case PomodoroState.WorkStopping:
                case PomodoroState.Working:
                    this.CountdownTime = _timeForWork;
                    this.State = PomodoroState.WorkStopping;
                    break;
                case PomodoroState.ShutDown:
                    
                    break;
            }
        }


        public void ForwardToNextState()
        {
            switch (State)
            {
                case PomodoroState.Relaxing:
                case PomodoroState.RelaxStopping:
                    this.State = PomodoroState.WorkStopping;
                    this.Restart();
                    break;
                case PomodoroState.Working:
                case PomodoroState.WorkStopping:
                    this.State = PomodoroState.RelaxStopping;
                    this.Restart();
                    break;
            }
        }


    }

    public enum PomodoroState
    {
        Working,
        WorkStopping,
        Relaxing,
        RelaxStopping,
        ShutDown
    }
}
