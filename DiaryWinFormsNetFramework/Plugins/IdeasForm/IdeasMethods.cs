using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DiaryClassLibStandart.Class;
using DiaryClassLibStandart.Class.IdeasClasses;

namespace DiaryWinFormsNetFramework.Plugins.IdeaForm
{
    public partial class IdeasForm
    {
        private string IdeasDirectory
        {
            get { return Settings.GetSetting(Settings.IdeasDirectory); }
        }

        /// <summary>
        /// Получить имя для файла с идеями
        /// </summary>
        /// <returns></returns>
        private string GetIdeasFilename()
        {
            return "Ideas_" + DateTime.Now.Year.ToString();
        }

       

        
    }
}