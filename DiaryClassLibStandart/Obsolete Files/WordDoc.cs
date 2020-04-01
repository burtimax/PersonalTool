using DiaryClassLib.Abstract;
using DiaryClassLibStandart.Abstract;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DiaryClassLib.Class
{
    public class WordDoc : BaseDocument, ITextDocument
    {
        Application _app;
        Document _doc;
        string _path;


        public WordDoc(){}

        public WordDoc(string path)
        {
            this.Path = path;
            this.Open(path);
        }

        public Application App {
            get
            {
                if(Equals(_app, null))
                {
                    _app = new Application();
                }
                return _app;
            }
            set => _app = value; }
        public Document Doc {
            get
            {
                if(Equals(this._doc, null))
                {
                    this._doc = new Document();
                }
                return this._doc;
            }
            set => _doc = value; }

        public string Path { get => _path; set => _path = value; }

        public override void Open(string path)
        {
            if (IsFileExists(path))
            {
                this.Doc = this.App.Documents.Open(path);
            }
            // set Error Processor
            throw new Exception("Directory is not exists!");

        }

        public override void Rename()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {           
            this.Doc.Save();
        }

        public override void SaveAs(string path, bool RewriteExistsFiles = false)
        {
            if (Equals(path, null)) 
            {
                throw new Exception("Path is Null");
            }           

            if (RewriteExistsFiles)
            {
                this.Doc.SaveAs2(path);
            }
            else
            {
                int count = 1;
                bool saved = false;
                string pathLocal = path;
                while (!saved)
                {
                    if(IsFileExists(pathLocal) == false)
                    {
                        this.Doc.SaveAs2(pathLocal);
                        saved = true;
                    }
                    else
                    {
                        int dotIndex = path.LastIndexOf('.');
                        if (Equals(path, null) == false && dotIndex>0)
                        {
                            pathLocal = path.Insert(dotIndex, $"({count.ToString()})");                
                        }
                    }
                    count++;
                }
            }   
        }

        public override void Close()
        {
            this.Doc.Close();
            this.App.Quit();
        }

        bool IsDirectoryExist(string path)
        {
            if (Directory.Exists(path)) return true;
            return false;
        }

        bool IsFileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }

        public void Write(string data)
        {
            Range r = this.Doc.Range();
            r.Text += data;
        }

        public void WriteLine(string data)
        {
            data += '\n';
            this.Write(data);
        }

        public string ReadLine()
        {
            throw new NotImplementedException();
        }

        public string ReadAllData()
        {
            return this.Doc.Range().Text;
        }

        public void AddParagraph(string paragraph)
        {
            Paragraph p = this.Doc.Paragraphs.Add();
            p.Range.Text = paragraph;
        }
    }
}
