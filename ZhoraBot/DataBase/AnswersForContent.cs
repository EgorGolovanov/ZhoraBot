using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс реализующий ответы к контенту
    /// </summary>
    public class AnswersForContent
    {
        /// <summary>
        /// идентификартор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// название файла вопроса
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// ответ на вопрос
        /// </summary>
        public string Answer { get; set; }
    }
}
