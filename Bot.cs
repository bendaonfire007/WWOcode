﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace ConsoleApp1
{
   public class Program
    {

        static void Main(string[] args) => new Program().StartAsync().GetAwaiter().GetResult();
        private DiscordSocketClient _client;
        private CommandHandler _Handler;

        public async Task StartAsync()
        {
           
            _client = new DiscordSocketClient();
            await _client.LoginAsync(TokenType.Bot, "some id");

            await _client.StartAsync();

            _Handler = new CommandHandler(_client);

            await Task.Delay(-1);
              
        }
       
    }
}
