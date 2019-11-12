using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ZhoraBot
{
    
    class Config
    {
        private const string configFolder = "Resources";
        private const string configFile = "config.json";

        private static BotConfig bot;

        public static string GetBotToken()
        {
            return bot.token;
        }

        public static string GetCommandPrefix()
        {
            return bot.commandPrefix;
        }

        static Config()
        {
            if (!Directory.Exists(configFolder))
                Directory.CreateDirectory(configFolder);

            if (!File.Exists(configFolder + "/" + configFile))
            {
                bot = new BotConfig();
                string json = JsonConvert.SerializeObject(bot, Formatting.Indented);
                File.WriteAllText(configFolder + "/" + configFile, json);
            }
            else
            {
                string json = File.ReadAllText(configFolder + "/" + configFile);
                bot = JsonConvert.DeserializeObject<BotConfig>(json);             
            }
        }
    }


    public struct BotConfig
    {
        public string token;
        public string commandPrefix;
    }

}
