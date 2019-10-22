﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий рабочий день для наставников
    /// </summary>
    public class MentorsWorkTime : IWorkTime
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// наставник
        /// </summary>
        public Mentor Mentor { get; set; }
        /// <summary>
        /// начало рабочего дня
        /// </summary>
        public DateTime StartWork { get; set; }
        /// <summary>
        /// конец рабочего дня
        /// </summary>
        public DateTime EndWork { get; set; }
    }
}
