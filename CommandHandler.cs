using System.Reflection;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace ConsoleApp1
{
    public class CommandHandler
    {
        private CommandService _service;
       private DiscordSocketClient _client;
        public CommandHandler(DiscordSocketClient client)
       
        {
            
            _client = client;
            _service = new CommandService();
            _service.AddModulesAsync(Assembly.GetEntryAssembly());
            _client.MessageReceived += HandleCommandAsync;
            
        }
        private async Task HandleCommandAsync(SocketMessage S)
        {
            var msg = S as SocketUserMessage;
            if (msg == null) return;
            var context = new SocketCommandContext(_client, msg);
            int argPos = 0;
            
            if (msg.HasCharPrefix('-', ref argPos))
            {
                
                
                var result = await _service.ExecuteAsync(context, argPos);
             
                if (!result.IsSuccess && result.Error != CommandError.UnknownCommand)
                {
                    if (CommandError.ObjectNotFound == result.Error)
                    {
                        await context.Channel.SendMessageAsync("Error, user not found. Are you sure you use the full username or the user is still in the server?");
                    }
                    if (CommandError.BadArgCount == result.Error)
                    {
                        await context.Channel.SendMessageAsync(result.ErrorReason);
                    }
                    if (CommandError.Exception == result.Error)
                    {
                        await context.Channel.SendMessageAsync("Error, occured. Usually it means object not found. Object is Player and so on.");
                       
                    }
                    if (CommandError.MultipleMatches == result.Error)
                    {
                        await context.Channel.SendMessageAsync(result.ErrorReason);
                    }
                    if (CommandError.ParseFailed == result.Error)
                    {
                        await context.Channel.SendMessageAsync("Are you sure this is a number?(and if it is are you sure it's not negative?)");
                    }
                    if (CommandError.UnmetPrecondition == result.Error)
                    {
                        await context.Channel.SendMessageAsync(result.ErrorReason);
                    }
                    System.Console.WriteLine(result.Error + ":" + result.ErrorReason);
                }
                if(result.IsSuccess)
                {
                    await context.Client.GetGuild(470026969963167765).GetTextChannel(480476496574676992).SendMessageAsync($"{context.User.Username} used the command:``{context.Message}``");
                }
            }
        }
    }
}
