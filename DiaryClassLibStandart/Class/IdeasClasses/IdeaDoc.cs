using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Microsoft.Office.Interop.Word;

namespace DiaryClassLibStandart.Class.IdeasClasses
{
    public class IdeaDoc
    {
        private MyXmlDocument Doc;

        /// <summary>
        /// Конструктор
        /// </summary>
        private IdeaDoc()
        {

        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public IdeaDoc(string path):this()
        {
            this.Doc = new MyXmlDocument(path);
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public IdeaDoc(string directory, string filename):this()
        {
            this.Doc = new MyXmlDocument(directory, filename);
            this.Doc.Open();
        }

        /// <summary>
        /// Добавить идею в файл идей
        /// </summary>
        /// <param name="idea"></param>
        public void AddIdea(Idea idea)
        {
            var XmlIdea = IdeaXmlPresenter.GetXmlByIdea(this.Doc.Doc, idea);
            this.Doc.Body.AppendChild(XmlIdea);
            this.Doc.Save();
        }

        public Dictionary<string, Idea> GetAllIdeas()
        {
            if (Doc?.Body == null) return null;

            Dictionary<string, Idea> result = new Dictionary<string, Idea>();
            foreach (XmlElement node in this.Doc.Body.ChildNodes)
            {
                if(node.Name == "Idea")
                {
                    Idea curIdea = IdeaXmlPresenter.GetIdeaByXml(node);
                    if (curIdea != null)
                    {
                        result.Add(curIdea.Id, curIdea);
                    }
                }
            }

            return result;
        }

        
    }
}
