using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLib.Abstract
{
    public interface IDocument
    {

        void Open(string path);

        void Save(string path);

        void Rename();

        void SaveAs(string path, bool rewriteExistFile = false);

        void Close();
    }
}
