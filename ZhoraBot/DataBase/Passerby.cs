using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий пользователя "прохожий"
    /// </summary>
    public class Passerby : IUser
    {
        /// <summary>
        /// идентификатор 
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя "прохожего"
        /// </summary>
        public string DiscordName {get;set;}
        /// <summary>
        /// роль "прохожего"
        /// </summary>
        public Role Role { get; set; }
    }
}
