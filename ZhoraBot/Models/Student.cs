using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Student
    {
        public Guid Id { get; set; }
        public string DiscordName { get; set; }
        public double? Money { get; set; }
        public double? ExperiencePoints { get; set; }
        public string ContactInfo { get; set; }
        public int? RatingPosition { get; set; }
        public Guid? SubjectId { get; set; }
        public Guid? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
