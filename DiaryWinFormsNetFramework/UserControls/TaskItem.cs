using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryClassLibStandart.Class.TaskClass;

namespace DiaryWinFormsNetFramework.UserControls
{
    public partial class TaskItem : UserControl
    {
        public TaskItem()
        {
            InitializeComponent();
            Init();
        }

        public TaskItem(int level)
        {
            InitializeComponent();
            Init(level);
        }

        private MyTask Task { get; set; }
        public List<TaskItem> SubTaskItems { get; set; }
        private Panel _subPanel;
        public Panel SubTaskPanel { 
            get { return _subPanel; }
            set { _subPanel = value; }
        }

        public string TaskName
        {
            get
            {
                string val;
                if (txtName == null)
                {
                    this.Task.Name = null;
                    val = null;
                    return val;
                }

                if (txtName.Text != this.Task.Name)
                {
                    this.Task.Name = txtName.Text;
                }

                val = txtName.Text;

                return val;
            }
            set
            {
                this.txtName.Text = value;
                this.Task.Name = value;
            }
        }


        private void Init(int taskLevel = 0)
        {
            this.Task = new MyTask("", taskLevel);
            InitPanel();
            this.SubTaskItems = new List<TaskItem>();
        }

        private void InitPanel()
        {
            this._subPanel = new Panel();
            this._subPanel.Dock = DockStyle.Top;
            this._subPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this._subPanel.AutoSize = true;
            if (this.Task.Level+1 > 0)
            {
                this._subPanel.Padding = new Padding(20,
                    this._subPanel.Padding.Top,
                    this._subPanel.Padding.Right,
                    this._subPanel.Padding.Bottom);
            }
        }

        private void AddSubtask_Click(object sender, EventArgs e)
        {
            var subTask = new TaskItem(this.Task.Level + 1)
            {
                TaskName = "SubTask"+this.SubTaskItems.Count,
                Dock = DockStyle.Top
            };

            this.SubTaskPanel.Controls.Add(subTask.SubTaskPanel);
            this.SubTaskPanel.Controls.Add(subTask);
            this.SubTaskPanel.Controls.SetChildIndex(subTask.SubTaskPanel, 0);
            this.SubTaskPanel.Controls.SetChildIndex(subTask,1);
            this.SubTaskItems.Add(subTask);
        }

       
    }
}
