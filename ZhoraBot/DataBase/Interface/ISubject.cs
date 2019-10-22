using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    /// <summary>
    /// интерфейс описывающий любую школьную дисциплину
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// название предмета
        /// </summary>
        string SubjectName { get; set; }
        /// <summary>
        /// список учеников для данного предмета
        /// </summary>
        List<Student> Students { get; set; }
        /// <summary>
        /// преподаватель предмета
        /// </summary>
        Teacher Teacher { get; set; }
        /// <summary>
        /// список сложных викторин (конкурсов) для предмета
        /// </summary>
        List<Contest> Contests { get; set; }
        /// <summary>
        /// список викторин для предмета
        /// </summary>
        List<Quiz> Quizs { get; set; }
        /// <summary>
        /// список домашнего задания для предмета
        /// </summary>
        List<Homework> Homeworks { get; set; }
        /// <summary>
        /// список учебных материалов для предмета
        /// </summary>
        List<ClassWorkContent> ClassWorkContent { get; set; }
    }
}
