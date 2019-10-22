using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий discord команды
    /// </summary>
    public class Command
    {
        /// <summary>
        /// идентификотор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// список ролей доступных для команды
        /// </summary>
        public List<Role> Roles { get; set; }
        /// <summary>
        /// название команды
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// описание действий для команды
        /// </summary>
        public string Overview { get; set; }
    }
}
