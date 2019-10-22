using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// класс представляющий учебную дисциплину
    /// </summary>
    public class Subject : ISubject
    {
        
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// название предмета
        /// </summary>
        public string SubjectName { get; set; }
        /// <summary>
        /// список учеников
        /// </summary>
        public List<Student> Students { get; set; }
        /// <summary>
        /// преподаватель предмета
        /// </summary>
        public Teacher Teacher { get; set; }
        /// <summary>
        /// список конкурсов для предмета
        /// </summary>
        public List<Contest> Contests { get; set; }
        /// <summary>
        /// список викторин для предмета
        /// </summary>
        public List<Quiz> Quizs { get; set; }
        /// <summary>
        /// список домашнего задания для предмета
        /// </summary>
        public List<Homework> Homeworks { get; set; }
        /// <summary>
        /// учебные материалы к занятиям
        /// </summary>
        public List<ClassWorkContent> ClassWorkContent { get; set; }
    }
}
