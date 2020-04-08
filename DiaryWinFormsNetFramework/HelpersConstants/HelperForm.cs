using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryWinFormsNetFramework.HelpersConstants
{
    public static class HelperForm
    {
        /// <summary>
        /// Активировать Control (enable, visible, show)
        /// </summary>
        /// <param name="control"></param>
        public static void ActivateControl(Control control)
        {
            if (control == null) return;

            control.Enabled = true;
            control.Visible = true;
            control.Show();
        }

        /// <summary>
        /// Деактивировать Control (disable, invisible, hide)
        /// </summary>
        /// <param name="control"></param>
        public static void DeactivateControl(Control control)
        {
            if (control == null) return;

            control.Enabled = false;
            control.Visible = false;
            control.Hide();
        }




    }
}
