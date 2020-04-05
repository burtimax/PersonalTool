
using DiaryClassLib.Class;
using DiaryClassLibStandart.Class;
using DiaryClassLibStandart.Class.Basic;
using DiaryClassLibStandart.Helpers;
using DiaryWinFormsNetFramework.HelpersConstants;
using DiaryWinFormsNetFramework.Plugins;
using DiaryWinFormsNetFramework.Plugins.BaseForm;
using DiaryWinFormsNetFramework.UserControls;
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

namespace DiaryWinFormsNetFramework.View
{
    public partial class DiaryForm: BaseFormParent
    {
        int highFileNumber = 0;

        Dictionary<RadioButton, TextContainer> TabList;

        TextContainer activeTextContainer;

        DiaryRecord Diary;

        public DiaryForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.Diary = new DiaryRecord();
            //Initialize tabs
            InitTabs();
        }


        private void InitTabs()
        {
            TabStory.Checked = true;
            this.TabList = new Dictionary<RadioButton, TextContainer>();
            TabList.Add(TabStory, StoryTextContainer);
            TabList.Add(TabIdea, IdeaTextContainer);
            TabList.Add(TabAwards, AchievemantsTextContainer);
            SetCommonRadioClickEvent(TabClick_EventHandler, TabAwards, TabIdea, TabStory);
        }


        /// <summary>
        /// Обрабатываем горячие клавиши
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.S))
            {
                this.SaveDiaryData();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        //Set common event handler for each Radio Button 
        void SetCommonRadioClickEvent(EventHandler handler, params RadioButton[] radios)
        {
            if (radios == null || radios.Length == 0) return;

            for (var i = 0; i < radios.Length; i++)
            {
                radios[i].CheckedChanged += handler;
            }
        }


        private void TabClick_EventHandler(object sender, EventArgs e)
        {
            if ((sender is RadioButton) == false) return;
            

            var radio = sender as RadioButton;

            if (radio.Checked == true)
            {
                HelperForm.ActivateControl(TabList[radio]);
            }
            else
            {
                HelperForm.DeactivateControl(TabList[radio]);
            }
        }
        
  

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveDiaryData();
        }

        void SaveDiaryData()
        {
            string fileName;
            //Если есть файл с текущей датой
            if (HasFileForCurrentDate(out fileName))
            { 
                //удалим файл с текущей датой.
                File.Delete(fileName);
            }

            var fileTitle = this.StoryTextContainer.Title;
            fileName = GetFileNameForSaving(fileTitle);
            

            this.Diary.Open(fileName);
            FillTextFields();
            this.Diary.SaveInfo();         
        }

        /// <summary>
        /// Заполняем все поля данных (обновляем поля текстов)
        /// </summary>
        void FillTextFields()
        {            
            this.Diary.SetText(this.Diary.Fields.Title, this.StoryTextContainer.Title);
            this.Diary.SetText(this.Diary.Fields.Story, this.StoryTextContainer.TextField.Text);
            this.Diary.SetText(this.Diary.Fields.Ideas, this.IdeaTextContainer.TextField.Text);
            this.Diary.SetText(this.Diary.Fields.Achievements, this.AchievemantsTextContainer.TextField.Text);            
        }

        private void DiaryForm_Load(object sender, EventArgs e)
        {
            LoadExistingData();
            LoadListDocuments();            
        }

        /// <summary>
        /// Загрузить данные (текст) на текущий день.
        /// </summary>
        void LoadExistingData()
        {
            if (HasFileForCurrentDate(out var pathCurFile))
            {           
                this.Diary.Open(pathCurFile);
                this.StoryTextContainer.Title = this.Diary.GetText(this.Diary.Fields.Title);
                this.StoryTextContainer.TextField.Text = this.Diary.GetText(this.Diary.Fields.Story);
                this.IdeaTextContainer.TextField.Text = this.Diary.GetText(this.Diary.Fields.Ideas);
                this.AchievemantsTextContainer.TextField.Text = this.Diary.GetText(this.Diary.Fields.Achievements);                
            }
        }

        void LoadListDocuments()
        {
            var docs = GetDiaryFilesNames();
            docs.Reverse();
            this.listBoxDocuments.DataSource = docs;
        }

        private void listBoxDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = ((ListBox)sender).SelectedItem.ToString();
            var path = GetFullPathStoryFileByFileName(value);
            HelperFileName.ParsePath(path, out var _, out var __, out var ext);
            IDocumentReader reader = HelperDocumentReader.CreateReader(ext);
            
            if(reader == null)
            {
                this.TextContainerDocumentContent.TextField.Text = "Не удалось считать данные из документа!";
                return;
            }

            reader.OpenDocument(path);
            if(reader.ReadAllTextData(out var data))
            {
                this.TextContainerDocumentContent.TextField.Text = data;
            }
            reader.CloseDocument();
        }

        private void btnOpenWritePanel_Click(object sender, EventArgs e)
        {
            HelperForm.DeactivateControl(this.TabReaderPanel);
            HelperForm.ActivateControl(this.TabWriterPanel);
        }

        private void btnOpenStoragePanel_Click(object sender, EventArgs e)
        {
            HelperForm.DeactivateControl(this.TabWriterPanel);
            HelperForm.ActivateControl(this.TabReaderPanel);
        }
    }
}
