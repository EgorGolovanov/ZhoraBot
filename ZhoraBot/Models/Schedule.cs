using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Schedule
    {
        public Guid Id { get; set; }
        public DateTime? Time { get; set; }
        public string ContentType { get; set; }

        public virtual Student IdNavigation { get; set; }
    }
}
