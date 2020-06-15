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
using DiaryClassLibStandart.Helpers;
using DiaryWinFormsNetFramework.HelpersConstants;
using DiaryWinFormsNetFramework.Properties;
using TaskStatus = DiaryClassLibStandart.Class.TaskClass.TaskStatus;

namespace DiaryWinFormsNetFramework.UserControls
{
    public partial class TaskItem : UserControl, IDisposable
    {
        public EventHandler ClickEventHandler;
        public EventHandler DoubleClickEventHandler;

        private TaskItem()
        {
            InitializeComponent();
        }

        public TaskItem(ProjectItem project, TaskItem parentTask = null, int level = 0 ):this()
        {
            Init(project, parentTask, level);
        }

        public MyTask Task { get; set; }
        public ProjectItem ProjectItem;
        public TaskItem ParentTaskItem;
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


        private void Init(ProjectItem project, TaskItem parentTaskItem, int taskLevel = 0)
        {
            this.Task = new MyTask("", taskLevel);
            this.ProjectItem = project;
            this.ParentTaskItem = parentTaskItem;

            InitPanel();
            this.SubTaskItems = new List<TaskItem>();

            //спрячем кнопку свернуть/развернуть
            HelperForm.DeactivateControl(this.OpenCloseArrow);

            this.ClickEventHandler = TaskItem_OnClick;
            this.DoubleClickEventHandler = TaskItem_OnDoubleClick;
        }


        private void InitPanel()
        {
            this._subPanel = new Panel();
            this._subPanel.Dock = DockStyle.Top;
            this._subPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this._subPanel.AutoSize = true;
            if (this.Task.Level+1 > 0)
            {
                this._subPanel.Padding = new Padding(22,
                    this._subPanel.Padding.Top,
                    this._subPanel.Padding.Right,
                    this._subPanel.Padding.Bottom);
            }
        }

        /// <summary>
        /// Добавить подзадачу в задачу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSubTask_Click(object sender, EventArgs e)
        {
            CreateAndAddSubTask();
        }

        /// <summary>
        /// Создаем и добавляем подзадачу
        /// </summary>
        public void CreateAndAddSubTask()
        {
            var result = HelperDialog.ShowInputBox("Введите название задачи?");

            if (result.Status != DialogResult.OK || string.IsNullOrWhiteSpace(result.Value)) return;

            var subTask = new TaskItem(this.ProjectItem, this, this.Task.Level + 1)
            {
                TaskName = result.Value,
                Dock = DockStyle.Top,
            };

            this.SubTaskPanel.Controls.Add(subTask.SubTaskPanel);
            this.SubTaskPanel.Controls.Add(subTask);
            this.SubTaskPanel.Controls.SetChildIndex(subTask, 0);
            this.SubTaskPanel.Controls.SetChildIndex(subTask.SubTaskPanel, 0);
            this.SubTaskItems.Add(subTask);

            //покажем кнопку свернуть/развернуть
            HelperForm.ActivateControl(this.OpenCloseArrow);

            //вызовем у проекта событие OnChangeSelectedTaskItem (Что выбрали другую задачу). Вызываем событие через внешний метод. 
            //Как-то это не хорошо, но пока что так. Не могу вызвать событие напрямую.
            this.ProjectItem.SelectedTaskItemWasChanged(subTask);
            //Привязываем обработчик события нажатия для дочерних элементов
            HelperControls.SetOnClickHandlerForAllElementsInControl(subTask, subTask.ClickEventHandler);
            HelperControls.SetOnDoubleClickHandlerForAllElementsInControl(subTask, subTask.DoubleClickEventHandler);
        }

        /// <summary>
        /// изменение статуса задачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            BackColor = Color.Transparent;
            if (box.Checked == true)
            {
                //Меняем статус задачи
                this.Task.Status = TaskStatus.Done;
                //Меняем картинку у чек-бокса
                box.BackgroundImage = Resources._checked;
                //Зачеркиваем текст задачи
                this.txtName.Font = new Font(this.txtName.Font.FontFamily,
                    this.txtName.Font.Size, 
                    FontStyle.Strikeout);

            }
            else
            {
                //Меняем статус задачи
                this.Task.Status = TaskStatus.ToDo;
                //Меняем картинку у чек-бокса
                box.BackgroundImage = Resources._unchecked;
                //Делаем нормальный шрифт, без зачеркиваний.
                this.txtName.Font = new Font(this.txtName.Font.FontFamily,
                    this.txtName.Font.Size);
            }
        }


