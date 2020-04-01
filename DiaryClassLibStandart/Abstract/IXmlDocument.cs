using DiaryClassLib.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Abstract
{
    interface IXmlDocument
    {
        void SetElement(string elementName, string text);

        string GetElement(string elementName);
    }
}
