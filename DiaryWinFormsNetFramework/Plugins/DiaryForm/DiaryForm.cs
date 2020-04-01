
using DiaryClassLib.Class;
using DiaryClassLibStandart.Class;
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
            //Initialize tabs
            InitTabs();
        }


        private void InitTabs()
        {
            TabStory.Checked = true;
            this.TabList = new Dictionary<RadioButton, TextContainer>();
            TabList.Add(TabStory, StoryTextContainer);
            TabList.Add(TabIdea, IdeaTextContainer);
            TabList.Add(TabAwards, AwardsTextContainer);
            SetCommonRadioClickEvent(TabClick_EventHandler, TabAwards, TabIdea, TabStory);
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


            var text = this.StoryTextContainer.TextField.Text;
            this.StoryTextContainer.TextField.Text = GetLastDiaryFilePath(Settings.GetSetting(Settings.AppDirectory));
            //this.record.Doc.WriteLine(text);
            //this.record.Doc.SaveAs(Settings.GetSetting(Settings.AppDirectory) + @"\tima", true);
            //Settings settings = new Settings();
            //settings.DirectoryApp.Value = Directory.GetCurrentDirectory();
            //settings.SetSetting(settings.DirectoryApp);


        }
    }
}
