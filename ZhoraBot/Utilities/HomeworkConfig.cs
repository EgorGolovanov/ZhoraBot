using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using SchoolApplication.DataBase;
using System.Threading.Tasks;

namespace ZhoraBot.Utilities
{
    class HomeworkConfig
    {
        public void CheckHomework(string content)
        {
            using (SchoolDBEntities schoolDB = new SchoolDBEntities())
            {
                
            }

        }
    }

    struct Homework
    {
        string numberQuestion, answerQuestion;
        
        public Homework(string numberQuestion, string answerQuestion)
        {           
            this.numberQuestion = numberQuestion;
            this.answerQuestion = answerQuestion;
        }
    }

}
