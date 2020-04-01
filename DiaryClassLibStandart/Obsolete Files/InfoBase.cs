using DiaryClassLibStandart.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Abstract
{
    public abstract class InfoBase
    {
        DateTime _dateTime;
        TextField _title;
        TextField _mainText;
        TextField _notes;
        TextField _insights;

        public InfoBase()
        {
            
        }


        public virtual DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        public TextField Title { get => _title; set => _title = value; }
        public TextField MainText { get => _mainText; set => _mainText = value; }
        public TextField Notes { get => _notes; set => _notes = value; }
        public TextField Insights { get => _insights; set => _insights = value; }



    }
}
