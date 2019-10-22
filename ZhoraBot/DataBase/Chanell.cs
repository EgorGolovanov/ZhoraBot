using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий представление канала
    /// </summary>
    public class Chanell : IChanell
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя канала
        /// </summary>
        public string ChanellName { get; set; }
        /// <summary>
        /// список ролей доступных для канала
        /// </summary>
        public List<Role> Roles { get; set; }
        /// <summary>
        /// список команд доступных для канала
        /// </summary>
        public List<Command> Commands { get; set; }
    }
}
