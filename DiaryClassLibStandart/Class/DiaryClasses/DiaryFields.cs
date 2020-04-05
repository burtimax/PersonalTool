using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Class
{
    public class DiaryFields 
    {

        private string _title = "Title";
        private string _story = "Story";
        private string _notes = "Notes";
        private string _ideas = "Ideas";
        private string _achievements = "Achievements";

        public TextField FileName;
        public TextField Title;
        public TextField Story;
        public TextField Notes;
        public TextField Ideas;
        public TextField Achievements;

        public DiaryFields()
        {
            InitData();
        }

        private void InitData()
        {
            this.Title = new TextField(_title);
            this.Notes = new TextField(_notes);
            this.Story = new TextField(_story);
            this.Ideas = new TextField(_ideas);
            this.Achievements = new TextField(_achievements);
        }
    }
}
