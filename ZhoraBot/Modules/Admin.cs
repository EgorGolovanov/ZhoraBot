using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using ZhoraBot.Utilities;
using System.Net.Http;

namespace ZhoraBot.Modules
{
    public class Admin : ModuleBase<SocketCommandContext>
    {
        [Command("hello")]
        public async Task HelloAsync()
        {
            await ReplyAsync("Привет, пидор!");
        }

        [Command("help")]
        public async Task HelpCommand()
        {
            var helper = new DescriptionCommands();
            
            await ReplyAsync("Не помогу! Пошел нахуй!");
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

        [Command("createVoiceChanell")]
        public async Task CreateVoiceChanell([Remainder] string nameChanell = "")
        {
            var user = Context.User as SocketGuildUser;

            var chanell = await user.Guild.CreateVoiceChannelAsync(nameChanell);

        }

        [Command("createTextChanell")]
        public async Task CreateTextChanell([Remainder] string nameChanell = "")
        {
            var user = Context.User as SocketGuildUser;

            var chanell = await user.Guild.CreateTextChannelAsync(nameChanell);

        }

        [Command("deleteChanell")]
        public async Task DeleteChanell([Remainder] string nameChanell = "")
        {
            var user = Context.User as SocketGuildUser;

            var chanells = user.Guild.Channels;

            var deletedChanell =  chanells.FirstOrDefault(p => p.Name == nameChanell);

            if (deletedChanell != null) await deletedChanell.DeleteAsync();
        }

        /// <summary>
        ///  определение принадлежности юзера к роли
        /// </summary>
        /// <param name="user"> юзер для проверки </param>
        /// <param name="role"> название роли </param>
        /// <returns> true or false </returns>
        private bool RoleMembership(SocketGuildUser user, string role)
        {
            var result = from r in user.Guild.Roles
                         where r.Name == role
                         select r.Id;
            
            var roleID = result.FirstOrDefault();
            
            if (roleID == 0) return false;
            
            var targetRole = user.Guild.GetRole(roleID);
            
            return user.Roles.Contains(targetRole);
        }

        [Command("newCategory")]
        public async Task CreateCategory([Remainder] string nameCategory = "")
        {
            var user = Context.User as SocketGuildUser;
            if (nameCategory == "") return;
            await user.Guild.CreateCategoryChannelAsync(nameCategory);
        }

        [Command("moveChanell")]
        public async Task MoveChanell(string nameChanell = "", string nameCategory = "")
        {
            var user = Context.User as SocketGuildUser;
            var chanells = user.Guild.Channels;
            var categories = user.Guild.CategoryChannels;
            var movedChanell = chanells.FirstOrDefault(p => p.Name == nameChanell);

            var categoriesID = from c in categories
                             where c.Name == nameCategory
                             select c.Id;
            var categoryID = categoriesID.FirstOrDefault();


            if (movedChanell != null && categoryID != 0)
            {
                await movedChanell.ModifyAsync(delegate (GuildChannelProperties properties) { properties.CategoryId = categoryID; });
            }
        }
        
        /// <summary>
        /// загрузка файла, (в комментарий при загрузке указать название команды !sendHomework)
        /// </summary>
        /// <returns></returns>
        [Command("sendHomework")]
        [RequireContext(ContextType.DM)]
        public async Task SendHomework()
        {
            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync(Context.Message.Attachments.First().Url);
                
                //var stream = await client.GetStreamAsync(Context.Message.Attachments.First().Url);
                
                if (!String.IsNullOrEmpty(content)) await ReplyAsync("Я получил твой файл) Сейчас проверю его и скаже тебе результат))");
                else await ReplyAsync("Так, так так, СТОП! Проверь-ка свой файл еще раз, возможно он пустой или что-то пошло не так при загрузке))\nСтоит попробовать отправить еще разок)))");
            }

            // проверка домашней работы 

            //сохранить под новым именем (с указанием имени ученика и предмета) и отправить в беседу менторов или преподов
            
        }

    }
}
