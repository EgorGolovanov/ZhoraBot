using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий пользователя "наставник"
    /// </summary>
    public class Mentor : IUser
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя наставника
        /// </summary>
        public string DiscordName { get; set; }
        /// <summary>
        /// роль наставника
        /// </summary>
        public Role Role { get; set; }
        /// <summary>
        /// средняя оценка наставника (полученная от учеников)
        /// </summary>
        public double Rating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int VotedPeople { get; set; }

        /// <summary>
        /// начало рабочего дня
        /// </summary>
        public DateTime StartWork { get; set; }
        /// <summary>
        /// конец рабочего дня
        /// </summary>
        public DateTime EndWork { get; set; }
    }
}
