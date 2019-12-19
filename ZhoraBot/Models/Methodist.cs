using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Methodist
    {
        public Methodist()
        {
            Homework = new HashSet<Homework>();
        }

        public Guid Id { get; set; }
        public string DiscordName { get; set; }

        public virtual ICollection<Homework> Homework { get; set; }
    }
}
