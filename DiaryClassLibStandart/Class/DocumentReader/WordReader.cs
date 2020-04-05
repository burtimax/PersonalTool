using DiaryClassLibStandart.Class.Basic;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Word;
using System.IO;
using DiaryClassLibStandart.Helpers;

namespace DiaryClassLibStandart.Class.DocumentReader
{
    class WordReader : IDocumentReader, IDisposable
    {
        readonly List<string> extensions = new List<string> { ".doc", ".docx" };

        Application App;
        Document Doc;


        public void OpenDocument(string path)
        {
            if(File.Exists(path)== false)
            {
                throw new Exception("Invalid path word document!");
            }

            HelperFileName.ParsePath(path, out var dir, out var fname, out var ext);
            
            if (extensions.Contains(ext) == false) return;//ToDo обработать когда не нашли doc extension

            this.App = new Application();
            this.Doc = this.App.Documents.Open(path);   
        }

        //считываем весь текст файла
        public bool ReadAllTextData(out string data)
        {
            data = null;

            
            if (this.Doc != null)
            {
                //ToDo read by paragraphs
                //for (var i = 0; i < this.Doc.Paragraphs.Count; i++)
                //{
                //    //если параграф пуст то пропустим его 

                //    if(this.Doc?.Paragraphs[i]?.Range != null &&
                //       string.IsNullOrEmpty(this.Doc?.Paragraphs[i]?.Range?.Text))
                //    {
                //        data += this.Doc?.Paragraphs[i]?.Range?.Text;
                //    }
                //}

                var range = this.Doc.Range();
                data = range.Text;
            }

            return string.IsNullOrEmpty(data) == false;
        }

        public void CloseDocument()
        {
            if (this.Doc != null)
            {
                this.Doc.Close();
            }
            if (this.App != null)
            {
                this.App.Quit();
            }
        }

        public void Dispose()
        {
            if(this.Doc != null)
            {
                this.Doc.Close();
            }
            if(this.App != null)
            {
                this.App.Quit();
            }
        }
    }
}
