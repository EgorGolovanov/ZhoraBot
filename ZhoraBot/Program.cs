﻿using System;
using SchoolApplication.DataBase;
using ZhoraBot.Repository;

namespace ZhoraBot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new ZhoraBot().RunBotAsync().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
