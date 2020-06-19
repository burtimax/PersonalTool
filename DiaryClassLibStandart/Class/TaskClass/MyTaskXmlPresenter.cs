using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DiaryClassLibStandart.Class.TaskClass
{
    public class MyTaskXmlPresenter
    {
        public static XmlElement GetXmlElementByMyTask(XmlDocument doc, MyTask task)
        {
            XmlElement res = doc.CreateElement("Task");

            //Task Id element
            XmlElement Id = doc.CreateElement("Id");
            XmlText textId = doc.CreateTextNode(task.Id.ToString());
            Id.AppendChild(textId);

            //Task CreateTime element
            XmlElement CreateTime = doc.CreateElement("CreateTime");
            XmlText textCreateTime = doc.CreateTextNode(task.CreateTime.ToString());
            CreateTime.AppendChild(textCreateTime);

            //Task Name element
            XmlElement Name = doc.CreateElement("Name");
            XmlText textName = doc.CreateTextNode(task.Name);
            Name.AppendChild(textName);

            XmlElement Reveal = doc.CreateElement("Reveal");
            XmlText textReveal = doc.CreateTextNode(task.Revealed.ToString());
            Reveal.AppendChild(textReveal);

            //Task Status element
            XmlElement Status = doc.CreateElement("Status");
            XmlText textStatus = doc.CreateTextNode(task.GetStatusString());
            Status.AppendChild(textStatus);

            //Task Level element
            XmlElement Level = doc.CreateElement("Level");
            XmlText textLevel = doc.CreateTextNode(task.Level.ToString());
            Level.AppendChild(textLevel);

            //Task SubTasks element
            XmlElement SubTasks = doc.CreateElement("SubTasks");


            res.AppendChild(Id);
            res.AppendChild(CreateTime);
            res.AppendChild(Name);
            res.AppendChild(Level);
            res.AppendChild(Status);
            res.AppendChild(Reveal);

            //Рекурсивно добавляем подзадачи
            foreach (var subTask in task.SubTasks)
            {
                SubTasks.AppendChild(MyTaskXmlPresenter.GetXmlElementByMyTask(doc, subTask));
            }

            res.AppendChild(SubTasks);

            return res;
        }

        public static MyTask GetMyTaskByXmlElement(XmlElement elem)
        {
            string name = elem.GetElementsByTagName("Name")?.Item(0).InnerText;
            int level = Convert.ToInt32(elem.GetElementsByTagName("Level")?.Item(0)?.InnerText);

            MyTask res = new MyTask(name, level);
            res.CreateTime = Convert.ToDateTime(elem.GetElementsByTagName("CreateTime")?.Item(0)?.InnerText);
            res.Id = Convert.ToInt32(elem.GetElementsByTagName("Id")?.Item(0)?.InnerText);
            res.SetStatusByString(elem.GetElementsByTagName("Status")?.Item(0)?.InnerText);
            res.Revealed = Convert.ToBoolean(elem.GetElementsByTagName("Reveal")?.Item(0)?.InnerText);

            var subTasksElem = elem.GetElementsByTagName("SubTasks")?.Item(0);
            if (subTasksElem == null || subTasksElem.HasChildNodes == false) return res;

            //Рекурсивно преобразовываем подзадачи
            foreach (var subTaskElem in subTasksElem?.SelectNodes("Task"))
            {
                res.SubTasks.Add(MyTaskXmlPresenter.GetMyTaskByXmlElement(subTaskElem as XmlElement));
            }

            return res;
        }

        public static XmlElement GetXmlFromMyProject(XmlDocument doc, MyProject proj)
        {
            XmlElement res = doc.CreateElement("Project");

            //Project Id element
            XmlElement Id = doc.CreateElement("Id");
            XmlText textId = doc.CreateTextNode(proj?.Id?.ToString());
            Id.AppendChild(textId);

            //Project CreateTime element
            XmlElement CreateTime = doc.CreateElement("CreateTime");
            XmlText textCreateTime = doc.CreateTextNode(proj?.CreateTime.ToString());
            CreateTime.AppendChild(textCreateTime);

            //Task Name element
            XmlElement Name = doc.CreateElement("Name");
            XmlText textName = doc.CreateTextNode(proj?.Name);
            Name.AppendChild(textName);


            //Task Name element
            XmlElement Description = doc.CreateElement("Description");
            XmlText textDescription = doc.CreateTextNode(proj?.Description);
            Description.AppendChild(textDescription);

            XmlElement TaskRoot = null;
            if (proj?.TaskRoot != null)
                TaskRoot = MyTaskXmlPresenter.GetXmlElementByMyTask(doc, proj.TaskRoot);

            res.AppendChild(Id);
            res.AppendChild(CreateTime);
            res.AppendChild(Name);
            res.AppendChild(Description);

            if (TaskRoot != null)
                res.AppendChild(TaskRoot);

            return res;
        }


        //public static MyProject GetMyProjectFromXmlElement(XmlElement elem)
        //{
        //    MyProject proj = new MyProject("");
        //    if (MyTaskXmlPresenter.GetMyProjectFromXmlElement(ref proj, elem))
        //    {
        //        return proj;
        //    }

        //    return null;
        //}

        public static bool GetMyProjectFromXmlElement(ref MyProject proj, XmlElement elem)
        {
            if (elem == null) return false;
            if (elem.Name != "Project") return false;

            proj.Name = elem.GetElementsByTagName("Name")?.Item(0)?.InnerText;
            proj.Id = elem.GetElementsByTagName("Id")?.Item(0)?.InnerText;
            proj.CreateTime = Convert.ToDateTime(elem.GetElementsByTagName("CreateTime")?.Item(0)?.InnerText);
            proj.Description = elem.GetElementsByTagName("Description")?.Item(0)?.InnerText;

            proj.TaskRoot =
                MyTaskXmlPresenter.GetMyTaskByXmlElement(elem.GetElementsByTagName("Task")?.Item(0) as XmlElement);
            return true;
        }
    }
}
