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
        private ProjectItem SelectedProjectItem;



        public TaskForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавить задачу в текущий проект
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTask_ButtonClick(object sender, EventArgs e)
        {
            CreateAndAddTaskToProject(this.SelectedProjectItem);
        }


        /// <summary>
        /// Добавить проект
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            CreateAndAddProjectItem(this.ProjectsPanel);
        }

        /// <summary>
        /// Добавить элемент проекта в панель.
        /// </summary>
        /// <param name="parent"></param>
        private void CreateAndAddProjectItem(Control parent)
        {
            //Запрашиваем имя проекта.
            var result = HelperDialog.ShowInputBox("Введите название проекта?");
            if (result.Status == DialogResult.OK)
            {
                ProjectItem proj = new ProjectItem(result.Value);
                proj.Dock = DockStyle.Top;
                
                //привязываем событие нажатия мыши на элемент проекта
                proj.SetOnClick(ProjectItem_Click);

                //Привязываем элемент проекта к родителю
                parent.Controls.Add(proj);
                parent.Controls.SetChildIndex(proj, 0);
                //Добавляем для проекта его личную панель для задач.
                this.TaskPanel.Controls.Add(proj.TasksPanel);
                //Только что созданный проект и будет текущим проектом.
                ChangeSelectedProjectItem(proj);
            }
        }

        /// <summary>
        /// Вызывается при нажатии на элемент проекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectItem_Click(object sender, EventArgs e)
        {
            if (sender == null || sender is Control == false) return;

            Control control = sender as Control;
            ProjectItem proj = HelperControls.GetParenByType<ProjectItem>(control);
            if (proj == default(ProjectItem)) return;

            //Так как мы выбрали Новый ProjectItem, то нужно поменять цвет выделения.
            if(proj != this.SelectedProjectItem)
            {
                ChangeSelectedProjectItem(proj);
            }
        }

        /// <summary>
        /// Пользователь выбрал другой проект, нужно выделить визуально выбранный проект.
        /// </summary>
        /// <param name="proj"></param>
        private void ChangeSelectedProjectItem(ProjectItem proj)
        {
            MessageBox.Show(proj.GetHashCode().ToString());

            if(SelectedProjectItem != null)
            {
                HelperForm.DeactivateControl(this.SelectedProjectItem.TasksPanel);
            }
            
            HelperForm.ActivateControl(proj.TasksPanel);
            this.SelectedProjectItem = proj;
        }

        /// <summary>
        /// Добавить задачу в проект
        /// </summary>
        /// <param name="project"></param>
        private void CreateAndAddTaskToProject(ProjectItem projItem)
        {
            TaskItem newTaskItem = CreateNewTaskItem();

            if (newTaskItem == null) return;
            if (projItem == null) return;

            projItem.AddTaskItemSafe(newTaskItem);
        }


        /// <summary>
        /// Создаем графический элемент задачи
        /// </summary>
        private TaskItem CreateNewTaskItem()
        {
            if (this.SelectedProjectItem == null)
            {
                HelperDialog.ShowWarningDialog("Задачу можно создать только для проекта.\nCоздайте или выберете проект!", "Не выбран проект для задачи");
                return null;
            }

            var result = HelperDialog.ShowInputBox("Введите название задачи");
            //Если inputbox был отменен или пользователь ввел пустую строку, то выходим
            if (result.Status != DialogResult.OK ||
                result.Status == DialogResult.OK && string.IsNullOrWhiteSpace(result.Value)) return null;

            //Создаем графический элемент задачи
            TaskItem task = new TaskItem(this.SelectedProjectItem, this.SelectedProjectItem.MainProjectTaskItem, 0);
            task.Dock = DockStyle.Top;
            task.TaskName = result.Value;

            task.SubTaskPanel.Dock = DockStyle.Top;
            task.SubTaskPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            task.SubTaskPanel.AutoSize = true;

            this.SelectedProjectItem.TasksPanel.Controls.Add(task.SubTaskPanel);
            this.SelectedProjectItem.TasksPanel.Controls.Add(task);
            this.SelectedProjectItem.TasksPanel.Controls.SetChildIndex(task, 0);
            this.SelectedProjectItem.TasksPanel.Controls.SetChildIndex(task.SubTaskPanel, 0);

            return task;
        }

        /// <summary>
        /// TaskForm Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
