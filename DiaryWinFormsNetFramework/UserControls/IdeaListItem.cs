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

            this.Dock = DockStyle.Top;
            
        }

        public IdeaListItem(Idea idea) : base()
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
        public string MarkProp
        {
            get => _mark;
            set
            {
                if (Mark != null)
                {
                    Mark.Text = value;
                }

                _mark = value;
            } 
        }

        /// <summary>
        /// Цвет пользовательского элемента
        /// </summary>
        public Color ColorProp{
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
       
    }
}
