using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий контент для учебных занятий
    /// </summary>
    public class ClassWorkContent : IContent
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// путь к файлу для учебного контента
        /// </summary>
        public string File { get; set; }
        
        /// <summary>
        /// имя файла для учебного контента
        /// </summary>
        public string FileName { get; set; }
    }
}
