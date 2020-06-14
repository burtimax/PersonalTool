using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryWinFormsNetFramework.HelpersConstants
{
    public class HelperControls
    {
        //toDo method, whish return parent object by special type
        public static T GetParenByType<T>(Control control)
        where T : Control
        {
           if (control?.Parent != null)
           {
               if (control.Parent is T) return control.Parent as T;
               return GetParenByType<T>(control.Parent as Control);
           }

           return default(T);
       }
    }
}
