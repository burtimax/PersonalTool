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
        public static Color COLOR_DARK_GREY = Color.FromArgb(100, 100, 100);
        public static Color COLOR_BLACK = Color.Black;
        public static Color COLOR_WHITE = Color.White;
        public static Color COLOR_TRANSPARENT = Color.Transparent;

        public static string MESSAGE_CHANGE_PASSWORD = "change_password";

        public static Dictionary<IdeaSections, string> IdeaSectionsDict = new Dictionary<IdeaSections, string>()
        {
            [IdeaSections.Underfined] = "Не определено",
            [IdeaSections.Business] = "Бизнес",
            [IdeaSections.Creativity] = "Творчество",
            [IdeaSections.Life] = "Жизнь",
            [IdeaSections.Productivity] = "Продуктивность",
            [IdeaSections.Other] = "Другое",
        };

        public static Dictionary<string, Color> SectionsColors = new Dictionary<string, Color>()
        {
            //[null] = Color.FromArgb(224,224,224),
            ["Не определено"] = Color.FromArgb(180, 180, 180),
            ["Бизнес"] = Color.FromArgb(52, 46, 173),
            ["Творчество"] = Color.FromArgb(240, 165,00),
            ["Жизнь"] = Color.FromArgb(117, 218, 173),
            ["Продуктивность"] = Color.FromArgb(255,128,176),
            ["Другое"] = Color.FromArgb(241, 214, 171),
        };

        public static List<int> MarksList = new List<int>()
        {
            0,1,2,3,4,5,6,7,8,9,10
        };

        


    }
}
