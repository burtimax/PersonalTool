using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiaryClassLibStandart.Class.IdeasClasses;
using DiaryWinFormsNetFramework.HelpersConstants;

namespace DiaryWinFormsNetFramework.UserControls
{
    public partial class IdeaListItem : UserControl
    {
        private Idea _idea;
        private string _title = "";
        private string _mark = "";

        public IdeaListItem()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {

        }

        public IdeaListItem(Idea idea) : this()
        {
            this._idea = idea;
        }


        public Idea Idea
        {
            get { return _idea; }
            set { _idea = value; }
        }

        /// <summary>
        /// Свойство (заголовок объекта (label.text))
        /// </summary>
        [Category("CustomProps")]
        public string TitleProp
        {
            get=>_title;
            set
            {
                if (Title != null)
                {
                    Title.Text = value;
                }

                _title = value;
            }
        }

        /// <summary>
        /// Оценка идеи (label.text)
        /// </summary>
        [Category("CustomProps")]
        public string MarkProp
        {
            get
            {
                if(_mark == "0")
                {
                    return null;
                }

                return _mark;
            } 
            set
            {
                if (Mark != null && value != "0")
                {
                    Mark.Text = value;
                }

                _mark = value;
            } 
        }

        /// <summary>
        /// Цвет пользовательского элемента
        /// </summary>
        [Category("CustomProps")]
        public Color BackColorProp{
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        /// <summary>
        /// Цвет для обозначения категории идеи (Section Color)
        /// </summary>
        [Category("CustomProps")]
        public Color SectionColorProp
        {
            get { return this.Mark.BackColor; }
            set { this.Mark.BackColor = value; }
        }

    }
}
