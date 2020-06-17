using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryClassLibStandart.Class.TaskClass;
using DiaryClassLibStandart.Helpers;
using DiaryWinFormsNetFramework.HelpersConstants;

namespace DiaryWinFormsNetFramework.UserControls
{
    public partial class ProjectItem : UserControl
    {
        public MyProject Project { get; private set; }

        /// <summary>
        /// Скрытая задача (вершина дерева задач в проекте) Эта задача не будет отображаться в панели.
        /// </summary>
        public TaskItem MainProjectTaskRoot;

        /// <summary>
        /// Хранит ссылку на текущую (выбранную задачу в проекте)
        /// </summary>
        public TaskItem SelectedTaskItem;

        //Делегат и событие изменения текущей задачи
        public delegate void ChangeSelectedTaskItem(TaskItem selectedTaskItem);
        public event ChangeSelectedTaskItem OnChangeSelectedTaskItem;

        //Отдельная панель задач для каждого проекта. Каждая сущность проекта будет иметь отдельную панель с задачами.
        public Panel TasksPanel;

        public ProjectItem(MyProject proj)
        {
            InitializeComponent();
            Init(proj.Name);
        }

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
            this.MainProjectTaskRoot = new TaskItem(this, level: -1);
            this.MainProjectTaskRoot.SubTaskPanel = this.TasksPanel;

            this.Project = new MyProject(name);
            this.Project.TaskRoot = this.MainProjectTaskRoot.Task;

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

        /// <summary>
        /// Редактировать данные проекта 
        /// </summary>
        public void EditProjectData()
        {
            var res = HelperDialog.ShowInputBox($"Изменить имя проекта ({this.Project.Name})");

            if (res.Status != DialogResult.OK || string.IsNullOrWhiteSpace(res.Value)) return;

            if (SetName(res.Value) == false)
            {
                HelperDialog.ShowWarningDialog("Невозможно переименовать файл проекта", "Имя проекта содержит недопустимые символы!");
                return;
            }
        }

        /// <summary>
        /// Поменять название проекта
        /// </summary>
        /// <param name="newName"></param>
        private bool SetName(string newName)
        {
            //Поменять имя файла проекта
            if (RenameProjectFile(newName) == false)
            {
                return false;
            }

            //Поменять имя MyProject
            this.Project.Name = newName;
            this.NameTxt.Text = newName;
            return true;
        }

        /// <summary>
        /// Переименовать файл проекта
        /// </summary>
        /// <returns>Если удачно переименовали, то возвращаем true, else false</returns>
        private bool RenameProjectFile(string newFileName)
        {
            if (File.Exists(this.Project.ProjectFilePath) == false) return true;

            //Поменять имя файла проекта
            HelperFileName.ParsePath(this.Project.ProjectFilePath,
                out var dir,
                out var fname,
                out var ext);
            string newPath = dir + "\\" + newFileName + ext;

            try
            {
                File.Move(this.Project.ProjectFilePath,
                    newPath);
            }
            catch
            {
                //Поймали ошибку, не смогли переименовать файл, возвращаем false
                return false;
            }

            return true;
        }

    }
}
