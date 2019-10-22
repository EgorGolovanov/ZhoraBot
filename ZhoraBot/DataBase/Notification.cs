using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий структуру уведомлений
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// время для оповещения
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// текст оповещения
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// список ролей для оповещения (тех, кого надо оповестить)
        /// </summary>
        public List<Role> Roles { get; set; }
    }
}
