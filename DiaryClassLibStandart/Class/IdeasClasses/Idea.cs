using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassLibStandart.Class.IdeasClasses
{
    public class Idea
    {
        private string _id;
        private string _title;
        private DateTime _time;
        private int _mark;
        private string _section;
        private string _description;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Idea()
        {
            Time = DateTime.Now;
            Id = GenerateId();
        }

        /// <summary>
        /// Сгенерировать ID
        /// </summary>
        /// <returns></returns>
        private string GenerateId()
        {
            return DateTime.Now.Ticks.ToString();
        }

        /// <summary>
        /// ID номер
        /// </summary>
        public string Id
        {
            get => _id;
            private set => _id = value;
        }

        /// <summary>
        /// Заголовок идеи
        /// </summary>
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        /// <summary>
        /// Время создания идеи
        /// </summary>
        public DateTime Time
        {
            get => _time;
            private set => _time = value;
        }

        /// <summary>
        /// Оценка идеи
        /// </summary>
        public int Mark
        {
            get => _mark;
            set => _mark = value;
        }

        /// <summary>
        /// Раздел для идеи
        /// </summary>
        public String Section
        {
            get => _section;
            set => _section = value;
        }

        /// <summary>
        /// Описание по реализации или представления идеи
        /// </summary>
        public string Description
        {
            get => _description;
            set => _description = value;
        }



    }

    public enum IdeaSections
    {
        All,
        Life,
        Productivity,
        Business,
        Creativity,
        Other
    }
}