using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZhoraBot.Utilities
{
    class DescriptionCommands
    {
        private const string configFolder = "Resources";
        private const string configFile = "help.json";

        private Command command;
       // private List<Command> commands;

        public string GetCommandName()
        {
            return command.name;
        }

        public string GetCommandParameters()
        {
            return command.parameters;
        }

        public string GetCommandDecription()
        {
            return command.description;
        }

        public void AddCommand(string commandName, string parameters, string description)
        {
            command = new Command()
            {
                name = commandName,
                parameters = parameters,
                description = description
            };
            string json = JsonConvert.SerializeObject(command, Formatting.Indented);

            File.AppendAllText(configFolder + "/" + configFile, json);

        }

        public DescriptionCommands()
        {
            if (!Directory.Exists(configFolder))
                Directory.CreateDirectory(configFolder);

            if (!File.Exists(configFolder + "/" + configFile))
            {
                command = new Command();
                string json = JsonConvert.SerializeObject(command, Formatting.Indented);
                File.WriteAllText(configFolder + "/" + configFile, json);
            }
            else
            {
                string json = File.ReadAllText(configFolder + "/" + configFile);
                command = JsonConvert.DeserializeObject<Command>(json);
            }
        }
    }

    public struct Command
    {
        public string name;
        public string parameters;
        public string description;
    }

}
