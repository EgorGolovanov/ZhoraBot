using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Homework
    {
        public Guid Id { get; set; }
        public Guid? MethodistId { get; set; }
        public Guid? SubjectId { get; set; }

        public virtual Content IdNavigation { get; set; }
        public virtual Methodist Methodist { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
