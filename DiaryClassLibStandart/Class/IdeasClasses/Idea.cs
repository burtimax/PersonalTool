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
        /// Сгенерировать Id
        /// </summary>
        /// <returns></returns>
        private string GenerateId()
        {
            return ((long)Math.Abs(DateTime.Now.GetHashCode()+this.GetHashCode())).ToString();
        }

        /// <summary>
        /// Id номер
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

        /// <summary>
        /// Использовать только для ручной установки Id
        /// </summary>
        /// <param name="Id"></param>
        public void SetId(string Id)
        {
            this.Id = Id;
        }

        /// <summary>
        /// Использовать только для ручной установки времени
        /// </summary>
        /// <param name="time"></param>
        public void SetTime(string time)
        {
            if (DateTime.TryParse(time, out var t) == false)
            {
                throw new Exception("Ошибка преобразования из string в DateTime ["+time+"]");
            }

            this.Time = t;
        }

        /// <summary>
        /// Использовать только для ручной установки времени
        /// </summary>
        /// <param name="time"></param>
        public void SetTime(DateTime time)
        {
            this.Time = time;
        }

    }

    public enum IdeaSections
    {
        Underfined,
        All,
        Life,
        Productivity,
        Business,
        Creativity,
        Other
    }
}