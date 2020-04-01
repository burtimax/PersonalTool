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
        private readonly string filePattern = "*N-????? *.*";
        Regex fileDiaryRegex = new Regex(@"N-(?<Number>\d{5})\s");


        private string GetLastDiaryFilePath(string dir)
        {
            var files = GetDiaryFiles(dir);
            int max = 0;
            string maxPath = null;
            foreach(var f in files)
            {
                int? fileNum = GetNumberFromFilePath(f);

                if(fileNum != null && fileNum>max)
                {
                    max = (int)fileNum;
                    maxPath = f;
                }
            }

            return maxPath;        
        }

        List<string> GetDiaryFiles(string dir)
        {
            return Directory.GetFiles(dir, filePattern, SearchOption.TopDirectoryOnly).ToList<string>();
        }

        int? GetNumberFromFilePath(string pathFile)
        {
            var match = fileDiaryRegex.Match(pathFile);
            if (match.Success)
            {
                var strNum = match.Groups["Number"].Value.TrimStart(' ', '0');
                if(int.TryParse(strNum, out var num))
                {
                    return num;
                }
                return null; 
            }
            return null;
        }

    }
}
