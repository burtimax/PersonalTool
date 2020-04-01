using DiaryClassLibStandart.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Class
{
    public class InfoDoc : InfoBase
    {
        public InfoDoc():base()
        {
        }

        public virtual DateTime DateTime { get => this.DateTime; set => this.DateTime = value; }
        public TextField Title { get => this.Title; set => this.Title = value; }
        public TextField MainText { get => this.MainText; set => this.MainText = value; }
        public TextField Notes { get => this.Notes; set => this.Notes = value; }
        public TextField Insights { get => this.Insights; set => this.Insights = value; }

    }
}
