using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий розыгрыш призов
    /// </summary>
    public class Lottery
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// список ролей для учатия в лотерее
        /// </summary>
        public List<Role> Roles { get; set; }
        /// <summary>
        /// приз лотереи
        /// </summary>
        public string Prize { get; set; }
    }
}
