using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий расписание для бесплатного контента
    /// </summary>
    public class FreeContentSchedule
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// расписание бесплатного контента
        /// </summary>
        public Schedule Schedule { get; set; }
    }
}
