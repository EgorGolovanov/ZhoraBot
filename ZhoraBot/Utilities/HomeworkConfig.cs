using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZhoraBot.Utilities
{
    class HomeworkConfig
    {

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
