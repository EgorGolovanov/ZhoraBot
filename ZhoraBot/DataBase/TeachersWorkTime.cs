﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий рабочий день для преподавателей
    /// </summary>
    public class TeachersWorkTime// : IWorkTime
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// преподаватель
        /// </summary>
        public Teacher Teacher { get; set; }

    }
}
