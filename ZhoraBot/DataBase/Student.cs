using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий пользователя "ученик"
    /// </summary>
    public class Student : IUser
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя ученика
        /// </summary>
        public string DiscordName { get; set; }
        /// <summary>
        /// список курсов на которых обучается
        /// </summary>
        public List<Course> Courses { get; set; }
        /// <summary>
        /// награды ученика (деньги)
        /// </summary>
        public double Money { get; set; }
        /// <summary>
        /// очки опыта
        /// </summary>
        public double ExperiencePoints { get; set; }
        /// <summary>
        /// контактная информация
        /// </summary>
        public string ContactInfo { get; set; }
        /// <summary>
        /// рейтинг для оценки учеников
        /// </summary>
        public StudentsRating Rating { get; set; }
        /// <summary>
        /// роль ученика
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// позиция в рейтинге
        /// </summary>
        public int PositionOfRating { get; set; }
        /// <summary>
        /// расписание для учеников
        /// </summary>
        public Schedule Schedule { get; set; }
    }
}
