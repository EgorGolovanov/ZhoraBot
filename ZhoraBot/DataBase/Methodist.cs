﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий пользователя "методист"
    /// </summary>
    public class Methodist : IUser
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя методиста
        /// </summary>
        public string DiscordName { get; set; }
        /// <summary>
        /// роль методиста
        /// </summary>
        public Role Role { get; set; }
    }
}
