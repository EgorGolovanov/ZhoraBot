using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Mentor
    {
        public Guid Id { get; set; }
        public string DiscordName { get; set; }
        public double? SummaryRating { get; set; }
        public int? VotedPeople { get; set; }
        public DateTime? StartWork { get; set; }
        public DateTime? EndWork { get; set; }
    }
}
