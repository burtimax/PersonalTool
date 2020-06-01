using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Helpers
{
    public class KeyGenerator
    {
        public static int CreateIntegerKey(object obj = null)
        {
            if (obj != null)
            {
                return obj.GetHashCode();
            }
            else
            {
                return DateTime.Now.Ticks.GetHashCode();
            }
        }
    }
}
