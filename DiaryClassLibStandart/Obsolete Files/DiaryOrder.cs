using DiaryClassLib.Abstract;
using DiaryClassLibStandart.Abstract;
using DiaryClassLibStandart.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLib.Class
{
    public class DiaryOrder
    {
        private string docPath;

        public readonly string[] extensions = new string[] { ".doc", ".docx" };
        public readonly string docPattern = "*.doc";
        public readonly string dir;
        public ITextDocument Doc;
        public InfoDoc Info;
        

        public DiaryOrder()
        {
            GetDocumentOrCreateDocument();
            Init();
        }

        public DiaryOrder(string docName)
        {
            this.dir = Settings.GetSetting(Settings.StoryDirectory);
            this.docPath = this.dir + @"\" + docName;
            GetDocumentOrCreateDocument(this.docPath);
            Init();
        }

        private void Init()
        {
            SetInfo();
        }

        private void GetDocumentOrCreateDocument(string path = null)
        {
            if(Equals(path, null))
            {
                this.Doc = new WordDoc();
            }
            if(Equals(path, null) == false)
            {
                this.Doc = new WordDoc(path);
            }
        }

        private void SetInfo()
        {
            this.Info = new InfoDoc();
        }

        
    }
}
