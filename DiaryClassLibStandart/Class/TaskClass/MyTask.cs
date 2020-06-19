using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DiaryClassLibStandart.Helpers;

namespace DiaryClassLibStandart.Class.TaskClass
{
    /// <summary>
    /// Class для списка задач.
    /// </summary>
    public class MyTask
    {
        public int Id { get; set; }
        private TaskStatus _status;
        public TaskStatus Status
        {
            get { return _status; }
            set
            {
                this._status = value;
            }
        }

        public DateTime CreateTime { get; set; }
        public string Name { get; set; }

        public bool HasChildren
        {
            get { return this.SubTasks.Count > 0; }
        }

        /// <summary>
        /// Раскрытый (то есть список подзадач развернут по умолчанию)
        /// </summary>
        private bool _revealed = true;
        public bool Revealed
        {
            get { return this._revealed; }
            set
            { this._revealed = value; }
        }

        public ObservableCollection<MyTask> SubTasks;

        //public List<MyTask> SubTasks { get; private set; }
        public int Level { get; set; }

        public MyTask(string name, int level) : this()
        {
            this.Name = name;
            this.Level = level;
        }

        public MyTask()
        {
            Init();
        }

        private void Init()
        {
            this.SubTasks = new ObservableCollection<MyTask>();
            this.Id = KeyGenerator.CreateIntegerKey(this);
            this.CreateTime = DateTime.Now;
            this.Status = TaskStatus.ToDo;
            //this.SubTasks = new List<MyTask>();
        }

        public string GetStatusString()
        {
            switch (this.Status)
            {
                case TaskStatus.ToDo: return "ToDo";
                case TaskStatus.Doing: return "Doing";
                case TaskStatus.Done: return "Done";
            }

            return "ToDo";
        }

        public void SetStatusByString(string statusString)
        {
            switch (statusString.Trim(' '))
            {
                case "ToDo": this.Status = TaskStatus.ToDo;
                    break;

                case "Doing": this.Status = TaskStatus.Doing;
                    break;

                case "Done": this.Status = TaskStatus.Done;
                    break;

                default: this.Status = TaskStatus.ToDo;
                    break;
            }
        }

    }

    public enum TaskStatus
    {
        ToDo,
        Doing,
        Done,
    }
}
