using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий рейнговую таблицу учеников
    /// </summary>
    public class StudentsRating : IRating<Student>
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// позиция в рейтинге
        /// </summary>
        public int PositionOfRating { get; set; }
        /// <summary>
        /// список учеников
        /// </summary>
        public List<Student> RatingList { get; set; }
    }
}
