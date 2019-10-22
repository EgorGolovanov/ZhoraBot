using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий контент для простой предметной викторины
    /// </summary>
    public class QuizContent : IContent
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// путь к файлу для вопроса викторины
        /// </summary>
        public string File { get; set; }
        /// <summary>
        /// имя файла вопроса викторины
        /// </summary>
        public string FileName { get; set; }
    }   
}
