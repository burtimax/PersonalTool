using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryClassLibStandart.Class.IdeasClasses;
using DiaryClassLibStandart.Helpers;
using DiaryWinFormsNetFramework.HelpersConstants;
using DiaryWinFormsNetFramework.Plugins.BaseForm;
using DiaryWinFormsNetFramework.UserControls;

namespace DiaryWinFormsNetFramework.Plugins.IdeaForm
{
    public partial class IdeasForm : BaseFormParent
    {
        private IdeaListItem SelectedListItem;
        private IdeaDoc Document;

        public IdeasForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.Document = new IdeaDoc(IdeasDirectory, GetIdeasFilename());
        }

        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        private void IdeasForm_Load(object sender, EventArgs e)
        {
            InitComboBoxes();
            FillIdeaList();
        }

        /// <summary>
        /// Open AddIdeaPanel
        /// </summary>
        private void btnAddIdea_Click(object sender, EventArgs e)
        {
            ActivateCreateIdeaPanel();
        }

        private void ActivateCreateIdeaPanel()
        {
            HelperForm.DeactivateControl(SearchShowIdeaPanel);
            HelperForm.ActivateControl(CreateIdeaPanel);
        }

        /// <summary>
        /// Open Search and Show Data Panel
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ActivateIdeaDataSearchPanel();
        }

        private void ActivateIdeaDataSearchPanel()
        {
            HelperForm.DeactivateControl(CreateIdeaPanel);
            HelperForm.ActivateControl(SearchShowIdeaPanel);
        }

        /// <summary>
        /// Присваиваем ComboBoxам данные
        /// </summary>
        private void InitComboBoxes()
        {
            IdeaSection.DataSource = Constants.IdeaSectionsDict.Values.ToList();
            ShowIdeaSection.DataSource = Constants.IdeaSectionsDict.Values.ToList();
            IdeaMark.DataSource = Constants.MarksList;
            ShowIdeaMark.DataSource = Constants.MarksList;
        }

        /// <summary>
        /// Добавить идею в список
        /// </summary>
        private void btnSaveIdea_Click(object sender, EventArgs e)
        {
            Idea idea;

            if (CreateIdeaFromFields(out idea) == false)
            {
                //ToDo Вывести предупреждение, что не все поля заполнены
                return;
            }

            this.Document.AddIdea(idea);
            AddIdeaListItem(idea);

            ClearCreateIdeaTextFields();
        }

        /// <summary>
        /// Добавить в список IdeaListItem (пользовательский элемент идеи)
        /// </summary>
        /// <param name="idea"></param>
        private void AddIdeaListItem(Idea idea)
        {
            IdeaListItem IdeaListItem = new IdeaListItem(idea);
            //IdeaListItem.Click -= SelectIdeaItem;
            IdeaListItem.SetOnClick(SelectIdeaItem);
            IdeaListItem.TitleProp = idea.Title;
            IdeaListItem.MarkProp = idea.Mark.ToString();
            IdeaListItem.SectionColorProp = Constants.SectionsColors[idea.Section];
            IdeaListItem.Width = flowLayoutPanelIdeas.Width - 25;
            flowLayoutPanelIdeas.Controls.Add(IdeaListItem);
            flowLayoutPanelIdeas.Controls.SetChildIndex(IdeaListItem, 0);
        }

        /// <summary>
        ///  Создать экземпляр идеи из значений полей в панели для создания идеи
        /// </summary>
        /// <returns></returns>
        private bool CreateIdeaFromFields(out Idea idea)
        {
            idea = new Idea();

            //если текстовое поле для названия идеи пусто
            if(String.IsNullOrEmpty(IdeaTitle.Text.Trim(' ')))
            {
                return false;
            }

            idea.Title = IdeaTitle.Text;
            idea.Section = IdeaSection?.SelectedItem?.ToString();
            idea.Description = IdeaDescription.Text;
            idea.Mark = Convert.ToInt32(IdeaMark.SelectedItem.ToString());

            return true;
        }

        /// <summary>
        /// Заполнить список идеями из файла
        /// </summary>
        private void FillIdeaList()
        {
            var ideas = this.Document.GetAllIdeas();
            foreach (var idea in ideas)
            {
                AddIdeaListItem(idea.Value);
            }
        }

        private void SelectIdeaItem(object sender, EventArgs e)
        {
            Control c = sender as Control;
            
            //Получим элемент UserControl IdeaListItem
            IdeaListItem ideaItem = HelperControls.GetParenByType<IdeaListItem>(c);
            if (ideaItem == null)
            {
                return;
            }

            //Поменяем цвет для выделенной идеи
            ChangeColorSelectedIdeaItem(ideaItem);
           
            ShowDataForIdea(ideaItem.Idea);
        }


        /// <summary>
        /// Показать данные по идеи
        /// </summary>
        /// <param name=""></param>
        private void ShowDataForIdea(Idea idea)
        {
            ShowIdeaTitle.Text = idea.Title;
            ShowIdeaDescription.Text = idea.Description;
            ShowIdeaMark.Text = idea.Mark.ToString();
            ShowIdeaSection.Text = idea.Section;
            //Активируем панель для показа данных по идеи
            ActivateIdeaDataSearchPanel();
        }


        /// <summary>
        /// Поменять цвет для выбранного элемента
        /// </summary>
        private void ChangeColorSelectedIdeaItem(IdeaListItem ideaListItem)
        {
            if (this.SelectedListItem != null)
            {
                this.SelectedListItem.BackColorProp = Color.Transparent;
            }

            this.SelectedListItem = ideaListItem;
            this.SelectedListItem.BackColor = Color.FromArgb(218, 218, 218);
        }


        /// <summary>
        /// Сохраняем изменения в данных идеи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeIdeaData_Click(object sender, EventArgs e)
        {
            if (SelectedListItem == null)
            {
                HelperDialog.ShowWarningDialog("Выберете элемент из списка", "");
                return;
            }

            Idea idea = SelectedListItem?.Idea;

            //Изменяем поля объекта idea в соответствии с данными текстовых полей
            SetIdeaDataFromTextFields(ref idea);
            //Изменяем визуальный элемент в списке идей
            SetIdeaItemListTextFields(SelectedListItem, idea);

            //Изменяем данные в документе
            this.Document.ChangeIdea(idea);
        }


        /// <summary>
        /// Меняем текст и цвет элемента в соответствиис с данными
        /// </summary>
        private void SetIdeaItemListTextFields(IdeaListItem item, Idea idea)
        {
            item.TitleProp = idea.Title;
            item.MarkProp = idea.Mark.ToString();
            item.SectionColorProp = Constants.SectionsColors[idea.Section];
            SelectedListItem.Idea = idea;
        }


        /// <summary>
        /// Изменяем данные идеи в соответствии с текстовыми полями
        /// </summary>
        private void SetIdeaDataFromTextFields(ref Idea idea)
        {
            idea.Title = ShowIdeaTitle.Text;
            idea.Mark = Convert.ToInt32(ShowIdeaMark.Text);//ToDo Convert exception may be 
            idea.Description = ShowIdeaDescription.Text;
            idea.Section = ShowIdeaSection.Text;
        }


        /// <summary>
        /// Обработчик нажатия н кнопку удаления идеи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteIdea_Click(object sender, EventArgs e)
        {
            if (SelectedListItem == null) return;
            this.Document.DeleteIdea(SelectedListItem?.Idea);
            this.flowLayoutPanelIdeas.Controls.Remove(SelectedListItem);
            SelectedListItem = null;
            ClearTextFieldsInShowIdeaPanel();
        }

        /// <summary>
        /// Очистить все текстовые поля в панели показа данных идеи
        /// </summary>
        private void ClearTextFieldsInShowIdeaPanel()
        {
            ShowIdeaTitle.Text = "";
            ShowIdeaMark.SelectedIndex = 0;
            ShowIdeaSection.SelectedIndex = 0;
            ShowIdeaDescription.Text = "";
        }

        /// <summary>
        /// Очистить все текстовые поля в панели создания идеи
        /// </summary>
        private void ClearCreateIdeaTextFields()
        {
            IdeaTitle.Text = "";
            IdeaDescription.Text = "";
            IdeaSection.SelectedIndex = 0;
            IdeaMark.SelectedIndex = 0;
        }
    }
}
