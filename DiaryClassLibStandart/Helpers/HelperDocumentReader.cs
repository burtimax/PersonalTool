using DiaryClassLibStandart.Class.Basic;
using DiaryClassLibStandart.Class.DocumentReader;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Helpers
{
    public class HelperDocumentReader
    {
        public static IDocumentReader CreateReader(string extension) 
        {
            extension = extension.Trim(' ', '.');
            switch (extension)
            {
                case "doc":
                case "docx":
                    return new WordReader();
                    break;
                case "xml":
                    return new XmlReader();
                    break;
                default:
                    return null;
            }
        }

    }
}
