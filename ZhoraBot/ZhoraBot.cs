using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZhoraBot.Services;


namespace ZhoraBot
{
    public class ZhoraBot
    {
        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;
        //private CommandHandler _handler;

        public async Task RunBotAsync()
        {
            _client = new DiscordSocketClient();
            _commands = new CommandService();
            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();
                
            _client.Log += Log;

            await RegisterCommandAsync();

            

            await _client.LoginAsync(TokenType.Bot, Config.GetBotToken());

            //запускаем бота
            await _client.StartAsync();

            //офидаем пока не закроют прогу
            await Task.Delay(-1);
        }
        /// <summary>
        /// выписываем сообщения об ошибках и тд. 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private Task Log(LogMessage arg)
        {
            Console.WriteLine(arg);

            return Task.CompletedTask;
        }

        /// <summary>
        /// добавляем все команды 
        /// </summary>
        /// <returns></returns>
        public async Task RegisterCommandAsync()
        {
            _client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
        }

        /// <summary>
        /// упраление командами (проверка на префикс перед командой, отлов сообщений от самого бота, выполнение команды)
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            if (message is null || message.Author.IsBot) return;

            int argPos = 0;

            if (message.HasStringPrefix(Config.GetCommandPrefix(), ref argPos) || message.HasMentionPrefix(_client.CurrentUser, ref argPos))
            {
                var context = new SocketCommandContext(_client, message);

                var result = await _commands.ExecuteAsync(context, argPos, _services);

                if (!result.IsSuccess)
                    Console.WriteLine(result.ErrorReason);
            }
        }
    }
}
