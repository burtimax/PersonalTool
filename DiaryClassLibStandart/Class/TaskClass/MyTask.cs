using System;
using System.Collections.Generic;
using System.Text;
using DiaryClassLibStandart.Helpers;

namespace DiaryClassLibStandart.Class.TaskClass
{
    /// <summary>
    /// Class для списка задач.
    /// </summary>
    public class MyTask
    {
        public int Id { get; private set; }
        public TaskStatus Status { get; set; }
        public DateTime CreateTime { get; private set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool HasChildren { get; set; }
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
            this.Id = KeyGenerator.CreateIntegerKey(this);
            this.CreateTime = DateTime.Now;
            this.Status = TaskStatus.ToDo;
            //this.SubTasks = new List<MyTask>();
        }
    }

    public enum TaskStatus
    {
        ToDo,
        Doing,
        Done,
    }
}
