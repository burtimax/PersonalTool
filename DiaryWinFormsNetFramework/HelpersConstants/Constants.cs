using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiaryClassLibStandart.Class.IdeasClasses;

namespace DiaryWinFormsNetFramework.HelpersConstants
{
    public class Constants
    {
        public static bool ACCESS = false;
        public static Color COLOR_LIGHT_GREY = Color.FromArgb(236, 236, 236);
        public static Color COLOR_GREY = Color.FromArgb(210, 210, 210);
        public static string MESSAGE_CHANGE_PASSWORD = "change_password";

        public static Dictionary<IdeaSections, string> IdeaSectionsDict = new Dictionary<IdeaSections, string>()
        {
            [IdeaSections.Business] = "Бизнес",
            [IdeaSections.Creativity] = "Творчество",
            [IdeaSections.Life] = "Жизнь",
            [IdeaSections.Productivity] = "Продуктивность",
            [IdeaSections.Other] = "Другое",
        };

        public static List<int> MarksList = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10
        };
    }
}
