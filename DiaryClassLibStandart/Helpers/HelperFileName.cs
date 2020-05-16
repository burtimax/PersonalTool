using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Helpers
{
    /// <summary>
    /// dir - директория без конечного слэша,
    /// filename - имя файла без начального и конечного слэша,
    /// extension - расширение с начальной точкой
    /// </summary>
    public static class HelperFileName
    {
        public static void ParsePath(string path, out string dir, out string filename, out string extension)
        {
            dir = null;
            filename = null;
            extension = null;
            if (string.IsNullOrEmpty(path)) return;

            path = path.Trim();
            path = path.Replace("\\", @"\");
            int lastIndexSlash = path.LastIndexOf(@"\");
            int lastIndexDot = path.LastIndexOf('.');
            dir = path.Substring(0, lastIndexSlash);
            filename = path.Substring(lastIndexSlash + 1, lastIndexDot - lastIndexSlash-1);
            extension = path.Substring(lastIndexDot);
        }
    }
}
