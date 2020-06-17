using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DiaryClassLibStandart.Class.IdeasClasses
{
    public class IdeaXmlPresenter
    {
        /// <summary>
        /// Представляем объект Idea в виде XML элемента
        /// </summary>
        /// <param name="idea"></param>
        /// <returns>Возвращает Xml элемент идеи</returns>
        public static XmlNode GetXmlByIdea(XmlDocument doc, Idea idea)
        {
            XmlAttribute ideaAttribute = doc.CreateAttribute("Id");
            ideaAttribute.InnerText = idea.Id;

            XmlElement titleElement = doc.CreateElement("Title");
            XmlText titleElementText = doc.CreateTextNode(idea.Title);
            titleElement.AppendChild(titleElementText);

            XmlElement timeElement = doc.CreateElement("Time");
            XmlText timeElementText = doc.CreateTextNode(idea.Time.ToString());
            timeElement.AppendChild(timeElementText);

            XmlElement markElement = doc.CreateElement("Mark");
            XmlText markElementText = doc.CreateTextNode(idea.Mark.ToString());
            markElement.AppendChild(markElementText);

            XmlElement sectionElement = doc.CreateElement("Section");
            XmlText sectionElementText = doc.CreateTextNode(idea.Section);
            sectionElement.AppendChild(sectionElementText);

            XmlElement descElement = doc.CreateElement("Description");
            XmlText descElementText = doc.CreateTextNode(idea.Description);
            descElement.AppendChild(descElementText);

            XmlElement ideaElement = doc.CreateElement("Idea");
            ideaElement.Attributes.Append(ideaAttribute);
            ideaElement.AppendChild(titleElement);
            ideaElement.AppendChild(timeElement);
            ideaElement.AppendChild(markElement);
            ideaElement.AppendChild(sectionElement);
            ideaElement.AppendChild(descElement);

            return ideaElement;
        }

        public static Idea GetIdeaByXml(XmlElement xml)
        {
            Idea idea = new Idea();

            idea.SetId(xml.Attributes["Id"].InnerText);
            idea.SetTime(xml.GetElementsByTagName("Time")?.Item(0).InnerText);
            idea.Title = xml.GetElementsByTagName("Title")?.Item(0)?.InnerText;
            idea.Mark = Convert.ToInt32(xml.GetElementsByTagName("Mark")?.Item(0)?.InnerText);
            idea.Description = xml.GetElementsByTagName("Description")?.Item(0)?.InnerText;
            idea.Section = xml.GetElementsByTagName("Section")?.Item(0).InnerText;

            return idea;
        }

        public static void ChangeDataInXmlIdea(ref XmlElement xmlIdea, Idea idea)
        {
            if (xmlIdea == null || idea == null) return;
            if (xmlIdea.Name != "Idea")
            {
                throw new Exception("Передан элемент не принадлежащий <Idea>");
            }

            XmlAttribute id = xmlIdea.Attributes["Id"];
            id.InnerText = idea.Id;

            if (xmlIdea.GetElementsByTagName("Title")?.Item(0) is XmlElement title) title.InnerText = idea.Title;

            if (xmlIdea.GetElementsByTagName("Mark")?.Item(0) is XmlElement mark) mark.InnerText = idea.Mark.ToString();

            if (xmlIdea.GetElementsByTagName("Section")?.Item(0) is XmlElement section) section.InnerText = idea.Section;
           
            if (xmlIdea.GetElementsByTagName("Description")?.Item(0) is XmlElement desc) desc.InnerText = idea.Description;

            if (xmlIdea.GetElementsByTagName("Time")?.Item(0) is XmlElement time) time.InnerText = idea.Time.ToString();
            
        }
    }
}