        /// <summary>
        /// Свернуть/развернуть подзадачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCloseArrow_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            box.BackColor = Color.Transparent;
            if (box.Checked == true)
            {
                //Меняем картинку у чек-бокса
                box.BackgroundImage = Resources.downArrow;

                HelperForm.ActivateControl(this.SubTaskPanel);
            }
            else
            {
                //Меняем картинку у чек-бокса
                box.BackgroundImage = Resources.rightArrow;

                HelperForm.DeactivateControl(this.SubTaskPanel);
            }
        }



        /// <summary>
        /// Событие нажатия кнопки удалиения задачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteTask_Click(object sender, EventArgs e)
        {
            DeleteTaskItem();
        }


        private void DeleteTaskItem()
        {
            //Если у задачи есть подзадачи, то спросить у пользователя, удалять подзадачи.
            if (this.SubTaskItems != null && this.SubTaskItems.Count > 0)
            {
                var answer = HelperDialog.ShowYesNoDialog("Удалить подзадачи?", "Подзадачи будут удалены!");
                if (answer == DialogResult.No) return;
            }

            //Удалить элемент задачи из панели задач
            DeleteCurrentTaskFromPanel();
            //затем удалить задачу из элемента проекта
            //Освободить память об этом объекте
            DeleteCurrentTaskFromProject();
        }

        /// <summary>
        /// Удаляем подзадачи и текущую задачу рекурсивно
        /// </summary>
        public void DeleteCurrentTaskFromProject()
        {
            //Рекурсивно удаляем подзадачи и задачу
            if (this.SubTaskItems == null || this.SubTaskItems.Count == 0)
            {
                this.Delete();
                return;
            }

            while (this.SubTaskItems.Count != 0)
            {
                this.SubTaskItems[0].DeleteCurrentTaskFromProject();
            }
            
            

            //После того как удалили подзадачи нужно удалить саму задачу.
            this.Delete();
        }

        /// <summary>
        /// Удалить текущую задачу
        /// </summary>
        /// <param name="task"></param>
        private void Delete()
        {
            this.UnsubscribeClickEvent();
            this.ParentTaskItem.SubTaskItems.Remove(this);
            //ToDo посмотреть как правильно диспозить без утечек памяти, а пока что так.
            this.Dispose();
        }

        /// <summary>
        /// Удалить текущий TaskItem из панели и удалить панель этого TaskItem. Рекурсивно.
        /// </summary>
        public void DeleteCurrentTaskFromPanel()
        {
            if (this.SubTaskItems == null || this.SubTaskItems.Count == 0)
            {
                this.ParentTaskItem?.SubTaskPanel.Controls.Remove(this.SubTaskPanel);
                this.ParentTaskItem?.SubTaskPanel.Controls.Remove(this);
                return;
            }

            foreach (var item in this.SubTaskItems)
            {
                item.DeleteCurrentTaskFromPanel();
            }

            this.ParentTaskItem?.SubTaskPanel.Controls.Remove(this.SubTaskPanel);
            this.ParentTaskItem?.SubTaskPanel.Controls.Remove(this);
        }

        /// <summary>
        /// Визуально отобразить, как активную задачу.
        /// </summary>
        public void VisualActivate()
        {
            this.ContentPanel.BackColor = Constants.COLOR_GREY;
        }

        /// <summary>
        /// Визуально отобразить как неактивную задачу
        /// </summary>
        public void VisuaLDeactivate()
        {
            this.ContentPanel.BackColor = Constants.COLOR_TRANSPARENT;
        }

        /// <summary>
        /// Обработчик мобытия нажатия на TaskItem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TaskItem_OnClick(object sender, EventArgs args)
        {
            TaskItem clickedTaskItem = HelperControls.GetParenByType<TaskItem>(sender as Control);
            this.ProjectItem?.SelectedTaskItemWasChanged(clickedTaskItem);
        }

        /// <summary>
        /// Обработчик cобытия двойного нажатия на TaskItem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void TaskItem_OnDoubleClick(object sender, EventArgs args)
        {
            TaskItem clickedTaskItem = HelperControls.GetParenByType<TaskItem>(sender as Control);
            this.EditTaskItemData();
        }

        /// <summary>
        /// Отписываемся от события нажатия на дочерний контрол
        /// </summary>
        public void UnsubscribeClickEvent()
        {
            var allControls = HelperControls.GetAllChildrenControls(this.SubTaskPanel);
            foreach(var itemControl in allControls)
            {
                itemControl.Click -= this.ClickEventHandler;
                itemControl.DoubleClick -= this.DoubleClickEventHandler;
            }
        }

        /// <summary>
        /// Редактировать элемент задачи (Поменять название задачи)
        /// </summary>
        private void EditTaskItemData()
        {
            //Вызываем окошко для редактирования названия задачи
            var res = HelperDialog.ShowInputBox($"Изменить задачу: ({this.TaskName})");
            if (res.Status != DialogResult.OK || string.IsNullOrEmpty(res.Value)) return;

            this.TaskName = res.Value;
        }

        public void Dispose()
        {
            this.ClickEventHandler = null;
            this.ParentTaskItem = null;
            this.ProjectItem = null;
            this.SubTaskItems = null;
            this.Task = null;
            this.SubTaskPanel = null;
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
