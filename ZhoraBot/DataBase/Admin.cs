using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий пользователя "администратор"
    /// </summary>
    public class Admin : IUser
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя администратора
        /// </summary>
        public string DiscordName { get; set; }
        /// <summary>
        /// роль администратора
        /// </summary>
        public Role Role { get; set; }
    }
}
