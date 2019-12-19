using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Content
    {
        public Guid Id { get; set; }
        public string SourcePath { get; set; }
        public string AnswerPath { get; set; }
        public string ContentType { get; set; }

        public virtual Subject IdNavigation { get; set; }
        public virtual Contest Contest { get; set; }
        public virtual Homework Homework { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
