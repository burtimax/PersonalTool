using DiaryClassLibStandart.Class;
using DiaryWinFormsNetFramework.Plugins.BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryWinFormsNetFramework.Plugins.SettingsForm
{
    public partial class SettingsForm : BaseFormParent
    {
        public SettingsForm()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Chose Folder And Save Path To Settings File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFolderDialog_Click(object sender, EventArgs e)
        {
            this.FolderDialog.ShowDialog();
            var res = FolderDialog.SelectedPath;
            if(string.IsNullOrEmpty(res) == false)
            {
                Settings.SetSetting(Settings.AppDirectory, res);
                this.labelDirectorySetting.Text = res;
            }
            
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            FillElements();

        }



        private void FillElements()
        {
            this.labelDirectorySetting.Text = Settings.GetSetting(Settings.AppDirectory);
        }
    }
}
