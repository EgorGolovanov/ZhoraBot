using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Contest
    {
        public Guid Id { get; set; }
        public string ContestName { get; set; }
        public string Rules { get; set; }
        public int? Time { get; set; }
        public int? Bank { get; set; }
        public Guid? SubjectId { get; set; }

        public virtual Content IdNavigation { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
