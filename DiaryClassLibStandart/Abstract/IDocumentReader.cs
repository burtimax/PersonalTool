using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Class.Basic
{
    public interface IDocumentReader
    {
        void OpenDocument(string path);

        bool ReadAllTextData(out string data);

        void CloseDocument();
    }
}
