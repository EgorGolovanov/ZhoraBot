using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий пользователя "подписчик"
    /// </summary>
    public class Subscriber :IUser
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// роль подписчика
        /// </summary>
        public Role Role { get; set; }
        /// <summary>
        /// имя подписчика
        /// </summary>
        public string DiscordName { get; set; }
    }
}
