using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryClassLibStandart.Class.Basic;

namespace DiaryWinFormsNetFramework.CustomDialogs
{
    public partial class InputBox : Form
    {
        private InputBox()
        {
            InitializeComponent();
        }

        public InputBox(string ask, string defaultValue = null) : this()
        {
            this.CaptionTxt.Text = ask;
            if(defaultValue != null)
            {
                this.InputTxt.Text = defaultValue;
            }
        }

        /// <summary>
        /// Вызываем метод для пользовательского ввода данных
        /// </summary>
        /// <param name="ask"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static CustomDialogResult Show(string ask, string defaultValue = null)
        {
            CustomDialogResult result = new CustomDialogResult(DialogResult.None, null);
            using (InputBox ib = new InputBox(ask, defaultValue))
            {
                ib.CenterToScreen();

                //Accept button (What happens when Enter clicked)
                using (Button acceptBtn = new Button())
                {
                    acceptBtn.Click += delegate (object sender, EventArgs args)
                    {
                        result.Value = ib.InputTxt.Text;
                        result.Status = DialogResult.OK;
                        ib.Close();
                        ib.Dispose();
                    };

                    Button declineBtn = new Button();
                    declineBtn.Click += delegate (object sender, EventArgs args)
                    {
                        result.Status = DialogResult.Cancel;
                        ib.Close();
                    };

                    ib.AcceptButton = acceptBtn;
                    ib.CancelButton = declineBtn;
                    ib.ShowInTaskbar = false;
                    ib.ShowDialog();
                    return result;
                }
            }
        }
    }
}
