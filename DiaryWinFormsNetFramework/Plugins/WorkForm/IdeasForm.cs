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
using DiaryWinFormsNetFramework.HelpersConstants;
using DiaryWinFormsNetFramework.Plugins.BaseForm;
using DiaryWinFormsNetFramework.UserControls;

namespace DiaryWinFormsNetFramework.Plugins.ToDoPlanForm
{
    public partial class IdeasForm : BaseFormParent 
    {
        public IdeasForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        private void IdeasForm_Load(object sender, EventArgs e)
        {
            InitComboBoxes();
        }

        /// <summary>
        /// Open AddIdeaPanel
        /// </summary>
        private void btnAddIdea_Click(object sender, EventArgs e)
        {
            HelperForm.DeactivateControl(SearchShowIdeaPanel);
            HelperForm.ActivateControl(CreateIdeaPanel);
        }

        /// <summary>
        /// Open Search and Show Data Panel
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
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

            IdeaListItem IdeaListItem = new IdeaListItem(idea);
            IdeaListItem.TitleProp = idea.Title;
            IdeaListItem.MarkProp = idea.Mark.ToString();
            Random r = new Random(DateTime.Now.Second);
            Color color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            IdeaListItem.ColorProp = color;
            IdeaListFlowPanel.Controls.Add(IdeaListItem);
            IdeaListFlowPanel.Controls.SetChildIndex(IdeaListItem,0);
            IdeaListItem.Dock = DockStyle.Top;

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
            idea.Section = IdeaSection.SelectedItem.ToString();
            idea.Description = IdeaDescription.Text;
            idea.Mark = Convert.ToInt32(IdeaMark.SelectedItem.ToString());

            return true;
        }

    }
}
