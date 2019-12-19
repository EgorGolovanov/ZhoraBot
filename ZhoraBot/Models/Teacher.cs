using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Teacher
    {
        public Guid Id { get; set; }
        public string DiscordName { get; set; }
        public string ContactInfo { get; set; }
        public DateTime? StartWork { get; set; }
        public DateTime? EndWork { get; set; }
        public Guid? RoleId { get; set; }

        public virtual Subject IdNavigation { get; set; }
        public virtual Role Role { get; set; }
    }
}
