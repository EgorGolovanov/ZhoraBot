using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Quiz
    {
        public Guid Id { get; set; }
        public string QuizName { get; set; }
        public string Rules { get; set; }
        public int? Time { get; set; }
        public Guid? SubjectId { get; set; }

        public virtual Content IdNavigation { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
