using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий структуру домашнего задания
    /// </summary>
    public class Homework
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// методист, составивший домашнюю работу
        /// </summary>
        public Methodist Methodist { get; set; }
        /// <summary>
        /// контент к домашней работе
        /// </summary>
        public List<HomeworkContent> HomeworkContent { get; set; }
        /// <summary>
        /// ответы к домашней работе
        /// </summary>
        public List<AnswersForContent> AnswerList { get; set; }
    }
}
