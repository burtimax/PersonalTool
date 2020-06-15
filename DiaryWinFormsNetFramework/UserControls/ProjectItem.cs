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
using DiaryWinFormsNetFramework.HelpersConstants;

namespace DiaryWinFormsNetFramework.UserControls
{
    public partial class ProjectItem : UserControl
    {
        public MyProject Project { get; private set; }

        /// <summary>
        /// Скрытая задача (вершина дерева задач в проекте) Эта задача не будет отображаться в панели.
        /// </summary>
        public TaskItem MainProjectTaskItem;

        /// <summary>
        /// Хранит ссылку на текущую (выбранную задачу в проекте)
        /// </summary>
        public TaskItem SelectedTaskItem;

        //Делегат и событие изменения текущей задачи
        public delegate void ChangeSelectedTaskItem(TaskItem selectedTaskItem);
        public event ChangeSelectedTaskItem OnChangeSelectedTaskItem;

        //Отдельная панель задач для каждого проекта. Каждая сущность проекта будет иметь отдельную панель с задачами.
        public Panel TasksPanel;


        public ProjectItem(string name)
        {
            InitializeComponent();
            Init(name);
        }

        /// <summary>
        /// Initialize object
        /// </summary>
        /// <param name="name"></param>
        private void Init(string name)
        {
            InitTasksPanel();
            this.MainProjectTaskItem = new TaskItem(this, level: -1);
            this.MainProjectTaskItem.SubTaskPanel = this.TasksPanel;
            this.Project = new MyProject(name);
            this.NameTxt.Text = name;
        }

        /// <summary>
        /// Инициализируем панель для задач.
        /// </summary>
        private void InitTasksPanel()
        {
            this.TasksPanel = new Panel();
            this.TasksPanel.Dock = DockStyle.Fill;
        }


        

        /// <summary>
        /// Метод, который будет визуально видоизменять элемент проекта, показывая, что проект активен и выбран.
        /// </summary>
        public void VisualActivateProject()
        {
            this.NameTxt.BackColor = Constants.COLOR_DARK_GREY;
            this.NameTxt.ForeColor = Constants.COLOR_WHITE;
        }

        /// <summary>
        /// Метод, который будет визуально видоизменять элемент проекта, показывая, что проект не активен и выбран.
        /// Возвращаем элемент проекта в исходное, нормальное состояние
        /// </summary>
        public void VisualDeactivateProject()
        {
            this.NameTxt.BackColor = Constants.COLOR_WHITE;
            this.NameTxt.ForeColor = Constants.COLOR_BLACK;
        }


        /// <summary>
        /// Метод для вызова события из внешних классов.
        /// </summary>
        /// <param name="selectedTaskItem"></param>
        public void SelectedTaskItemWasChanged(TaskItem selectedTaskItem)
        {
            OnChangeSelectedTaskItem?.Invoke(selectedTaskItem);
        }

        

    }
}
