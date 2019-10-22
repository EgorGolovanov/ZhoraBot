using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// интерфейс описывающий структуру пользователя
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// имя пользователя
        /// </summary>
        string DiscordName { get; set; }
        /// <summary>
        /// роль пользователя
        /// </summary>
        Role Role { get; set; }
    }
}
