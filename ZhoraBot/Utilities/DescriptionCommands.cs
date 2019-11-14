using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ZhoraBot.Utilities
{
    class DescriptionCommands
    {
        private const string configFolder = "Resources";
        private const string configFile = "CommandDescription.json";

        private List<Command> commands;

        public List<Command> GetCommandsDescriptions()
        {
            return commands;
        }

        private void AddCommand(Command command)
        {
            if (commands.FindIndex(p => p.name == command.name) != -1) return;

            commands.Add(command);

            string json = JsonConvert.SerializeObject(commands, Formatting.Indented);

            File.WriteAllText(configFolder + "/" + configFile, json);

        }

        public async Task AddCommandAsync(Command command)
        {
            await Task.Run(delegate()
            {
                if (commands == null) commands = new List<Command>();

                if (commands.FindIndex(p => p.name == command.name) == -1)
                {

                    commands.Add(command);

                    string json = JsonConvert.SerializeObject(commands, Formatting.Indented);

                    File.WriteAllText(configFolder + "/" + configFile, json);
                }

            });
        }


        public DescriptionCommands()
        {
            if (!Directory.Exists(configFolder)) Directory.CreateDirectory(configFolder);

            if (!File.Exists(configFolder + "/" + configFile))
            {
                File.WriteAllText(configFolder + "/" + configFile, "");
            }
            else
            {
                string json = File.ReadAllText(configFolder + "/" + configFile);

                commands = JsonConvert.DeserializeObject<List<Command>>(json);
            }
        }
    }

    public  struct Command
    {
        public string name;
        public Description description;
    }

    public struct Description
    {
        public List<string> parameters;
        public string description;
        public List<string> roles;
    }


}
