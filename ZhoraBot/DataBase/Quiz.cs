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
    //    public Content Content { get; set; }
        
        /// <summary>
        /// время на ответ
        /// </summary>
        public int Time { get; set; }

    }
}
