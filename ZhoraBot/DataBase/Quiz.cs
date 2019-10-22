using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий обычную предметную викторину
    /// </summary>
    public class Quiz
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// список ролей доступных для данной викторины
        /// </summary>
        public List<Role> Roles { get; set; }
        /// <summary>
        /// название викторины
        /// </summary>
        public string QuizName { get; set; }
        /// <summary>
        /// правила викторины
        /// </summary>
        public string Rules { get; set; }
        /// <summary>
        /// контент для викторины
        /// </summary>
        public List<QuizContent> Content { get; set; }
        /// <summary>
        /// время на ответ
        /// </summary>
        public TimeSpan Time { get; set; }
        /// <summary>
        /// список ответов на викторину
        /// </summary>
        public List<AnswersForContent> AnswerList { get; set; }
    }
}
