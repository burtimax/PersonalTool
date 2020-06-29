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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryClassLibStandart.Class.TaskClass;
using DiaryWinFormsNetFramework.HelpersConstants.Enums;
using DiaryWinFormsNetFramework.UserControls;
using TaskStatus = DiaryClassLibStandart.Class.TaskClass.TaskStatus;

namespace DiaryWinFormsNetFramework.Plugins.TaskForm
{
    public partial class TaskForm : BaseFormParent
    {
        private ProjectItem _selecteProjectItem = null;
        private ProjectItem SelectedProjectItem
        {
            get
            {
                if(this._selecteProjectItem?.Parent != null)
                {
                    return this._selecteProjectItem;
                }

                return null;
            }
            set { this._selecteProjectItem = value; }
        }

        private string ProjectsDirectory
        {
            get { return Settings.GetSetting(Settings.ProjectsDirectory); }
        }


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
        private void CreateAndAddProjectItem(Control parent, bool askNeme = true)
        {
            ProjectItem proj = new ProjectItem("___");

            bool approveName = false;
            while(!approveName)
            {
                //Запрашиваем имя проекта.
                var result = HelperDialog.ShowInputBox("Введите название нового проекта?");
                if (result.Status != DialogResult.OK || string.IsNullOrWhiteSpace(result?.Value))
                {
                    return;
                }

                if (proj.SetName(result.Value) == false)
                {
                    HelperDialog.ShowWarningDialog("Попробуйте ввести название снова!",
                        "Имя проекта содержит недопустимые символы!");
                    continue;
                }

                approveName = true;
            }

            //Добавим проект в панель
            AddProjectItemToParentPanel(parent, proj);
        }

        /// <summary>
        /// Добавить проект в родительскую панель
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="proj"></param>
        private void AddProjectItemToParentPanel(Control parent, ProjectItem proj)
        {
            this.TaskPanel.Controls.Add(proj.MainProjectTaskRoot.SubTaskPanel);

            proj.Dock = DockStyle.Top;

            //привязываем событие нажатия мыши на элемент проекта
            HelperControls.SetOnClickHandlerForAllElementsInControl(proj, ProjectItem_Click);
            HelperControls.SetOnDoubleClickHandlerForAllElementsInControl(proj, ProjectItem_DoubleClick);

            //Привязываем элемент проекта к родителю
            parent.Controls.Add(proj);
            parent.Controls.SetChildIndex(proj, 0);
            //Добавляем для проекта его личную панель для задач.
            this.TaskPanel.Controls.Add(proj.TasksPanel);
            //Только что созданный проект и будет текущим проектом.
            ChangeSelectedProjectItem(proj, false);

            //Добавим обработчик события изменения текущей(выбранной) задачи
            proj.OnChangeSelectedTaskItem -= ChangeSelectedTaskItem;
            proj.OnChangeSelectedTaskItem += ChangeSelectedTaskItem;

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
            ChangeSelectedProjectItem(proj);
            
        }

        /// <summary>
        /// Обработчик двойного нажатия мыши на элемент проекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectItem_DoubleClick(object sender, EventArgs e)
        {
            if (sender == null || sender is Control == false) return;

            ProjectItem proj = HelperControls.GetParenByType<ProjectItem>(sender as Control);
            //ПО ДВОЙНОМУ КЛИКУ БУДЕМ РЕДАКТИРОВАТЬ ЭЛЕМЕНТ ПРОЕКТА
            proj.EditProjectData();
            //данные по проекту изменились, как-будто мы поменяли элемент
            this.ChangeSelectedProjectItem(proj);
        }

        /// <summary>
        /// Вызывается при нажатии на элемент задачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TaskItem_OnClick(object sender, EventArgs args)
        {
            var taskItem = HelperControls.GetParenByType<TaskItem>(sender as Control);

            if (taskItem == null) return;

            ChangeSelectedTaskItem(taskItem);
        }

