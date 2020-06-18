using DiaryClassLibStandart.Abstract;
using DiaryClassLibStandart.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DiaryClassLibStandart.Class
{
    public class MyXmlDocument
    {
        private string DefaultNameForFileSaving = "FILE";
        private string extension = ".xml";
        private string rootElementName = "Document";

        private string _filename;
        private string _directory;
        private string _path;

        private bool IsDocumentOpened = false;
        public XmlDocument Doc;
        public XmlElement Body;

        public string FileName
        {
            get => _filename;
            set => _filename = value;
        }

        public string Dir
        {
            get
            {
                if (string.IsNullOrEmpty(_directory))
                {
                    _directory = Settings.GetSetting(Settings.StoryDirectory);
                }

                return _directory;
            }
            set => _directory = value;
        }

        public string Path
        {
            get => this.Dir + @"\" + this.FileName + this.extension;
        }

        private string AltPath
        {
            get { return this.Dir + @"\" + this.FileName + $" ({DateTime.Now})" + extension; }
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

            if (this.Doc == null || this.Body == null)
            {
                if (this.Path == null)
                {
                    InitDocAndBodyIfNeed();
                }
                else
                {
                    InitDocAndBodyIfNeed(this.Path);
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
            if (this.Doc == null && this.Body == null)
            {
                throw new Exception("Null Elements!");
            }

            if (this.Doc != null && this.Body == null)
            {
                this.Body = this.Doc.CreateElement(rootElementName);
            }

            if (path == null) path = this.Path;

            if (this.Doc.ChildNodes.Count == 0 || this.Doc.DocumentElement == null)
            {
                this.Doc.AppendChild(this.Body);
            }

            this.SaveDocumentDataWithSafe(this.Doc, path);
        }

        public void SaveAs(string path, bool rewriteExistFile = false)
        {
            if (rewriteExistFile == true || File.Exists(this.Path) == false)
            {
                Save(this.Path);
            }
            else
            {
                this.SaveDocumentDataWithSafe(this.Doc, AltPath);
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
            this.SaveDocumentDataWithSafe(doc, path);
        }

        private void InitDocAndBodyIfNeed(string docPath = null)
        {
            if (this.Doc == null)
            {
                this.Doc = new XmlDocument();
            }

            this.Body = this.Doc.DocumentElement;
            if (this.Body == null)
            {
                this.Body = this.Doc.CreateElement(rootElementName);
                this.Doc.AppendChild(this.Body);
            }

            if (string.IsNullOrEmpty(docPath) == false)
            {
                LoadDocumentData(this.Doc, docPath);
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

        /// <summary>
        /// Безопасное сохранение XmlDocument
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="fileName"></param>
        private bool SaveDocumentData(XmlDocument doc, string fileName)
        {
            try
            {
                doc.Save(fileName);
                return true;
            }
            //Ошибка при сохранении файла
            catch (Exception e)
            {
                HelperFileName.ParsePath(fileName, out var dir, out var fname, out var ext);
                fname = GetDefaultErrorFileName(fname);
                string localPath = dir + @"\" + fname + ext;
                doc.Save(localPath);
                return false;
            }
        }


        /// <summary>
        /// Безопасное извлечение или загрузка XmlDocument
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="path"></param>
        private void LoadDocumentData(XmlDocument doc, string path)
        {
            try
            {
                doc.Load(path);
            }
            //Поймали ошибку, имя файла содержит недопустимые символы
            catch (Exception e)
            {
                //Обработаем ошибку отсутствия корневого элемента в xml файле
                //Просто если корневого елемента нет, ничего не делать.
                if (String.Equals(e.Message, "Отсутствует корневой элемент."))
                {
                    return;
                }

                HelperFileName.ParsePath(path, out var dir, out var fname, out var ext);
                fname = GetDefaultErrorFileName(fname);
                string localPath = dir + @"\" + fname + ext;
                doc.Load(localPath);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName">Только имя файла, без директории, без расширения</param>
        /// <returns></returns>
        private string GetDefaultErrorFileName(string fname)
        {
            int openBracket = -1;
            openBracket = fname.IndexOf('{');
            int closeBracket = -1;
            closeBracket = fname.IndexOf('}');

            //Если содержит фигурные скобки, то поменяем название внутри фигурных скобок
            if (openBracket > -1 && closeBracket > -1)
            {
                fname = fname.Remove(openBracket + 1, closeBracket - openBracket - 1);
                fname = fname.Insert(openBracket + 1, DefaultNameForFileSaving);
            }
            //иначе просто поменяем название
            else
            {
                fname = DateTime.Now.Date.ToShortDateString() + " " + DefaultNameForFileSaving;
            }

            return fname;
        }

        /// <summary>
        /// сохранить файл безопасно, и если будет ошибка, то вывести диалог
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="fileName"></param>
        private void SaveDocumentDataWithSafe(XmlDocument doc, string fileName)
        {
            if (this.SaveDocumentData(doc, fileName) == false)
            {
                //ToDo не идеально, но нужно избавиться от MessageBox. Лучше сделать customную обработку ошибок и исключений и customnое логирование.
                MessageBox.Show(
                    $"Файл сохранен под названием [{fileName}] в текущей директории!",
                    "Ошибка сохранения файла",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }
    }
}