using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий сложную предметную викторину
    /// </summary>
    public class Contest
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// название конкурса
        /// </summary>
        public string ContestName { get; set; }
        /// <summary>
        /// правила конкурса
        /// </summary>
        public string Rules { get; set; }
        /// <summary>
        /// контент для конкурса 
        /// </summary>
        public List<ContestContent> Content { get; set; }
        /// <summary>
        /// время ответа на вопрос
        /// </summary>
        public TimeSpan Time { get; set; }
        /// <summary>
        /// список ответов для конкурса
        /// </summary>
        public List<AnswersForContent> AnswerList { get; set; }
        /// <summary>
        /// список победителей
        /// </summary>
        public List<Student> ChampionList { get; set; }
        /// <summary>
        /// банк конкурса (сколько валюты получают победители)
        /// </summary>
        public int Bank { get; set; }
    }
}
