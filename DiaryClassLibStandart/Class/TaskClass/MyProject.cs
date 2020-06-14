﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Class.TaskClass
{
    /// <summary>
    /// Class, which represents project entity for task manager
    /// </summary>
    public class MyProject
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }

        private MyProject()
        {
            this.CreateTime = DateTime.Now;
        }

        public MyProject(string name):this()
        {
            this.Name = name;
        }
    }
}
