using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryClassLibStandart.Class.TaskClass;

namespace DiaryWinFormsNetFramework.UserControls
{
    public partial class ProjectItem : UserControl
    {
        public MyProject Project { get; set; }


        public ProjectItem(string name)
        {
            InitializeComponent();
            Init(name);
        }

        /// <summary>
        /// Initialize object
        /// </summary>
        /// <param name="name"></param>
        private void Init(string name)
        {
            this.Project = new MyProject(name);
            this.NameTxt.Text = name;
        }


    }
}
