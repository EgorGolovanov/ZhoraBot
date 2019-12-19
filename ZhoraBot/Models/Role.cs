using System;
using System.Collections.Generic;

namespace ZhoraBot.Models
{
    public partial class Role
    {
        public Role()
        {
            Student = new HashSet<Student>();
            Teacher = new HashSet<Teacher>();
        }

        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public bool Administrator { get; set; }

        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
