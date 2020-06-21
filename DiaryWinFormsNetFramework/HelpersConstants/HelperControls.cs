using System;
using System.Collections;
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

        /// <summary>
        /// Метод для получения всех контролов внутри элемента
        /// Проходим рекурсивно и возвращаем все имеющиеся контролы
        /// Использую метод для последующей привязки обработчика события
        /// Нужно для выделения элемента при нажатии мышки на любой контрол внутри основного
        /// </summary>
        /// <param name="parentControl"></param>
        /// <returns></returns>
        public static IEnumerable<Control> GetAllChildrenControls(Control parentControl)
        {
            var parentControls = parentControl?.Controls.Cast<Control>();

            foreach (Control item in parentControl?.Controls)
            {
                if (item.HasChildren)
                {
                    var itemControls = HelperControls.GetAllChildrenControls(item);
                    
                    if(itemControls == null || itemControls.Count() == 0)
                    {
                        continue;
                    }

                    parentControls = parentControls?.Concat(itemControls);
                }
            }

            return parentControls;
        }

        //Todo Можно сделать еще отдельным параметром (на какое событие подписываемся: Click, Load, ect...)
        /// <summary>
        /// Устанавливает обработчик OnClick для control и всех его дочерних элементов.
        /// Применяю для визуального выделения объекта.
        /// </summary>
        /// <param name="control"></param>
        public static void SetOnClickHandlerForAllElementsInControl(Control control, EventHandler handler)
        {
            var allControls = HelperControls.GetAllChildrenControls(control);
            foreach(var itemControl in allControls)
            {
                itemControl.Click -= handler;
                itemControl.Click += handler;
            }
        }


        /// <summary>
        /// Устанавливает обработчик OnClick для control и всех его дочерних элементов.
        /// Применяю для визуального выделения объекта.
        /// </summary>
        /// <param name="control"></param>
        public static void SetOnDoubleClickHandlerForAllElementsInControl(Control control, EventHandler handler)
        {
            var allControls = HelperControls.GetAllChildrenControls(control);
            foreach (var itemControl in allControls)
            {
                itemControl.DoubleClick -= handler;
                itemControl.DoubleClick += handler;
            }
        }


        //Todo Можно сделать еще отдельным параметром (на какое событие подписываемся: Click, Load, ect...)
        /// <summary>
        /// Устанавливает обработчик OnMouseEnter для control и всех его дочерних элементов.
        /// </summary>
        /// <param name="control"></param>
        public static void SetOnMouseEnterHandlerForAllElementsInControl(Control control, EventHandler handler)
        {
            var allControls = HelperControls.GetAllChildrenControls(control);
            foreach (var itemControl in allControls)
            {
                itemControl.MouseEnter -= handler;
                itemControl.MouseEnter += handler;
            }
        }


        //Todo Можно сделать еще отдельным параметром (на какое событие подписываемся: Click, Load, ect...)
        /// <summary>
        /// Устанавливает обработчик OnMouseLeave для control и всех его дочерних элементов.
        /// </summary>
        /// <param name="control"></param>
        public static void SetOnMouseLeaveHandlerForAllElementsInControl(Control control, EventHandler handler)
        {
            var allControls = HelperControls.GetAllChildrenControls(control);
            foreach (var itemControl in allControls)
            {
                itemControl.MouseLeave -= handler;
                itemControl.MouseLeave += handler;
            }
        }
    }
}