        /// <summary>
        /// Пользователь выбрал другой проект, нужно выделить визуально выбранный проект.
        /// </summary>
        /// <param name="proj"></param>
        private void ChangeSelectedProjectItem(ProjectItem proj, bool loadDataForSelectedProject = true)
        {
            if(Equals(this.SelectedProjectItem, proj) == false)
            {
                if (SelectedProjectItem != null)
                {
                    HelperForm.DeactivateControl(this.SelectedProjectItem.TasksPanel);
                }

                ProjectItem prevSelectedProjectItem = this.SelectedProjectItem;

                HelperForm.ActivateControl(proj.TasksPanel);
                this.SelectedProjectItem = proj;

                //Убрать выделение у предыдущего активного проекта.
                prevSelectedProjectItem?.VisualDeactivateProject();

                //Визуально выделить активный проект.
                this.SelectedProjectItem?.VisualActivateProject();
            }

            //Нужно поменять текст в поле ProjectNameLabel
            this.ProjectNameLabel.Text = this.SelectedProjectItem.Project.Name;

            //Если проект не имеет задач, вероятно нужно загрузить задачи
            if (loadDataForSelectedProject && this.SelectedProjectItem.MainProjectTaskRoot.SubTaskItems.Count == 0)
            {
                if (this._selecteProjectItem != null)
                {
                    this.LoadProjectDataFromFile(ref this._selecteProjectItem);
                }
            }
        }

        /// <summary>
        /// поменять выбранную задачу, обработчик события OnChangeSelectedTaskItem у проекта
        /// </summary>
        /// <param name="selectedTaskItem"></param>
        private void ChangeSelectedTaskItem(TaskItem selectedTaskItem)
        {
            if (selectedTaskItem == null) return;

            var prevTaskItem = this.SelectedProjectItem.SelectedTaskItem;
            this.SelectedProjectItem.SelectedTaskItem = selectedTaskItem;

            prevTaskItem?.VisuaLDeactivate();

            this.SelectedProjectItem.SelectedTaskItem.VisualActivate();
        }

        /// <summary>
        /// Добавить задачу в проект
        /// </summary>
        /// <param name="project"></param>
        private void CreateAndAddTaskToProject(ProjectItem projItem)
        {
            if (projItem == null) return;
            projItem.MainProjectTaskRoot.CreateAndAddSubTask();
        }


        ///// <summary>
        ///// Создаем графический элемент задачи
        ///// </summary>
        //private TaskItem CreateNewTaskItem()
        //{
        //    if (this.SelectedProjectItem == null)
        //    {
        //        HelperDialog.ShowWarningDialog("Задачу можно создать только для проекта.\nCоздайте или выберете проект!", "Не выбран проект для задачи");
        //        return null;
        //    }

        //    var result = HelperDialog.ShowInputBox("Введите название задачи");
        //    //Если inputbox был отменен или пользователь ввел пустую строку, то выходим
        //    if (result.Status != DialogResult.OK ||
        //        result.Status == DialogResult.OK && string.IsNullOrWhiteSpace(result.Value)) return null;

        //    //Создаем графический элемент задачи
        //    TaskItem task = new TaskItem(this.SelectedProjectItem, this.SelectedProjectItem.MainProjectTaskRoot, level:0);
        //    task.Dock = DockStyle.Top;
        //    task.TaskName = result.Value;

        //    task.SubTaskPanel.Dock = DockStyle.Top;
        //    task.SubTaskPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        //    task.SubTaskPanel.AutoSize = true;

        //    this.SelectedProjectItem.TasksPanel.Controls.Add(task.SubTaskPanel);
        //    this.SelectedProjectItem.TasksPanel.Controls.Add(task);
        //    this.SelectedProjectItem.TasksPanel.Controls.SetChildIndex(task, 0);
        //    this.SelectedProjectItem.TasksPanel.Controls.SetChildIndex(task.SubTaskPanel, 0);

        //    return task;
        //}

        /// <summary>
        /// TaskForm Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskForm_Load(object sender, EventArgs e)
        {
            this.LoadProjectsList();
        }
        

