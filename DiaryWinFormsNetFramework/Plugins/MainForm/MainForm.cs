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
using DiaryClassLib.Class;
using DiaryClassLibStandart;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using DiaryWinFormsNetFramework.Plugins.BaseForm;
using DiaryWinFormsNetFramework.View;
using DiaryWinFormsNetFramework.Plugins.SettingsForm;

namespace DiaryWinFormsNetFramework
{
    public partial class MainForm : BaseFormParent
    {
        Panel formPanel;
    
        public MainForm():base()
        {
            InitializeComponent();
            formPanel = this.FormsPanel;
            OpenForm(new DiaryForm());
        }


        public void OpenForm(BaseFormParent form)
        {
            var controls = formPanel.Controls;
            foreach(Control control in controls)
            {
                DisableControl(control);
            }
            if (controls.Contains(form))
            {
                EnableControl(controls[controls.IndexOf(form)]);
            }
            else
            {
                //reset topLevel (it needs for adding form to mainForm)
                form.TopLevel = false;
                controls.Add(form);           
                EnableControl(form);           
            }
            
        }


        void DisableControl(Control control)
        {
            control.Enabled = false;
            control.Visible = false;
            control.Hide();
        }

        void EnableControl(Control control)
        {
            control.Enabled = true;
            control.Visible = true;
            control.Show();
        }

        private void btnCloseCircle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNavItemSettings_Click(object sender, EventArgs e)
        {
            OpenForm(InstanceOf<SettingsForm>());
        }

        private void btnNavItemDiary_Click(object sender, EventArgs e)
        {
            OpenForm(InstanceOf<DiaryForm>());
        }

     
    }
}
