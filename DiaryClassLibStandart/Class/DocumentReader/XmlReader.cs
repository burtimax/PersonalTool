using DiaryClassLibStandart.Class.Basic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DiaryClassLibStandart.Class.DocumentReader
{
    class XmlReader : IDocumentReader
    {
        XmlDocument Doc;
        

        public XmlReader()
        {
            this.Doc = new XmlDocument();
        }

        public void OpenDocument(string path)
        {
            this.Doc.Load(path);
        }

        public bool ReadAllTextData(out string data)
        {
            data = null;
            foreach(XmlNode node in this.Doc.DocumentElement)
            {
                if (string.IsNullOrEmpty(node.InnerText.Trim(' ')) == true) continue;

                data += node.Name+ ":" + '\n';
                data += node.InnerText.Trim(' ') + '\n';
                data += '\n';
            }

            return string.IsNullOrEmpty(data) == false;
        }
        public void CloseDocument()
        {
        }

    }
}
