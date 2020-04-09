
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
    //ToDo Добавить отслеживание изменений текстовых полей, чтобы можно было предупреждать, что данные не сохранены.
    //ToDo Перед закрытием, изменением папки, предложить текущую запись.
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
            this.RefreshData();
            //Initialize tabs
            this.InitTabs();
        }

        //Проинициализировать все табы (кнопки с поведением вкладок)
        private void InitTabs()
        {
            TabStory.Checked = true;
            this.TabList = new Dictionary<RadioButton, TextContainer>();
            TabList.Add(TabStory, StoryTextContainer);
            TabList.Add(TabIdea, IdeaTextContainer);
            TabList.Add(TabAwards, AchievemantsTextContainer);
            foreach(var item in TabList)
            {
                /*Устанавливаем обработчик события нажатия на Tab... (кнопку-вкладку)*/
                item.Key.CheckedChanged += TabClick_EventHandler;
                //Устанавливаем обработчик события изменения содержимого текста в TextContainers
                item.Value.TextField.TextChanged += TextContainer_TextChanged;
            }
            
        }

        /// <summary>
        /// Обовить данные для актуализации.
        /// </summary>
        public override void RefreshData()
        {
            //Если директория поменялась, то обновим переменную записи.
            if(this.storyDirectory != Settings.GetSetting(Settings.StoryDirectory))
            {
                this.storyDirectory = Settings.GetSetting(Settings.StoryDirectory);
                //если поменяли путь к папке, то старые записи нам не нужны, очистим содержимое полей.\
                //ToDo (Добавить условие, что очищаем только если записи сохранены.)
                ClearAllVisibleFields();
                this.Diary = new DiaryRecord();
            }
            
            //вызываем обработчик загрузки окна
            this.DiaryForm_Load(this, new EventArgs());
            base.RefreshData();
        }


        /// <summary>
        /// Обрабатываем горячие клавиши
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //ctrl + s (Сохранить записи)
            if(keyData == (Keys.Control | Keys.S))
            {
                this.SaveDiaryData();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// 
        /// </summary>
        private void TextContainer_TextChanged(object sender, EventArgs e)
        {
            this.Diary.IsSaved = false;
        }


        ///Обработчик события нажатия TabButtons
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
        
  
        /// <summary>
        /// Обработчик кнопки сохранения записей
        /// </summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveDiaryData();
        }

        /// <summary>
        /// Сохраняем записи дневника
        /// </summary>
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
            //Проверим, если директория не существует
            HelperFileName.ParsePath(fileName, out var dir, out var _, out var __);
            if(Directory.Exists(dir) == false)
            {
                HelperDialog.ShowWarningDialog("Укажите в настройках путь к папке записей", "Не найдена папка для записей!");
                return;
            }

            this.Diary.Open(fileName);
            FillTextFields();
            if (this.Diary.SaveInfo())
            {
                this.Diary.IsSaved = true;
            }         
        }

        /// <summary>
        /// Заполняем все поля данных (обновляем Diary Fields)
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
            //загрузили нужные данные, отметим, что текстовые поля не изменялись
            this.Diary.IsSaved = true;
        }

        /// <summary>
        /// Загружаем в список имена файлов существующих записей.
        /// </summary>
        void LoadListDocuments()
        {
            var docs = GetDiaryFilesNames();
            if (docs == null || docs.Count == 0) return;

            docs.Reverse();
            this.listBoxDocuments.DataSource = docs;
        }


        /// <summary>
        /// Обработчик события изменения элемента списка
        /// Считываем данные по файлу из списка.
        /// </summary>
        private void listBoxDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            //Проверяем, чтобы список был не пустой
            if (listBox.Items == null || listBox.Items.Count == 0 || listBox.SelectedItem == null) return;

            var value = listBox.SelectedItem.ToString();
            var path = GetFullPathStoryFileByFileName(value);

            //Получаем расширение из имени файла
            HelperFileName.ParsePath(path, out var _, out var __, out var ext);
            //Получаем нужный объект для считывания документа (зависит от расширения)
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


        //активация панели для для записи
        private void btnOpenWritePanel_Click(object sender, EventArgs e)
        {
            HelperForm.DeactivateControl(this.TabReaderPanel);
            HelperForm.ActivateControl(this.TabWriterPanel);
        }

        //активация понели чтения существующих записей
        private void btnOpenStoragePanel_Click(object sender, EventArgs e)
        {
            HelperForm.DeactivateControl(this.TabWriterPanel);
            HelperForm.ActivateControl(this.TabReaderPanel);

            //Обновим список документов, может уже появился новый документ
            if(this.listBoxDocuments.Items == null ||
               this.listBoxDocuments.Items.Count == 0)
            {
                this.LoadListDocuments();
                return;
            }
            //здесь listBoxDocuments.Items != null;
            //если имя последнего файла не схоже с первой записью в дневнике
            if(this.GetDiaryFiles().Count != this.listBoxDocuments.Items.Count ||
               GetLastDiaryFilePath(this.storyDirectory).IndexOf(this.listBoxDocuments.Items[0].ToString()) < 0)
            {
                this.LoadListDocuments();
            }
        }


        /// <summary>
        /// Очищаем все текстовые поля, листбоксы и прочее, чтобы все стало чисто (нигде не было текста)
        /// </summary>
        void ClearAllVisibleFields()
        {
            this.IdeaTextContainer.TextField.Text = null;
            this.IdeaTextContainer.Title = "Idea";
            this.StoryTextContainer.TextField.Text = null;
            this.StoryTextContainer.Title = "Story";
            this.AchievemantsTextContainer.TextField.Text = null;
            this.AchievemantsTextContainer.Title = "Achievements";

            this.listBoxDocuments.DataSource = null;
            this.listBoxDocuments.Items.Clear();
            this.TextContainerDocumentContent.TextField.Text = null;
        }



        public override void OnCloseForm()
        {
            if (this.Diary.IsSaved == false)
            {
                var result = HelperDialog.ShowYesNoDialog("Сохранить запись дневника?", "Запись дневника изменена");
                if (result.Equals(DialogResult.Yes))
                {
                    SaveDiaryData();
                }
            }
            base.OnCloseForm();
        }



    }
}
