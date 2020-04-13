using DiaryClassLibStandart.Class;
using DiaryClassLibStandart.Helpers;
using DiaryWinFormsNetFramework.HelpersConstants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DiaryWinFormsNetFramework.View
{
    public partial class DiaryForm
    {
        //Папка для записей
        string storyDirectory;
        readonly string extension = ".xml";
        private readonly string filePattern = "*N-?????*.*";
        Regex fileNumberDiaryRegex = new Regex(@"N-(?<Number>\d{5})\s*");
        Regex fileDateDiaryRegex = new Regex(@"(?<Date>\s\d{1,2}.\d{1,2}.\d{4}\s)");


        protected override void ReceiveData(object data)
        {
            if (data == null) return;      
            base.ReceiveData(data);
        }


        /// <summary>
        /// Поиск последней записи в папке
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        private string GetLastDiaryFilePath(string dir)
        {
            var files = GetDiaryFiles(dir);
            if (files == null) return null;
            //все номера файлов неотрицательные, поэтому задаем -1
            int max = -1;
            string maxPath = null;
            foreach(var f in files)
            {
                GetDateNumberFromFilePath(f, out var fileNum, out var date);

                if(fileNum != null && fileNum>max)
                {
                    max = (int)fileNum;
                    maxPath = f;
                }
            }

            return maxPath;        
        }

        /// <summary>
        /// Получить список всех файлов (по маске)
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        List<string> GetDiaryFiles(string dir = null)
        {
            if (dir == null && storyDirectory != null)
            {
                dir = storyDirectory;
            }

            if(Directory.Exists(dir) == false)
            {
                return null;
            }
            return Directory.GetFiles(dir, filePattern, SearchOption.TopDirectoryOnly).ToList<string>();
        }

        /// <summary>
        /// Получить имена файлов дневника из директории историй (использую для listBox)
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        List<string> GetDiaryFilesNames(string dir = null)
        {
            if (dir == null && storyDirectory != null)
            {
                dir = storyDirectory;
            }

            var docs = GetDiaryFiles(dir);
            if (docs == null || docs.Count == 0) return null;

            for(var i = 0; i< docs.Count; i++)
            {
                HelperFileName.ParsePath(docs[i], out var _, out var fname, out var __);
                docs[i] = fname;
            }
            return docs;
        }


        /// <summary>
        /// Получить число (порядок записи из строки имени файла) и дату из имени файла.
        /// </summary>
        /// <param name="pathFile"></param>
        /// <returns></returns>
        void GetDateNumberFromFilePath(string pathFile, out int? number, out DateTime? date)
        {
            number = null;
            date = null;
            if (pathFile == null) return;
            var matchNumber = fileNumberDiaryRegex.Match(pathFile);
            if (matchNumber.Success)
            {
                var strNum = matchNumber.Groups["Number"].Value.TrimStart(' ', '0');
                //первая запись начнется с номера 0, поэтому обработаем исключение.
                if (string.IsNullOrEmpty(strNum))
                {
                    strNum = "0";
                }

                if(int.TryParse(strNum, out var num))
                {
                    number = num;
                }          
            }

            var matchDate = fileDateDiaryRegex.Match(pathFile);
            if (matchDate.Success)
            {
                var strDate = matchDate.Groups["Date"].Value.Trim(' ');
                date = Convert.ToDateTime(strDate);
            }
        }

        /// <summary>
        /// Формируем имя файла по паттерну, генерируем имя файла. Учитываем дату файла.
        /// </summary>
        /// <param name="fileNumber"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        string GetFileNameForSaving(string title)
        {
            //Инициализируем переменные
            string dir = storyDirectory;
            string res = dir + @"\";
            string strNum = "";
            var nowDate = DateTime.Now;
            int fileNumber = 0;
            
            //Проверяем есть ли уже документы с такой-же датой
            var lastFilePath = GetLastDiaryFilePath(storyDirectory);
            GetDateNumberFromFilePath(lastFilePath, out var lastFileNumber, out var lastFileDate);

            //Если последний файл был создан в текущем дне, то возьмем номер файла у него, так как для каждого дня отдельный номер, отдельный файл
            if (lastFileNumber.HasValue)
            {
                //если в текущем дне уже был создан файл, то укажем его номер
                if (lastFileDate.HasValue &&
                    nowDate.Date == ((DateTime)lastFileDate).Date)
                {
                    fileNumber = ((int)lastFileNumber);
                }
                //не нашли в текущем дне файла, укажем номер (последнего файла + 1)
                else
                {
                    fileNumber = (int)lastFileNumber + 1;
                }
            }
            //Делаем пятизначное число с лидирующими нулями
            for(var i = 0; i < 5; i++)
            {
                strNum = strNum.Insert(0, (fileNumber % 10).ToString());
                fileNumber /= 10;
            }
            //формируем строку.
            res += $"N-{strNum} {DateTime.Now.Date.ToShortDateString()}";
            if (string.IsNullOrEmpty(title) == false)
            {
                res += $" {{{title}}}";
            }

            res += extension;
            return res;
        }


        /// <summary>
        /// Определяет есть ли файл для текущего дня
        /// </summary>
        /// <param name="pathCurrentFile"></param>
        /// <returns></returns>
        bool HasFileForCurrentDate(out string pathCurrentFile)
        {
            pathCurrentFile = null;
            var dir = storyDirectory;
            var path = GetLastDiaryFilePath(dir);
            GetDateNumberFromFilePath(path, out var num, out var date);
            if (date.HasValue && DateTime.Now.Date == ((DateTime)date).Date)
            {
                pathCurrentFile = path;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Возвращаем полный путь к файлу истории по имени файла
        /// </summary>
        string GetFullPathStoryFileByFileName(string filename)
        {
            var searchPattern = "*" + filename + "*";
            return Directory.GetFiles(storyDirectory, searchPattern, SearchOption.TopDirectoryOnly).FirstOrDefault();
        }





    }
}
