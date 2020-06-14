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
    public partial class ProjectItem : UserControl
    {
        public MyProject Project { get; private set; }

        /// <summary>
        /// Скрытая задача (вершина дерева задач в проекте) Эта задача не будет отображаться в панели.
        /// </summary>
        public TaskItem MainProjectTaskItem;

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
        /// Установить обработчик события нажатия на любой элемент текущего userControl
        /// </summary>
        /// <param name="handler"></param>
        public void SetOnClick(EventHandler handler)
        {
            this.ContentPanel.Click -= handler;
            this.ContentPanel.Click += handler;
            foreach (Control control in this.ContentPanel.Controls)
            {
                control.Click -= handler;
                control.Click += handler;
            }
        }

        /// <summary>
        /// Добавить задачу в проект безопасно.
        /// </summary>
        public void AddTaskItemSafe(TaskItem taskItem)
        {
            this.MainProjectTaskItem.SubTaskItems.Add(taskItem);
        }

    }
}
