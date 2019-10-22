using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий многопредметный учебный курс
    /// </summary>
    public class Course
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// название курса
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// список предметов для курса
        /// </summary>
        public List<Subject> Subjects { get; set; }
        /// <summary>
        /// преподаватель курса
        /// </summary>
        public Teacher Teacher { get; set; }

    }
}
