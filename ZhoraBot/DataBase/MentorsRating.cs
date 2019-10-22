using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;
namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий рейтинговую таблицу наставников
    /// </summary>
    public class MentorsRating : IRating<Mentor>
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// список наставников
        /// </summary>
        public List<Mentor> RatingList { get; set; }
        /// <summary>
        /// позиция в рейтинге
        /// </summary>
        public int PositionOfRating { get; set; }
        
    }
}
