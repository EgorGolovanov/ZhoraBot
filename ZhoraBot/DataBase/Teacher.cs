using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SchoolApplication.DataBase.Interface;
namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий пользователя "преподаватель"
    /// </summary>
    public class Teacher : IUser
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя преподавателя
        /// </summary>
        public string DiscordName { get; set; }
        /// <summary>
        /// список курсов которые ведет преподаватель
        /// </summary>
        public List<Course> Courses { get; set; }
        /// <summary>
        /// контактная информация
        /// </summary>
        public string ContactInfo { get; set; }
        /// <summary>
        /// роль преподавателя
        /// </summary>
        public Role Role { get; set; }
    }
}
