using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Class
{
    public class SettingItem
    {
        readonly string _defAttribute = null;
        private string _value = null;

        public SettingItem(string nameSetting)
        {
            this.ElementName = nameSetting;
        }
       
        public string ElementName = null;
        public string Value
        {
            set
            {
                _value = value;
            }
            get
            {
                return _value;
            }
        }
    }
}
