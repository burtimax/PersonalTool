using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DiaryClassLibStandart.Class.Basic
{
    public class CustomDialogResult
    {
        public CustomDialogResult(DialogResult res)
        {
            this.Status = res;
        }

        public CustomDialogResult(DialogResult res, string value)
        {
            this.Status = res;
            this.Value = value;
        }

        public DialogResult Status;
        public string Value = null;

        /*public void Dispose()
        {
            this.Value = null;
            this.Status = default(DialogResult);
        }*/
    }
}
