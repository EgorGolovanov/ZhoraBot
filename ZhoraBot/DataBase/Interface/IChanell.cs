using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase.Interface
{
    /// <summary>
    /// интерфейс, представляющий структуру канала
    /// </summary>
    public interface IChanell
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// название канала
        /// </summary>
        string ChanellName { get; set; }
        /// <summary>
        /// список ролей доступных для канала
        /// </summary>
        List<Role> Roles { get; set; }
        /// <summary>
        /// список команд доступных для канала
        /// </summary>
        List<Command> Commands { get; set; }
    }
}
