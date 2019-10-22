using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий расписание занятий для учеников
    /// </summary>
    public class StudentsSchedule
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// список учеников
        /// </summary>
        public List<Student> Students { get; set; }
        /// <summary>
        /// расписание для учеников
        /// </summary>
        public Schedule Schedule { get; set; }
    }
}
