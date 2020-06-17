using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace DiaryClassLibStandart.Class
{
    public static class Settings
    {
        public static readonly string SettingsDirectory = "SettingsDirectory";
        public static readonly string StoryDirectory = "StoryDirectory";
        public static readonly string IdeasDirectory = "IdeasDIrectory";
        public static readonly string ProjectsDirectory = "ProjectsDirectory";


        readonly static string DirectorySettingsFile = Directory.GetCurrentDirectory();
        readonly static string SettingFileName = "settings";
        readonly static string FileExtension = ".xml";
        static string Path
        {
            get
            {
                return DirectorySettingsFile + @"\" + SettingFileName + FileExtension;
            }
           
        }
       


    
        static SettingItem Password;

        public static string GetSetting(string settingName)
        {
            object locker = new object();
            lock (locker)
            {
                XmlDocument xDoc = new XmlDocument();
                if(File.Exists(Path) == false)
                {
                    CreateXmlFile();
                }
                xDoc.Load(Path);
                XmlElement root = xDoc.DocumentElement;                   
                return FindSetting(xDoc, root, new SettingItem(settingName))?.Value;
            }; 
        }

        private static SettingItem FindSetting (XmlDocument doc, XmlElement root, SettingItem item)
        {      

            foreach(XmlNode node in root)
            {
                if (node.Name == item.ElementName)
                {
                    SettingItem resItem = new SettingItem(node.Name);
                    resItem.Value = node.InnerText;
                    return resItem;
                }  
            }
            return null;
        }

        public static void SetSetting(string settingName, string value)
        {          
            if (File.Exists(Path) == false)
            {
                CreateXmlFile();
            }

            XmlDocument xDoc = new XmlDocument();
            XmlElement root;
            xDoc.Load(Path);
            root = xDoc.DocumentElement;

            var foundSetting = FindSetting(xDoc, root, new SettingItem(settingName));
            
            var newSetting = new SettingItem(settingName);
            newSetting.Value = value;
            
            if (foundSetting != null)
            {
                if(value != foundSetting.Value)
                {                                   
                    ChangeSettingValue(xDoc, root, newSetting);
                    return;
                }
            }
            else
            {
                AddSettingValue(xDoc, root, newSetting);
            }

        }

        /// <summary>
        /// Меняет значение существующей настройки на значение новой настройки
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="root"></param>
        /// <param name="item"></param>
        private static void ChangeSettingValue(XmlDocument doc,XmlElement root, SettingItem item)
        {
            bool foundExistXmlElement = false;
            foreach(XmlNode node in root)
            {
                if(node.Name == item.ElementName)
                {
                    root.RemoveChild(node);
                    foundExistXmlElement = true;
                    break;
                }
            }
            if (foundExistXmlElement)
            {
                AddSettingValue(doc, root, item);
            }       
        }

        private static void AddSettingValue(XmlDocument doc, XmlElement root, SettingItem item)
        {
            XmlElement newSetting = doc.CreateElement(item.ElementName);
            newSetting.AppendChild(doc.CreateTextNode(item.Value));
            root.AppendChild(newSetting);
            doc.Save(Path);
        }

        private static void CreateXmlFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateElement("Root"));
            doc.Save(Path);
        }

    }
}
