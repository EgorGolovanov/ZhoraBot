using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Contest = new HashSet<Contest>();
            Homework = new HashSet<Homework>();
            Quiz = new HashSet<Quiz>();
            Student = new HashSet<Student>();
        }

        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public Guid? SubjectId { get; set; }

        public virtual Content Content { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Contest> Contest { get; set; }
        public virtual ICollection<Homework> Homework { get; set; }
        public virtual ICollection<Quiz> Quiz { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