        /// <summary>
        /// Горячие клавиши для элементов проекта ProjectItems
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        private bool ProcessHotKeysForProjectItems(ref Message msg, Keys keyData)
        {
            if (this.SelectedProjectItem == null) return false;
            if (this.SelectedProjectItem.Parent == null) return false;

            if (keyData == (Keys.Control | Keys.S))
            {
                this.SelectedProjectItem?.SaveProjetData();
                return true;
            }

            if (keyData == (Keys.Control | Keys.L))
            {
                this.LoadProjectsList();
                return true;
            }

            return false;
        }


        /// <summary>
        /// Горячие клавиши для элементов TaskItem
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        private bool ProcessHotKeysForTaskItems(ref Message msg, Keys keyData)
        {
            if (this.SelectedProjectItem?.SelectedTaskItem == null) return false;
            if (this.SelectedProjectItem?.Parent == null) return false;
            
            if (keyData == (Keys.Control | Keys.Up))
            {
                this.SelectedProjectItem.SelectedTaskItem.MoveTaskItem(MoveDirection.Top);
                return base.ProcessCmdKey(ref msg, keyData);
            }

            if (keyData == (Keys.Control | Keys.Down))
            {
                this.SelectedProjectItem.SelectedTaskItem.MoveTaskItem(MoveDirection.Down);
                return true;
            }

            if (keyData == (Keys.Down))
            {
                if (this.SelectedProjectItem?.SelectedTaskItem != null)
                {
                    SelectNextTaskItem(this.SelectedProjectItem.SelectedTaskItem);
                }

                return true;
            }

            if (keyData == (Keys.Up))
            {
                if (this.SelectedProjectItem?.SelectedTaskItem != null)
                {
                    SelectPreviousTaskItem(this.SelectedProjectItem.SelectedTaskItem);
                }

                return true;
            }

            if (keyData == (Keys.Control | Keys.N))
            {
                if (this.SelectedProjectItem?.SelectedTaskItem != null)
                {
                    this.SelectedProjectItem.SelectedTaskItem.CreateAndAddSubTask();
                }

                return true;
            }

            if (keyData == (Keys.Control | Keys.W))
            {
                if (this.SelectedProjectItem?.SelectedTaskItem != null)
                {
                    var taskForDelete = this.SelectedProjectItem.SelectedTaskItem;
                    SelectNextTaskItem(this.SelectedProjectItem.SelectedTaskItem);
                    taskForDelete.DeleteTaskItem();
                }

                return true;
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                if (this.SelectedProjectItem?.SelectedTaskItem != null)
                {
                    this.SelectedProjectItem.SelectedTaskItem.ChangeTaskStatus();
                }

                return true;
            }

            if (keyData == (Keys.Control | Keys.X))
            {
                if (this.SelectedProjectItem?.SelectedTaskItem != null)
                {
                    this.SelectedProjectItem.SelectedTaskItem.Revealed =
                        !this.SelectedProjectItem.SelectedTaskItem.Revealed;
                }

                return true;
            }

            if (keyData == (Keys.Control | Keys.R))
            {
                if (this.SelectedProjectItem?.SelectedTaskItem != null)
                {
                    this.SelectedProjectItem.SelectedTaskItem.EditTaskItemData();
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Горячие клавиши в форме
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
           ProcessHotKeysForProjectItems(ref msg, keyData);
           ProcessHotKeysForTaskItems(ref msg, keyData);
           return base.ProcessCmdKey(ref msg, keyData);

        }

        /// <summary>
        /// Выделить следующую по списку задачу (Рекурсивные переходы)
        /// </summary>
        private void SelectNextTaskItem(TaskItem curTaskItem, bool goToChildren = true)
        {
            //Если переданный объект нулевой или он отсутствует в панели, то выйти из метода
            if(curTaskItem?.Parent == null) return;

            if (Equals(curTaskItem, this.SelectedProjectItem.MainProjectTaskRoot.SubTaskItems.LastOrDefault()) == true &&
                (curTaskItem.SubTaskItems.Count == 0 || goToChildren == false))
            {
                return;
            }

            if (Equals(curTaskItem?.ParentTaskItem?.SubTaskItems?.LastOrDefault(), curTaskItem) == true &&
                (curTaskItem?.SubTaskItems?.Count == 0 || goToChildren == false))
            {
                SelectNextTaskItem(curTaskItem.ParentTaskItem, false);
                return;
            }

            if (curTaskItem.SubTaskItems.Count > 0 && 
                goToChildren &&
                curTaskItem.Task.Revealed == true)
            {
                ChangeSelectedTaskItem(curTaskItem.SubTaskItems[0]);
                return;
            }

            int nextIndex = curTaskItem.ParentTaskItem.SubTaskItems.IndexOf(curTaskItem) + 1;
            if (nextIndex < curTaskItem.ParentTaskItem.SubTaskItems.Count)
            {
                ChangeSelectedTaskItem(curTaskItem.ParentTaskItem.SubTaskItems[nextIndex]);
                return;
            }

            SelectNextTaskItem(curTaskItem.ParentTaskItem, false);
        }

        /// <summary>
        /// Выделить предыдущую по списку задачу (Рекурсивные переходы)
        /// </summary>
        private void SelectPreviousTaskItem(TaskItem curTaskItem, bool goToChildren = true)
        {
            // Если переданный объект нулевой или он отсутствует в панели, то выйти из метода
            if (curTaskItem?.Parent == null) return;

            if (Equals(curTaskItem, this.SelectedProjectItem.MainProjectTaskRoot.SubTaskItems.FirstOrDefault()) == true)
            {
                return;
            }

            if (Equals(curTaskItem.ParentTaskItem.SubTaskItems.FirstOrDefault(), curTaskItem) == true)
            {
                ChangeSelectedTaskItem(curTaskItem.ParentTaskItem);
                return;
            }

            int previosIndex = curTaskItem.ParentTaskItem.SubTaskItems.IndexOf(curTaskItem) - 1;
            var prevTaskItem = curTaskItem.ParentTaskItem.SubTaskItems[previosIndex];
            if (prevTaskItem.SubTaskItems.Count > 0 && 
                prevTaskItem.Task.Revealed == true)
            {
                //ChangeSelectedTaskItem(prevTaskItem.SubTaskItems.LastOrDefault());
                ChangeSelectedTaskItem(GetLastSubtaskFromTaskItem(prevTaskItem));
                return;
            }

            ChangeSelectedTaskItem(prevTaskItem);
        }

        /// <summary>
        /// Вернуть последний элемент во вложенных подзадачах.
        /// </summary>
        /// <param name="taskItem"></param>
        private TaskItem GetLastSubtaskFromTaskItem(TaskItem taskItem)
        { 
            if(taskItem.SubTaskItems != null && 
               taskItem.SubTaskItems.Count > 0 &&
               taskItem.Revealed)
            {
                return GetLastSubtaskFromTaskItem(taskItem.SubTaskItems.Last());
            }

            return taskItem;
        }

        /// <summary>
        /// Загружаем только элементы проектов. Данные по проектам не загружаем.
        /// </summary>
        private void LoadProjectsList()
        {
            var projFiles = this.GetAllProjectFileNames();
            if (projFiles == null || projFiles?.Count == 0) return;

            foreach(var file in projFiles)
            {
                ProjectItem projItem = new ProjectItem(file.fileName);
                AddProjectItemToParentPanel(this.ProjectsPanel, projItem);
            }
        }

        /// <summary>
        /// Загрузить данные из файла в проект
        /// </summary>
        /// <param name="proj"></param>
        private void LoadProjectDataFromFile(ref ProjectItem proj)
        {
            //По данным файла формируем объект MyProject
            ProjectDoc doc = new ProjectDoc(proj.Project.ProjectFilePath);
            var localProj = proj.Project;
            doc.GetProjectItem(ref localProj);
            //После того, как мы сформировали объект MyProject, начинаем формировать ProjectItem и TaskItems
            //по структуре объекта MyProject
            //Обязательно перед загрузкой задач нужно установить MainProjectTaskRoot.Task
            proj.MainProjectTaskRoot.Task = localProj.TaskRoot;
            proj.MainProjectTaskRoot.ProjectItem.AutoScroll = true;
            this.LoadTasks(proj, proj.Project.TaskRoot, proj.MainProjectTaskRoot);

            //Раскроем или закроем нужные панели подзадач
            //this.OpenCloseSubPanelsForAllTasks(proj.MainProjectTaskRoot);

            //После того, как мы загрузили объект выделим первую задачу
            if (proj.MainProjectTaskRoot?.SubTaskItems?.Count > 0)
            {
                this.ChangeSelectedTaskItem(proj.MainProjectTaskRoot.SubTaskItems[0]);
            }
        }

        /// <summary>
        /// Свернуть или развернуть все панели подзадач
        /// </summary>
        /// <param name="taskItem"></param>
        private void OpenCloseSubPanelsForAllTasks(TaskItem taskItem)
        {
            if (taskItem?.SubTaskItems?.Count <= 0) return;

            foreach (var subTask in taskItem.SubTaskItems)
            {
                if(subTask.SubTaskItems.Count <= 0) continue;

                subTask.Revealed = subTask.Task.Revealed;

                this.OpenCloseSubPanelsForAllTasks(subTask);
            }
        }


        /// <summary>
        /// загружаем и рисуем елементы задач в панели
        /// </summary>
        /// <param name="projItem"></param>
        /// <param name="ParentTask"></param>
        private void LoadTasks(ProjectItem projItem, MyTask ParentTask, TaskItem ParentTaskItem)
        {
            //Аккуратно работать в методе, а то хрен разберешь как исправить потом
            //NOTE НЕ ТРОГАТЬ НИЧЕГО
            int i = 0;
            while(i < ParentTask.SubTasks.Count)
            {
                TaskItem taskItem = new TaskItem(projItem,ParentTaskItem,
                    ParentTask.SubTasks[i],
                    ParentTask.Level+1,
                    ParentTask.SubTasks[i].Name);

                taskItem.Revealed = ParentTask.SubTasks[i].Revealed;

                //Добавить подзадачу, но не нужно изменять MyProject, поэтому второй параметр == true.
                ParentTaskItem.AddSubTaskItem(taskItem, true);
               
                //Рекурсивно создадим подзадачи
                this.LoadTasks(projItem, ParentTask.SubTasks[i], taskItem);
                i++;
            }
        }

        /// <summary>
        /// Получаем имена всех файлов проектов, или MyProjects в формате xml
        /// </summary>
        /// <returns></returns>
        private List<(string path, string fileName)> GetAllProjectFileNames()
        {
            var allFiles = Directory.GetFiles(ProjectsDirectory).ToList();
            if (allFiles == null || allFiles.Count == 0) return null;

            List<(string path, string fileName)> files = new List<(string,string)>();

            foreach (var projItemControl in this.ProjectsPanel.Controls)
            {
                ProjectItem projItem = projItemControl as ProjectItem;
                if(projItem == null) continue;

                if (allFiles.Contains(projItem.Project.ProjectFilePath))
                {
                    allFiles.Remove(projItem.Project.ProjectFilePath);
                }
            }

            foreach (var path in allFiles)
            {
                HelperFileName.ParsePath(path, out var _, out var fname, out var ext);
                
                if(string.Equals(ext, ".xml") == true)
                {
                    files.Add((path,fname));
                }
            }

            return files;
        }


        /// <summary>
        /// При закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void OnCloseForm()
        {
            //Проходим по всем загруженным проектам и сохраняем их перед закрытием формы
            foreach(var proj in this.ProjectsPanel.Controls)
            {
                if(proj is ProjectItem == false) continue;

                ProjectItem projItem = proj as ProjectItem;

                if(projItem?.TasksPanel?.Parent == null ||
                   projItem?.MainProjectTaskRoot?.Task?.SubTasks?.Count == 0) 
                {
                    continue;
                }

                projItem.SaveProjetData(false);
            }
        }
    }
}
