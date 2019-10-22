using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase.Interface
{
    /// <summary>
    /// интерфейс описывающий структуру рабочего дня
    /// </summary>
    public interface IWorkTime
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// дата начала рабочего дня
        /// </summary>
        DateTime StartWork { get; set; }
        /// <summary>
        /// дата конца рабочего дня
        /// </summary>
        DateTime EndWork { get; set; }
    }
}
