using DiaryClassLibStandart.Abstract;
using DiaryClassLibStandart.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace DiaryClassLibStandart.Class
{
    public class MyXmlDocument
    {
        private string extension = ".xml";
        private string rootElementName = "Document";

        private string _filename;
        private string _directory;
        private string _path;

        private bool IsDocumentOpened = false;
        private XmlDocument Doc;
        public XmlElement Body;

        public string FileName { get => _filename; set => _filename = value; }
        public string Dir {
            get 
            {
                if(string.IsNullOrEmpty(_directory))
                {
                    _directory = Settings.GetSetting(Settings.StoryDirectory);
                }
                
                return _directory;
            }
            set => _directory = value; }
        public string Path { get => this.Dir + @"\" + this.FileName + this.extension; }

        private string AltPath
        {
            get
            {
                return this.Dir + @"\" + this.FileName + $" ({DateTime.Now})" + extension;
            }
        }

        public MyXmlDocument(string directory, string filename)
        {
            this.Dir = directory;
            this.FileName = filename;
           
        }

        public MyXmlDocument(string path)
        {
            ParsePath(path);
            
        }



        private void ParsePath(string path)
        {
            HelperFileName.ParsePath(path, out var localDir, out var localFname, out var localExt);
            if (localFname == null || localDir == null || localExt == null)
            {
                throw new Exception("Invalid File Path For Parsing");
            }

            if (localExt != extension)
            {
                throw new Exception("This is not XML file!");
            }

            this.Dir = localDir;
            this.FileName = localFname;
        }

        public void Close()
        {
            IsDocumentOpened = false;
        }

        public string GetElementValue(string elementName)
        {
            var foundElement = FindElement(elementName);

            if (foundElement == null) return null;

            return foundElement.InnerText;
        }

        public void Open(string path)
        {
            ParsePath(path);
            this.Open();
        }

        public void Open()
        {
            if (Directory.Exists(this.Dir) == false)
            {
                throw new Exception("Directory doesn't exists!");
            }

            if (this.Dir == null) throw new NullReferenceException("Directory parameter is null!");

            //Если не нашли файл, то создадим его. Проинициализируем переменные;
            if (File.Exists(this.Path) == false)
            {
                CreateNewFile(this.Path);
            }

            if (this.Doc == null && this.Body == null)
            {
                if(this.Path == null)
                {
                    InitDocAndBody();
                }
                else
                {
                    InitDocAndBody(this.Path);
                }
            }

            IsDocumentOpened = true;
        }

        public void Rename()
        {
            throw new NotImplementedException();
        }

        public void Save(string path = null)
        {
            if(this.Doc == null && this.Body == null)
            {
                throw new Exception("Null Elements!");
            }
            if(this.Doc != null && this.Body == null)
            {
                this.Body = this.Doc.CreateElement(rootElementName);   
            }
            if (path == null) path = this.Path;

            if(this.Doc.ChildNodes.Count == 0 || this.Doc.DocumentElement == null)
            {
                this.Doc.AppendChild(this.Body);               
            }
            
            this.Doc.Save(path);
        }

        public void SaveAs(string path, bool rewriteExistFile = false)
        {
            if(rewriteExistFile == true || File.Exists(this.Path) == false)
            {
                Save(this.Path);
            }
            else
            {
                this.Doc.Save(this.AltPath);
            }
        }

        public void SetElementValue(string elementName, string text)
        {
            SetOrChangeElementValue(elementName, text);
        }

        private void CreateNewFile(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateElement("Root"));
            doc.Save(Path);
        }

        private void InitDocAndBody(string docPath = null)
        {    
            if(this.Doc == null)
            {
                this.Doc = new XmlDocument();
            }
            
            this.Body = this.Doc.DocumentElement;
            if(this.Body == null)
            {
                this.Body = this.Doc.CreateElement(rootElementName);
                this.Doc.AppendChild(this.Body);
            }

            if (string.IsNullOrEmpty(docPath) == false)
            {
                this.Doc.Load(this.Path);
                this.Body = this.Doc.DocumentElement;
            }           
        }

        private XmlNode FindElement(string elementName)
        {

            foreach (XmlNode node in this.Body)
            {
                if (node.Name == elementName)
                {
                    return node;
                }
            }
            return null;
        }

        private void SetOrChangeElementValue(string elementName, string text)
        {
            if (this.Doc == null || this.Body == null)
            {
                throw new NullReferenceException();
            }

            var foundElement = FindElement(elementName);
            if (foundElement != null)
            {
                foundElement.InnerText = text;
            }
            else
            {
                var newElement = this.Doc.CreateElement(elementName);
                this.Body.AppendChild(newElement);
            }
        }

        private void Dispose()
        {
            this.Doc = null;
            this.Body = null;
        }
    }
}
