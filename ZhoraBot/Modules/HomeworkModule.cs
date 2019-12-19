using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZhoraBot.Models;
using ZhoraBot.Utilities;

namespace ZhoraBot.Modules
{
    public class HomeworkModule : ModuleBase<SocketCommandContext>
    {
        [Command("AddHomework")]
        public async Task AddHomework([Remainder] string homeworkName)
        {
            var User = Context.User as SocketGuildUser;

            var commandsDescriptions = new DescriptionCommands();

            if (!commandsDescriptions.AvailabilityCheck("AddHomework", User.Roles)) return;

            var attachments = Context.Message.Attachments.ToList();

            if (attachments.Count != 2) return;

            if ((attachments[0].Filename == String.Format(homeworkName + ".txt")
                && attachments[1].Filename == String.Format(homeworkName + "(Answers).txt"))
                || (attachments[1].Filename == String.Format(homeworkName + ".txt")
                && attachments[0].Filename == String.Format(homeworkName + "(Answers).txt")))
            {
                using (var client = new HttpClient())
                {

                }
            }
        }

        /// <summary>
        /// загрузка файла, (в комментарий при загрузке указать название команды !sendHomework)
        /// </summary>
        /// <returns></returns>
        [Command("SendHomework")]
        [RequireContext(ContextType.DM)]
        public async Task SendHomework([Remainder] string homeworkName)
        {
            var attach = Context.Message.Attachments.First();

            using (var client = new HttpClient())
            {

                if (!attach.Filename.EndsWith(".txt"))
                {
                    await ReplyAsync("Домашняя работа обрабатывается только в формате \".txt\". Пожалуйста попробуй еще раз с правильным расширением файла.");

                    return;
                }

                var content = await client.GetStringAsync(attach.Url);

                if (!String.IsNullOrEmpty(content))
                    await ReplyAsync("Я получил твой файл) Сейчас проверю его и скаже тебе результат))");
                else
                    await ReplyAsync("Так, так так, СТОП! Проверь-ка свой файл еще раз, возможно он пустой или что-то пошло не так при загрузке))\nСтоит попробовать отправить еще разок)))");

                using (var db = new ZhoraDBContext())
                {
                    //придуумать как правильно выбирать по названию нужную дз
                    var homeworks = db.Content
                                      .Where(p => p.ContentType == "ДЗ" && p.SourcePath.EndsWith(homeworkName + ".txt"))
                                      .ToList();

                    if (homeworks == null)
                    {
                        await ReplyAsync("Возможно, у меня нет этой домашней работы.\nПожалуйста посмотри все условия для сдачи работы в канале \"ТАКОМ ТО\" и попробуй еще раз.");
                        return;
                    }

                    var answerForHomework = await client.GetStringAsync(homeworks.First().AnswerPath);


                }

            }

            // проверка домашней работы 


            //сохранить под новым именем (с указанием имени ученика и предмета) и отправить в беседу менторов или преподов

        }

    }
}
