using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Class
{
    public class DiaryDoc
    {
        MyXmlDocument Doc;
        DiaryFields fields;
        
        public bool IsSaved = true;

        public DiaryFields Fields
        {
            get { return fields; }
        }       
        public DiaryDoc()
        {
            this.fields = new DiaryFields();
        }
        public DiaryDoc(string Directory, string FileName):this()
        {
            this.Doc = new MyXmlDocument(Directory, FileName);  
        }
        public DiaryDoc(string Path):this()
        {
            this.Doc = new MyXmlDocument(Path);
        }

        public void Open(string path)
        {
            if(this.Doc == null)
            {
                this.Doc = new MyXmlDocument(path);
            }
            this.Doc.Open(path);
        }
        
        public void SetText(TextField field, string text)
        {
            field.Text = text;
            this.Doc.SetElementValue(field.FieldName, text);
        }

        /// <summary>
        /// Получить текст из документа для поля field
        /// </summary>
        /// <param name="field">Поле, по которому получить текст из документа</param>
        /// <returns></returns>
        public string GetText(TextField field)
        {
            return this.Doc.GetElementValue(field.FieldName);
        }

        /// <summary>
        /// Сохранить данные из тестовых полей (TextContainers and Title)
        /// </summary>
        /// <returns>true - если данные сохранены успешно, иначе false</returns>
        public bool SaveInfo()
        {
            try
            {
                this.Doc.SetElementValue(this.Fields.Story.FieldName, this.Fields.Story.Text);
                this.Doc.SetElementValue(this.Fields.Ideas.FieldName, this.Fields.Ideas.Text);
                this.Doc.SetElementValue(this.Fields.Achievements.FieldName, this.Fields.Achievements.Text);
                this.Doc.Save();
                return true;
            }
            catch
            {
                this.Doc.Close();
                return false;
            }
        }

        public void SaveAs(string path, bool rewriteExistsFiles)
        {
            this.Doc.SaveAs(path, rewriteExistsFiles);
        }

    }
}
