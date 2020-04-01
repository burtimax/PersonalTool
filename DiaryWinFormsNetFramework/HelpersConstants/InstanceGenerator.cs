using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryWinFormsNetFramework.HelpersConstants
{
    class InstanceGenerator
    {
       

    }

    public class InstanceKey
    {
        long _key;

        public static InstanceKey Generate(object obj)
        {
            int rInt = new Random((int)DateTime.Now.Ticks).Next();
            InstanceKey key = new InstanceKey(obj.GetHashCode());
            return key;
        }


        public InstanceKey(long Key)
        {
            this.Key = Key;
        }

        public long Key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }
    }
}
