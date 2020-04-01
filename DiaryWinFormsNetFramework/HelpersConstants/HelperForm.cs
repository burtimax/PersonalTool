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
        public static void ActivateControl(Control control)
        {
            if (control == null) return;

            control.Enabled = true;
            control.Visible = true;
            control.Show();
        }


        public static void DeactivateControl(Control control)
        {
            if (control == null) return;

            control.Enabled = false;
            control.Visible = false;
            control.Hide();
        }




    }
}
