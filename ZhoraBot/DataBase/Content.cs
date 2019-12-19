using System;
using System.Collections.Generic;
using System.Text;

namespace ZhoraBot.DataBase
{
    public class Content
    {
        public Guid Id { get; set; }

        /// <summary>
        /// file with question
        /// </summary>
        public string SourcePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AnswersPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ContentType { get; set; }
    }
}
