using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий роли пользователей
    /// </summary>
    public class Role
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// название роли
        /// </summary>
        public string RoleName { get; set; }


        public bool Administrator { get; set; }
    }
}
