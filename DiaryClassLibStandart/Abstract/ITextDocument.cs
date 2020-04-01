using DiaryClassLib.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Abstract
{
    public interface ITextDocument: IDocument
    {
        void Write(string data);

        void WriteLine(string data);

        string ReadLine();

        string ReadAllData();
    }
}
