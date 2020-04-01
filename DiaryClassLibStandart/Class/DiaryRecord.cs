using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Class
{
    public class DiaryRecord
    {
        MyXmlDocument Doc;
        DayRecord Record;

        private DiaryRecord()
        {
            this.Record = new DayRecord();
        }
        public DiaryRecord(string Directory, string FileName):this()
        {
            this.Doc = new MyXmlDocument(Directory, FileName);  
        }
        public DiaryRecord(string Path):this()
        {
            this.Doc = new MyXmlDocument(Path);
        }

        public void Open(string path)
        {
            this.Doc.Open(path);
        }
        
        public void SetText(TextField field, string text)
        {
            field.Text = text;
            this.Doc.SetElementValue(field.FieldName, text);
        }


        public string GetText(TextField field)
        {
            return this.Doc.GetElementValue(field.FieldName);
        }

        public void SaveInfo()
        {
            this.Doc.Save();
        }

        public void SaveAs(string path, bool rewriteExistsFiles)
        {
            this.Doc.SaveAs(path, rewriteExistsFiles);
        }

    }
}
