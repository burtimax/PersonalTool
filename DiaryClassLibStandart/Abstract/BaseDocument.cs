using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLib.Abstract
{
    public class BaseDocument : IDocument
    {
        byte[] body;

        string FileName;
        string FilePath;

        bool IsOpen;
        bool IsChanged;
        bool IsSaved;

       

        public virtual void Open(string path)
        {
            throw new NotImplementedException();
        }

        public virtual void Close()
        {
            throw new NotImplementedException();
        }

        public virtual void Rename()
        {
            throw new NotImplementedException();
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public void Save(string path)
        {
            throw new NotImplementedException();
        }

        public virtual void SaveAs(string path, bool rewriteExistFile = false)
        {
            throw new NotImplementedException();
        }
    }
}
