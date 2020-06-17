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
                Settings.SetSetting(Settings.SettingsDirectory, res);
                this.labelDirectorySetting.Text = res;
            }
            
        }

        /// <summary>
        /// Chose Folder And Save Path To Stories Files
        /// </summary>
        private void btnOpenFolderDialogForStories_Click(object sender, EventArgs e)
        {          
            this.FolderDialog.ShowDialog();
            var res = FolderDialog.SelectedPath;
            if (string.IsNullOrEmpty(res) == false)
            {
                Settings.SetSetting(Settings.StoryDirectory, res);
                this.labelDirectoryStories.Text = res;
            }
        }

        /// <summary>
        /// Chose Folder And Save Path To IdeasFiles
        /// </summary>
        private void btnOpenFolderDialogForIdeasDirectory_Click(object sender, EventArgs e)
        {
            this.FolderDialog.ShowDialog();
            var res = FolderDialog.SelectedPath;
            if (string.IsNullOrEmpty(res) == false)
            {
                Settings.SetSetting(Settings.IdeasDirectory, res);
                this.labelDirectoryIdeas.Text = res;
            }
        }

        /// <summary>
        /// Chose Folder And Save Path For Projects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFolderDialogForProjectsDirectory_Click(object sender, EventArgs e)
        {
            this.FolderDialog.ShowDialog();
            var res = FolderDialog.SelectedPath;
            if (string.IsNullOrEmpty(res) == false)
            {
                Settings.SetSetting(Settings.ProjectsDirectory, res);
                this.labelDirectoryProjects.Text = res;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            FillElements();
        }


        private void FillElements()
        {
            this.labelDirectorySetting.Text = Settings.GetSetting(Settings.SettingsDirectory);
            this.labelDirectoryStories.Text = Settings.GetSetting(Settings.StoryDirectory);
            this.labelDirectoryIdeas.Text = Settings.GetSetting(Settings.IdeasDirectory);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var res = HelperDialog.ShowYesNoDialog("Вы действительно хотите поменять пароль?");
            if(res == DialogResult.Yes)
            {
                this.SendData(Constants.MESSAGE_CHANGE_PASSWORD,PerformOptions.SyncProcess);
            }
        }

        
    }
}
