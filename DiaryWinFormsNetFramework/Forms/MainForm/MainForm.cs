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
using DiaryWinFormsNetFramework.HelpersConstants;
using DiaryWinFormsNetFramework.Plugins.BotForm;
using DiaryWinFormsNetFramework.Plugins.TemplateForm;

namespace DiaryWinFormsNetFramework
{
    public partial class MainForm : BaseFormParent
    {
        delegate void EventGetAccessHandler();
        event EventGetAccessHandler OnGetUserAccess;

        private int WidthFormRatio = 1200;
        private int HeightFormRatio = 750;

        Panel formPanel;

        public MainForm() : base()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            formPanel = this.FormsPanel;
            var form = new BotForm();
            this.OpenForm(InstanceOf<BotForm>());

        }

        


     

      

        /// <summary>
        /// Открыть форму (окно)
        /// </summary>
        /// <param name="form"></param>
        public void OpenForm(BaseFormParent form)
        {
            //Ничего не открывать, пока не получили доступ
            if (Constants.ACCESS == false) return;

            var controls = formPanel.Controls;
            foreach(Control control in controls)
            {
                DisableControl(control);
            }
            if (controls.Contains(form))
            {
                EnableControl(controls[controls.IndexOf(form)]);
                //обновляем данные в форме.
                form.RefreshData();
            }
            else
            {
                //reset topLevel (it needs for adding form to mainForm)
                form.TopLevel = false;
                controls.Add(form);           
                EnableControl(form);
                form.Dock = DockStyle.Fill;
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
            OpenForm(InstanceOf<BotForm>());
        }

      


        //Перед закрытием гланой формы, вызовем методы OnCloseForm для каждой активной формы.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var form in BaseFormParent.ActiveForms)
            {             
                form.Value.OnCloseForm();
            }
        }

        /// <summary>
        /// Вызываем при загрузке окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetFormSize();
        }


        /// <summary>
        /// Устанавливаем высоту и ширину главного окна приложения, чтобы красиво выглядело
        /// </summary>
        void SetFormSize()
        {
            //var width = (int)SystemParameters.VirtualScreenWidth;
            //var height = (int)SystemParameters.VirtualScreenHeight;
            this.WindowState = FormWindowState.Normal;
            double K = 0.9f;
            var width = this.Width * K;
            var height = this.Height * K;
            double k = Math.Min(width / WidthFormRatio, height / HeightFormRatio);
            this.Width = (int)(k * WidthFormRatio);
            this.Height = (int)(k * HeightFormRatio);
            this.CenterToScreen();
        }

    }
}
