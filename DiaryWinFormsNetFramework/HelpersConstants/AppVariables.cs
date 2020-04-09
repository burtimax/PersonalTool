using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryWinFormsNetFramework.HelpersConstants
{
    class AppVariables
    {

        public static string MAIN_DIRECTORY = Directory.GetCurrentDirectory();
        public static string PASSWORD_APP_SETTING 
        {
            get
            {
                return Properties.Settings.Default.UserPassword;
            }
            set
            {
                Properties.Settings.Default.UserPassword = value;
                Properties.Settings.Default.Save();
            }
        }

    }
}
