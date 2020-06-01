using DiaryClassLibStandart.Class;
using DiaryClassLibStandart.Helpers;
using DiaryWinFormsNetFramework.HelpersConstants;
using DiaryWinFormsNetFramework.Plugins.BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryWinFormsNetFramework.UserControls;

namespace DiaryWinFormsNetFramework.Plugins.TaskForm
{
    public partial class TaskForm : BaseFormParent
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            TaskItem task = new TaskItem(0);
            task.Dock = DockStyle.Top;
            task.TaskName = "New Task";
            
            task.SubTaskPanel.Dock = DockStyle.Top;
            task.SubTaskPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            task.SubTaskPanel.AutoSize = true;

            TaskPanel.Controls.Add(task.SubTaskPanel);
            TaskPanel.Controls.Add(task);

        }
    }
}
