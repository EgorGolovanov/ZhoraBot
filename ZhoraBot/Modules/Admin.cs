using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZhoraBot.Modules
{
    public class Admin : ModuleBase<SocketCommandContext>
    {
        [Command("hello")]
        public async Task HelloAsync()
        {
            await ReplyAsync("Привет, пидор!");
        }


        [Command("getListRole")]
        [RequireUserPermission(GuildPermission.Administrator)]
        public async Task GetListRoles()
        {
            var user = Context.User as SocketGuildUser; 
            
            var serverRoles = (user as IGuildUser).Guild.Roles; // получает список ролей доступных на сервере
            
            foreach (var x in serverRoles)
            {
                await ReplyAsync(x.Name + "\n");
            }
        }
    }
}
