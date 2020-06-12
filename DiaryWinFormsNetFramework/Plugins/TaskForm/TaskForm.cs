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
using DiaryClassLibStandart.Class.TaskClass;
using DiaryWinFormsNetFramework.UserControls;

namespace DiaryWinFormsNetFramework.Plugins.TaskForm
{
    public partial class TaskForm : BaseFormParent
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавить задачу в текущий проект
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Добавить проект
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            //Запрашиваем имя проекта.
            var result = HelperDialog.ShowInputBox("Введите название проекта?");
            if (result.Status == DialogResult.OK)
            {
                ProjectItem proj = new ProjectItem(result.Value);
                proj.Dock = DockStyle.Top;
                this.ProjectsPanel.Controls.Add(proj);
            }
            
        }
    }
}
