using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace DiaryClassLibStandart.Class.TaskClass
{
    public class ProjectDoc
    {
        private MyXmlDocument Doc;

        private ProjectDoc()
        {
        }

        public ProjectDoc(string path):this()
        {
            this.Doc = new MyXmlDocument(path);
            this.Doc.Open();
        }

        public ProjectDoc(string directory, string fileName):this()
        {
            this.Doc = new MyXmlDocument(directory, fileName);
            this.Doc.Open();
        }

        public void SaveProject(MyProject proj)
        {
            var XmlProject = MyTaskXmlPresenter.GetXmlFromMyProject(this.Doc.Doc, proj);   

            if(this.Doc == null || this.Doc.Body == null)
            {
                this?.Doc?.InitDocAndBodyIfNeed();
            }
            
            this.Doc.Body.RemoveAll();
            this.Doc.Body.AppendChild(XmlProject);
            this.Doc.Save();
        }
        
        //public MyProject GetProjectItem()
        //{
        //    return MyTaskXmlPresenter.GetMyProjectFromXmlElement(
        //        this.Doc.Body.GetElementsByTagName("Project")?.Item(0) as XmlElement);

        //}

        public bool GetProjectItem(ref MyProject proj)
        {
            if (File.Exists(this.Doc.Path) == false) return false;

            return MyTaskXmlPresenter.GetMyProjectFromXmlElement(ref proj,
                this?.Doc?.Body?.GetElementsByTagName("Project")?.Item(0) as XmlElement);
        }

    }
}
