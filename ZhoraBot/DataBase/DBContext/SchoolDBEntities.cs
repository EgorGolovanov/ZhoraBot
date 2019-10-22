using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;
using System.Data.Entity;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий общий вид базы данных
    /// </summary>
    public class SchoolDBEntities : DbContext
    {
        public SchoolDBEntities() : base("DbConnection") { } 
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<AnswersForContent> AnswerForContent { get; set; }
        public virtual DbSet<Chanell> Chanell { get; set; }
        public virtual DbSet<ClassWorkContent> ClassWorkContent { get; set; }
        public virtual DbSet<Command> Command  { get; set; }
        public virtual DbSet<Contest> Contest  { get; set; }
        public virtual DbSet<ContestContent> ContestContent{ get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<FreeContentSchedule> FreeContentSchedule { get; set; }
        public virtual DbSet<Homework> Homework  { get; set; }
        public virtual DbSet<HomeworkContent> HomeworkContent { get; set; }
        public virtual DbSet<Lottery> Lottery { get; set; }
        public virtual DbSet<Mentor> Mentor { get; set; }
        public virtual DbSet<MentorsRating> MentorsRating { get; set; }
        public virtual DbSet<MentorsWorkTime> MentorsWorkTime { get; set; }
        public virtual DbSet<Methodist> Methodist { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Passerby>  Passerby { get; set; }
        public virtual DbSet<Quiz> Quiz { get; set; }
        public virtual DbSet<QuizContent> QuizContent { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }  
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentsRating> StudentsRating { get; set; }
        public virtual DbSet<StudentsSchedule> StudentsSchedule { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Subscriber> Subscriber {get;set;}
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TeachersWorkTime> TeachersWorkTime { get; set; }  
    }
}
