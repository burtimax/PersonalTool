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

        /// <summary>
        /// Изменяем данные идеи в документе
        /// </summary>
        public void ChangeIdea(Idea idea)
        {
            var xmlIdea = SearchIdeaXmlDocument(idea);

            //Если не нашли идею в документе, то создадим её и добавим в документ
            if(xmlIdea == null)
            {
                this.AddIdea(idea);
            }
            //Если нашли идею, то сделаем изменения 
            else
            {
                IdeaXmlPresenter.ChangeDataInXmlIdea(ref xmlIdea, idea);
            }
            this.Doc.Save();
        }

        public void DeleteIdea(Idea idea)
        {
            var xmlIdea = SearchIdeaXmlDocument(idea);
            if (xmlIdea == null) return;

            this.Doc.Body.RemoveChild(xmlIdea);
            this.Doc.Save();
        }

        /// <summary>
        /// Список всех идеи в документе
        /// </summary>
        /// <returns></returns>
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



        /// <summary>
        /// Поиск елемента xml (<Idea>) для idea
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="idea"></param>
        /// <returns></returns>
        private XmlElement SearchIdeaXmlDocument(Idea idea)
        {
            //Ищем элемент с атрибутом равным Id идеи
            var res = this.Doc.Body.SelectSingleNode("Idea[@Id='" + idea.Id + "']");
            if (res == null || (res is XmlElement == false))
            {
                return null;
            }

            return res as XmlElement;
        }


    }
}
