using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Class
{
    public class TextField
    {
         
        string _text;

        public string FieldName;

        public TextField(string FieldName)
        {
            this.FieldName = FieldName;
        }

        public string Text { get => _text; set => _text = value; }

        public void Write(string text)
        {
            this.Text += text;
        }

        public void WriteLine(string text)
        {
            this.Text += text + "\n";
        }
    }
}
