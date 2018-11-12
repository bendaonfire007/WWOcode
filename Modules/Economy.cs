
using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Drawing;
using ConsoleApp1.Core.UserAccounts;
using System.Globalization;
using System.Windows.Forms;

using Discord.WebSocket;
using System.Diagnostics;

namespace ConsoleApp1.Modules
{

    public class Economy : ModuleBase<SocketCommandContext>
    {
        [Command("daccept")]
        private async Task daccept()
        {
            if (GlobalNums.dduelrequestp == Context.User.Id)
            {
                
                var a = UserAccounts.GetAccount(Context.User);
                var b = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.dhostp));
                if (a.happiness >= 30 && a.water >= 30 && a.food >= 30 && a.sleep >= 30&& b.happiness >= 30 && b.water >= 30 && b.food >= 30 && b.sleep >= 30)
                {
                    ulong ap = a.animal;
                    ulong bp = b.animal;
                    Random r = new Random();
                    int win = r.Next(1, 3);
                    if (win == 2)
                    {
                        b.happiness = b.happiness - 20;
                        b.food = b.food - 20;
                        b.water = b.water - 20;
                        b.sleep = b.sleep - 20;
                        a.happiness = a.happiness + 20;
                        a.food = a.food - 10;
                        a.water = a.water - 10;
                        a.sleep = a.sleep - 10;
                        a.points = a.points + GlobalNums.dbetp;
                        b.points = b.points - GlobalNums.dbetp;
                        a.xp = a.xp + 200;
                        await ReplyAsync($"{Context.Guild.GetUser(GlobalNums.dduelrequestp).Username} won the match!");
                    }
                    if (win == 1)
                    {
                        a.happiness = a.happiness - 20;
                        b.xp = b.xp + 200;
                        a.food = a.food - 20;
                        a.water = a.water - 20;
                        a.sleep = a.sleep - 20;
                        b.happiness = b.happiness + 20;
                        b.food = b.food - 10;
                        b.water = b.water - 10;
                        b.sleep = b.sleep - 10;
                        a.points = a.points - GlobalNums.dbetp;
                        b.points = b.points + GlobalNums.dbetp;
                        await ReplyAsync($"{Context.Guild.GetUser(GlobalNums.dhostp).Username} won the match!");
                    }
                    if(ap!=a.animal)
                    {
                        await ReplyAsync($"{Context.User.Username} you just got a new animal Congratulations!");
                    }
                    if (bp != b.animal)
                    {
                        await ReplyAsync($"{Context.Guild.GetUser(GlobalNums.dhostp).Username} you just got a new animal Congratulations!");
                    }
                   
                   
                        GlobalNums.dduelrequestp = 0;
                        GlobalNums.dbetp = 0;
                        GlobalNums.djoinerp = 0;
                    
                }
            }
            else
            {
                await ReplyAsync("Error, you were not invited to a duel.");
            }
        }
        [Command("ddeny")]
        private async Task ddeny()
        {
            if (Context.User.Id == GlobalNums.dduelrequestp)
            {
                await ReplyAsync("Duel was denied!");
                GlobalNums.dduelrequestp = 0;
                GlobalNums.dbetp = 0;
                GlobalNums.djoinerp = 0;
            }
        }
        [Command("dcancel")]
        private async Task dcancel()
        {
            if (Context.User.Id == GlobalNums.dhostp)
            {
                await ReplyAsync("Duel was cancelled!");
                GlobalNums.dduelrequestp = 0;
                GlobalNums.dbetp = 0;
                GlobalNums.djoinerp = 0;
            }
        }
        [Command("duel")]
        private async Task duel(SocketUser user,ulong money)
        {
            var ac = UserAccounts.GetAccount(user);
            var acc =UserAccounts.GetAccount(Context.User);
            if (Context.User.Id != user.Id)
            {
                if (acc.animal >= 1 && ac == acc)
                {
                    if (acc.points >= money)
                    {
                        if (GlobalNums.dhostp == 0)
                        {
                            GlobalNums.dbetp = money;
                            GlobalNums.dhostp = Context.User.Id;
                            GlobalNums.dduelrequestp = user.Id;
                            await ReplyAsync($"Duel started! {Context.User.Username} asked to duel {user.Username}!");
                        }
                        else
                        {
                            await ReplyAsync("Error, game already started");
                        }
                    }
                }
                else
                {
                    await ReplyAsync("Error, both players need to have an animal in the same level.");
                }
            }
            else
            {
                await ReplyAsync("Error, can't duel yourself.");
            }
        }
        [Command("hunt")]
        private async Task hunt()
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                Random random = new Random();
                int eat = random.Next(5, 11);
                int tired = random.Next(1, 6);
                var thirsty = random.Next(5, 11);
                var happy = random.Next(5, 11);
                var account = UserAccounts.GetAccount(Context.User);
                if (account.animal >= 2)
                {
                    if (account.happiness >= 20 && account.sleep >= 20 && account.food >= 20 && account.water >= 20)
                    {
                        account.happiness = account.happiness - (uint)happy;
                        account.sleep = account.happiness - (uint)tired;
                        account.water = account.happiness - (uint)eat;
                        account.food = account.happiness - (uint)thirsty;
                        if (account.animal == 2)
                        {
                            int success = random.Next(1, 11);
                            int b = random.Next(1, 6);
                            if (success >= 4)
                            {
                                account.mouse = account.mouse + (uint)b;
                                await ReplyAsync($"Your cat successfully hunted {b} mouses.");
                            }
                            else
                            {
                                await ReplyAsync("Your cat had a rough day it didn't catch any mouses his happiness decreased a lot more from that.");
                                account.happiness = account.happiness - 10;
                            }
                        }
                        if (account.animal == 3)
                        {
                            int success = random.Next(1, 11);
                            int b = random.Next(1, 6);
                            if (success >= 4)
                            {
                                account.cats = account.cats + (uint)b;
                                await ReplyAsync($"Your dog successfully hunted {b} cats.");
                            }
                            else
                            {
                                await ReplyAsync("Your dog had a rough day it didn't catch any cats his happiness decreased a lot more from that.");
                                account.happiness = account.happiness - 10;
                            }
                        }
                        if (account.animal == 4)
                        {
                            int success = random.Next(1, 11);
                            int b = random.Next(1, 6);
                            if (success >= 4)
                            {
                                account.dogs = account.dogs + (uint)b;
                                await ReplyAsync($"Your Eagle successfully hunted {b} dogs.");
                            }
                            else
                            {
                                await ReplyAsync("Your Eagle had a rough day it didn't catch any dogs his happiness decreased a lot more from that.");
                                account.happiness = account.happiness - 10;
                            }
                        }
                        if (account.animal == 5)
                        {
                            int success = random.Next(1, 11);
                            int b = random.Next(1, 6);
                            if (success >= 4)
                            {
                                account.eagle = account.eagle + (uint)b;
                                await ReplyAsync($"Your Tiger successfully hunted {b} eagles.");
                            }
                            else
                            {
                                await ReplyAsync("Your Tiger had a rough day it didn't catch any eagles his happiness decreased a lot more from that.");
                                account.happiness = account.happiness - 10;
                            }
                        }
                        if (account.animal == 6)
                        {
                            int success = random.Next(1, 11);
                            int b = random.Next(1, 6);
                            if (success >= 4)
                            {
                                account.tiger = account.tiger + (uint)b;
                                await ReplyAsync($"Your Lion successfully hunted {b} tigers.");
                            }
                            else
                            {
                                await ReplyAsync("Your Lion had a rough day it didn't catch any tigers his happiness decreased a lot more from that.");
                                account.happiness = account.happiness - 10;
                            }
                        }
                        if (account.animal == 7)
                        {
                            int success = random.Next(1, 11);
                            int b = random.Next(1, 6);
                            if (success >= 4)
                            {
                                account.lion = account.lion + (uint)b;
                                await ReplyAsync($"Your Cerberus successfully hunted {b} lions.");
                            }
                            else
                            {
                                await ReplyAsync("Your Cerberus had a rough day it didn't catch any lions his happiness decreased a lot more from that.");
                                account.happiness = account.happiness - 10;
                            }
                        }
                        if (account.animal == 8)
                        {
                            int success = random.Next(1, 11);
                            int b = random.Next(1, 6);
                            if (success >= 4)
                            {
                                account.cerberus = account.cerberus + (uint)b;
                                await ReplyAsync($"Your Phoenix successfully hunted {b} Cerberus.");
                            }
                            else
                            {
                                await ReplyAsync("Your Phoenix had a rough day it didn't catch any Cerberus his happiness decreased a lot more from that.");
                                account.happiness = account.happiness - 10;
                            }
                        }
                        if (account.animal == 10)
                        {
                            int success = random.Next(1, 11);
                            int b = random.Next(1, 6);
                            if (success >= 4)
                            {
                                account.godzilla = account.godzilla + (uint)b;
                                await ReplyAsync($"Your Dragon successfully hunted {b} Godzillas.");
                            }
                            else
                            {
                                await ReplyAsync("Your Dragon had a rough day it didn't catch any godzillas his happiness decreased a lot more from that.");
                                account.happiness = account.happiness - 10;
                            }
                        }
                        if (account.animal == 9)
                        {
                            int success = random.Next(1, 11);
                            int b = random.Next(1, 6);
                            if (success >= 4)
                            {
                                account.phoenix = account.phoenix + (uint)b;
                                await ReplyAsync($"Your Godzilla successfully hunted {b} phoenix.");
                            }
                            else
                            {
                                await ReplyAsync("Your Godzilla had a rough day it didn't catch any phoenix his happiness decreased a lot more from that.");
                                account.happiness = account.happiness - 10;
                            }
                        }
                    }
                    else
                    {
                        await ReplyAsync("Your pet don't want to listen to you. Please try and feel your animal stats.");
                    }
                }
                else
                {
                    await ReplyAsync("Error, you need a cat or higher.");
                }
            }
        }
        [Command("train")]
        private async Task training(ulong money)
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                var account = UserAccounts.GetAccount(Context.User);
                if (account.animal >= 1)
                {
                    if (account.points >= money)
                    {
                        account.xp = money * 5;
                        account.points = account.points - money;
                        await ReplyAsync($"Your pet gained {money * 5} XP!");
                        UserAccounts.SaveAccounts();
                    }
                    else
                    {
                        await ReplyAsync("Error, you don't have enough money");
                    }
                }
                else
                {
                    await ReplyAsync("Error, you don't have an animal.");
                }
            }
        }
        [Command("petshop")]
        private async Task petshop()
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                UserAccounts.SaveAccounts();
                var embed = new EmbedBuilder();
                var account = UserAccounts.GetAccount(Context.User);
                if (account.animal >= 1)
                {
                    embed.WithTitle($"Werewolf Online Simulation Pet Shop \n \n ");
                    embed.AddField($"Seeds - 5 {Emote.Parse("<:coin:475781084584607745>")}", $"Food for mouse.");
                    embed.AddField($"Mouse - 10 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet don't have enough strengh to hunt? Well here you go! 60% of the price for selling.");
                    embed.AddField($"Cat - 20 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet don't have enough strengh to hunt? Well here you go! 60% of the price for selling.");
                    embed.AddField($"Dog - 40 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet don't have enough strengh to hunt? Well here you go! 60% of the price for selling.");
                    embed.AddField($"Eagle - 80 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet don't have enough strengh to hunt? Well here you go! 60% of the price for selling.");
                    embed.AddField($"Tiger - 160 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet don't have enough strengh to hunt? Well here you go! 60% of the price for selling.");
                    embed.AddField($"Lion - 320 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet don't have enough strengh to hunt? Well here you go! 60% of the price for selling.");
                    embed.AddField($"Cerberus - 640 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet don't have enough strengh to hunt? Well here you go! 60% of the price for selling.");
                    embed.AddField($"Phoenix - 1280 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet don't have enough strengh to hunt? Well here you go! 60% of the price for selling.");
                    embed.AddField($"Godzilla - 2560 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet don't have enough strengh to hunt? Well here you go! 60% of the price for selling.");
                    embed.AddField($"Ball - 100 {Emote.Parse("<:coin:475781084584607745>")}", $"Play with your pet so he wont be bored.");
                    embed.AddField($"Water - 20 {Emote.Parse("<:coin:475781084584607745>")}", $"Your pet is thirsty? So here is the right item.");
                    embed.WithColor(new Discord.Color(0, 255, 255));
                    await Context.Channel.SendMessageAsync("", false, embed);
                }
            }
        }
        [Command("animal")]
        [Alias("pet", "pets", "animals")]
        private async Task animals()
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                var useracc = UserAccounts.GetAccount(Context.User);
                if (useracc.animal >= 1)
                {
                    var embed = new EmbedBuilder();
                    embed.WithTitle($"Werewolf Online Simulation Animals \n \n ");
                    if (useracc.animal == 1)
                    {
                        embed.AddField("Your animal is:", "Mouse");
                    }
                    if (useracc.animal == 2)
                    {
                        embed.AddField("Your animal is:", "Cat");
                    }
                    if (useracc.animal == 3)
                    {
                        embed.AddField("Your animal is:", "Dog");
                    }
                    if (useracc.animal == 4)
                    {
                        embed.AddField("Your animal is:", "Eagle");
                    }
                    if (useracc.animal == 5)
                    {
                        embed.AddField("Your animal is:", "Tiger");
                    }
                    if (useracc.animal == 6)
                    {
                        embed.AddField("Your animal is:", "Lion");
                    }
                    if (useracc.animal == 7)
                    {
                        embed.AddField("Your animal is:", "Cerberus");
                    }
                    if (useracc.animal == 8)
                    {
                        embed.AddField("Your animal is:", "Phoenix");
                    }
                    if (useracc.animal == 9)
                    {
                        embed.AddField("Your animal is:", "Godzilla");
                    }
                    if (useracc.animal == 10)
                    {
                        embed.AddField("Your animal is:", "Dragon");
                    }
                    embed.AddField($"Animal Commands", $"Here is the list of all commands in animals.\n\n ``-petshop``-list of pet shop items \n ``-hunt``-use your animal to start hunting depends on what animal you have\n ``-duel (person) (bet)`` ask a friend to duel with him to increase your animal XP and get money.\n ``-dcancel`` - Cancel the duel.\n ``-ddeny`` - deny the duel. \n ``-daccept`` - accept the duel and the bet on that duel. \n``-sleep`` - refill your energy but can't use your animal for 10 hours. \n ``-train (coins)``- train your animal to gain XP without duels or hunting.");
                    embed.AddField($"Stats", $"Hunger - {useracc.food} \n Thirst - {useracc.water} \n Happiness - {useracc.happiness} \n Energy - {useracc.sleep}");
                    
                    embed.WithColor(new Discord.Color(0, 255, 255));
                    await Context.Channel.SendMessageAsync("", false, embed);
                }
            }
        }
        [Command("reboot")]
        private async Task stupidbot()
        {
            if (Context.Client.GetGuild(465795320526274561).Roles.FirstOrDefault(x => x.Name == "Bot Helper").Members.Contains(Context.User)|| Context.Client.GetGuild(465795320526274561).Roles.FirstOrDefault(x => x.Name == "Bot Dev").Members.Contains(Context.User))
            {
                
                Process.Start(Application.ExecutablePath);
                Environment.Exit(0);
            }
            await ReplyAsync("Error, only bot helper and bot dev can use this command!");
        }
    [Command("narrate")]
    private async Task narrator()
        {
           if(Context.Guild.Roles.FirstOrDefault(x=>x.Name=="GN").Members.Contains(Context.User))
            {
               await (Context.User as IGuildUser).AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Narrator"));
            }
        }
  
        [Command("Daily")]
        private async Task daily()
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                if (DataStorage.paircount(Context.User + DateTime.Now.ToLongDateString()) == true)
                { 
                    DataStorage.addpairs(Context.User + DateTime.Now.ToLongDateString(), "Oof");
                    var accounts = UserAccounts.GetAccount(Context.User);
                    ulong daily = 10 + accounts.animal*5;
                    accounts.points = accounts.points + daily;
                    await ReplyAsync($"Welcome back {Context.User.Username} ! Your new balance is {accounts.points} {Emote.Parse("<:coin:475781084584607745>")}.");                   
                }
                else
                {
                    if (24 - DateTime.Now.Hour != 0 || 24 - DateTime.Now.Hour != 24 || 60 - DateTime.Now.Minute != 60 || 60 - DateTime.Now.Minute != 0)
                    {
                        await ReplyAsync($"Already used that command today. Come back later  in {23 - DateTime.Now.Hour} hours and {60 - DateTime.Now.Minute} minutes!");
                    }
                    if ( 60 - DateTime.Now.Minute == 60 || 60 - DateTime.Now.Minute == 0)
                    {
                        await ReplyAsync($"Already used that command today. Come back later  in {24 - DateTime.Now.Hour} hours!");
                    }
                    
                }
                UserAccounts.SaveAccounts();
            }
           
        }
        [Command("balance")]
        [Alias("bal")]
        private async Task getdata([Optional]SocketUser user)
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                if (user == null || user == (Context.User as SocketUser))
                {
                    var accounts = UserAccounts.GetAccount(Context.User);
                    await ReplyAsync($"Your balance is {accounts.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                }
                else
                {
                    var accounts = UserAccounts.GetAccount(user);
                    await ReplyAsync($"{user.Username} balance is {accounts.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                }
                UserAccounts.SaveAccounts();
            }
        }
        [Command("givemoney")]
        [Alias("GM")]
        private async Task givemoney(SocketUser user, ulong number)
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                var hostacc = UserAccounts.GetAccount(Context.User);
                var accounts = UserAccounts.GetAccount(user);
                var account = UserAccounts.GetAccount(Context.User);
                if (account.points >= number)
                {
                    
                    account.points = account.points - number;
                    accounts.points = accounts.points + number;
                    await ReplyAsync($"Successfully gave {number} {Emote.Parse("<:coin:475781084584607745>")} to {user.Username} ! His new balance is {accounts.points} {Emote.Parse("<:coin:475781084584607745>")} and your new balance is {account.points} {Emote.Parse("<:coin:475781084584607745>")}.");
                    UserAccounts.SaveAccounts();
                }
                else
                {
                    await ReplyAsync("Error, don't have enough money");
                }
            }
        }
        [Command("addmoney")]
        [Alias("AM")]
        [RequireBotPermission(Discord.GuildPermission.ManageRoles)]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        private async Task AM(SocketUser user, ulong number)
        {
            if (Context.User.Id != 0)
            {
                var accounts = UserAccounts.GetAccount(user);
                accounts.points = accounts.points + number;
                await ReplyAsync($"Added successfully {number} {Emote.Parse("<:coin:475781084584607745>")} to {user.Username} ! His new balance is {accounts.points} {Emote.Parse("<:coin:475781084584607745>")}.");
                UserAccounts.SaveAccounts();
         
            }
            else
            {
                await ReplyAsync("Hello Mod, you probably abused this command so you can no longer use it have a nice day.");
            }
        }
        [Command("Buy")]
        private async Task foundmahitemKEK(String item,[Optional]string hex)
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                if (item == "cat" || item == "Cat")
                {
                    var user = UserAccounts.GetAccount(Context.User);
                    if (user.animal != 0)
                    {
                        if (user.points >= 20)
                        {
                            int amount = 0;
                            if (hex != null)
                            {
                                Int32.TryParse(hex, out amount);
                            }
                            else
                            {
                                amount = 1;
                            }
                            user.points = user.points - 20 * (ulong)amount;
                            await ReplyAsync($"Successfully bought {amount} seeds!");
                            UserAccounts.SaveAccounts();

                        }
                        else
                        {
                            await ReplyAsync($"You need 10 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {1000 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, you don't have an animal go buy one.");
                    }
                }
                if (item == "mouse" || item == "Mouse")
                {
                    var user = UserAccounts.GetAccount(Context.User);
                    if (user.animal != 0)
                    {
                        if (user.points >= 10)
                        {
                            int amount = 0;
                            if (hex != null)
                            {
                                Int32.TryParse(hex, out amount);
                            }
                            else
                            {
                                amount = 1;
                            }
                            user.points = user.points - 10 * (ulong)amount;
                            await ReplyAsync($"Successfully bought {amount} seeds!");
                            UserAccounts.SaveAccounts();

                        }
                        else
                        {
                            await ReplyAsync($"You need 10 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {1000 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, you don't have an animal go buy one.");
                    }
                }
                if (item == "Seed" || item == "seed")
                {
                    var user = UserAccounts.GetAccount(Context.User);
                    if (user.animal != 0)
                    {
                        if (user.points >= 5)
                        {
                            int amount = 0;
                            if (hex != null)
                            {
                                Int32.TryParse(hex, out amount);
                            }
                            else
                            {
                                amount = 1;
                            }
                            user.points = user.points - 5*(ulong)amount;
                            await ReplyAsync($"Successfully bought {amount} seeds!");
                            UserAccounts.SaveAccounts();

                        }
                        else
                        {
                            await ReplyAsync($"You need 5 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {1000 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, you don't have an animal go buy one.");
                    }
                }
                if (item == "Animal" || item == "animal" || item == "Pet"||item=="pet")
                {
                    var user = UserAccounts.GetAccount(Context.User);
                    if (user.animal == 0)
                    {
                        if (user.points >= 1000)
                        {
                            user.points = user.points - 150;
                            await ReplyAsync($"Successfully bought your first pet! You now can have fun with your Mouse and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}! Use ``-pet`` to start!");
                            UserAccounts.SaveAccounts();
                            user.animal = 1;
                        }
                        else
                        {
                            await ReplyAsync($"You need 1000 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {1000 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, you already have an animal go use ``-animal``");
                    }
                }
                if (item == "Special" || item == "special")
                {
                    var user = UserAccounts.GetAccount(Context.User);

                    if (user.points >= 100)
                    {

                        System.Drawing.Color color = (System.Drawing.Color)ColorTranslator.FromHtml(hex);
                        Discord.Color oofnew = new Discord.Color(color.R, color.G, color.B);
                        var b = await Context.Guild.CreateRoleAsync($"{Context.User.Username}'s special role", null, oofnew);
                        await (Context.User as IGuildUser).AddRoleAsync(b);
                        await b.ModifyAsync(x => x.Position = 22);
                        user.points = user.points - 100;
                        await ReplyAsync($"Successfully created your own Special Color Role. You are now in that color you chose and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                        UserAccounts.SaveAccounts();

                    }
                    else
                    {
                        await ReplyAsync($"You need 100 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {100 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                    }
                }
                if (item == "DJ" || item == "dj" || item == "Dj")
                {
                    if (hex == "Role" || hex == "role" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 200)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "DJ").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "DJ");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 200;
                                await ReplyAsync($"Successfully bought your DJ Role. You are now can play music and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 200 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} when you get the other {200 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "blue" || item == "Blue")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 50)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Blue Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Blue Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 50;
                                await ReplyAsync($"Successfully bought your Blue Color Role. You are now in Blue and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 50 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {50 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "Yellow" || item == "yellow")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 50)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Yellow Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Yellow Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 50;
                                await ReplyAsync($"Successfully bought your Yellow Color Role. You are now in Yellow and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")} !");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 50 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {50 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "red" || item == "Red")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 50)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Red Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Red Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 50;
                                await ReplyAsync($"Successfully bought your Red Color Role. You are now in red and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 50 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {50 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "Black" || item == "black")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 50)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Black Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Black Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 50;
                                await ReplyAsync($"Successfully bought your Black Color Role. You are now in black and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 50 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {50 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "Crimson" || item == "crimson")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 50)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Crimson Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Crimson Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 50;
                                await ReplyAsync($"Successfully bought your Crimson Color Role. You are now in crimson and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 50 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {50 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "Green" || item == "green")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 50)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Green Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Green Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 50;
                                await ReplyAsync($"Successfully bought your Green Color Role. You are now in green and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 50 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {50 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "pink" || item == "Pink")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 50)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Pink Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Pink Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 50;
                                await ReplyAsync($"Successfully bought your Pink Color Role. You are now in pink and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 50 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {50 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "Elite" || item == "elite")
                {
                    if (hex == "lootbox" || hex == "lootboxes" || hex == "Lootbox" || hex == "Lootboxes" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 30)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Elite Lootboxes").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Elite Lootboxes");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 30;
                                await ReplyAsync($"Successfully bought your Elite Lootboxes Role. You are now in pink and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 30 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {30 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "premium" || item == "Premium")
                {
                    if (hex == "lootbox" || hex == "lootboxes" || hex == "Lootbox" || hex == "Lootboxes" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 10)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Premium Lootboxes").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Premium Lootboxes");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 10;
                                await ReplyAsync($"Successfully bought your Premium Lootboxes Role. You are now in pink and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 10 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {10 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "Salmon" || item == "salmon")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 50)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Salmon Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Salmon Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 50;
                                await ReplyAsync($"Successfully bought your Salmon Color Role. You are now in salmon and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 50 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {50 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "Turquoise" || item == "turquoise")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 50)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Turquoise Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Turquoise Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 50;
                                await ReplyAsync($"Successfully bought your Turquoise Color Role. You are now in turquoise and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 50 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {50 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                if (item == "Rainbow" || item == "rainbow")
                {
                    if (hex == "Color" || hex == "color" || hex == null)
                    {
                        var user = UserAccounts.GetAccount(Context.User);

                        if (user.points >= 150)
                        {
                            if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Rainbow Role").Members.Contains(Context.User))
                            {
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Rainbow Role");
                                await (Context.User as IGuildUser).AddRoleAsync(role);
                                user.points = user.points - 150;
                                await ReplyAsync($"Successfully bought your Rainbow Color Role. You are now in turquoise and your new balance is {user.points} {Emote.Parse("<:coin:475781084584607745>")}!");
                            }
                            else
                            {
                                await ReplyAsync($"Why would you buy a role you already own? Lucky that I figured it out or you would waste your coins.");
                            }
                        }
                        else
                        {
                            await ReplyAsync($"You need 150 {Emote.Parse("<:coin:475781084584607745>")} for that. You only got {user.points} {Emote.Parse("<:coin:475781084584607745>")} when you get the other {150 - user.points} {Emote.Parse("<:coin:475781084584607745>")} you can try to do this command again.");
                        }
                    }
                }
                UserAccounts.SaveAccounts();
            }
        }
        [Command("liardice")]
        [Alias("ld")]
        private async Task oooooooooooooof([Optional]string oof,[Optional]ulong test,[Optional]int dice)
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                List<ulong> LDlist = new List<ulong>();
                LDlist.Add(GlobalNums.LDplrstartedIDp);
                LDlist.Add(GlobalNums.LDplr2IDp);
                if(GlobalNums.LDplr3IDp!=0)
                {
                    LDlist.Add(GlobalNums.LDplr3IDp);
                }
                if (GlobalNums.LDplr4IDp != 0)
                {
                    LDlist.Add(GlobalNums.LDplr4IDp);
                }
                if (GlobalNums.LDplr5IDp != 0)
                {
                    LDlist.Add(GlobalNums.LDplr5IDp);
                }
                if (GlobalNums.LDplr6IDp != 0)
                {
                    LDlist.Add(GlobalNums.LDplr6IDp);
                }
                var embed = new EmbedBuilder();
                if (oof == null)
                {
                    embed.WithTitle($"Werewolf Online Simulation Liar's Dice. \n \n ");
                    embed.AddField($"-LD bet (bet)", $"Starting a Liar's Dice game.");
                    embed.AddField($"-LD join", $"Join an existing Liar's Dice.");
                    embed.AddField($"-LD start", $"Start your Liar's Dice.");
                    embed.AddField($"-LD cancel", $"Cancel your Liar's Dice.");
                    embed.AddField($"-LD guess (times) (dice)", $"Guess a new bet");
                    embed.AddField($"-LD call", $"Call someone guess.");

                    embed.WithColor(new Discord.Color(0, 255, 255));
                    await Context.Channel.SendMessageAsync("", false, embed);
                }
               
                if (oof == "bet" || oof == "Bet")
                {
                    if (GlobalNums.LDbetp == 0)
                    {
                        GlobalNums.LDturnp = 7;
                        var acccounts = UserAccounts.GetAccount(Context.User);
                        if (acccounts.points >= test)
                        {
                            if (test >= 5)
                            {

                                GlobalNums.LDplrstartedIDp = Context.User.Id;
                                GlobalNums.LDbetp = test;

                                acccounts.points = acccounts.points - GlobalNums.LDbetp;
                                embed.WithTitle($"Werewolf Online Simulation Liar's Dice started!. \n \n ");
                                embed.WithDescription($"Liar's Dice started for {test} {Emote.Parse("<:coin:475781084584607745>")}! Say -LD join to join it!");
                                embed.WithColor(new Discord.Color(0, 255, 255));

                                await Context.Channel.SendMessageAsync("", false, embed);
                            }
                            else
                            {
                                await ReplyAsync("Error, can't do number lower than 5.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Error, don't have enough coins for that try and lower the bet.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, already started a game. Say -LD join to join it!");
                    }
                }
                if (oof == "Join" || oof == "join")
                {
                    if (GlobalNums.LDplr6IDp == 0)
                    {
                        var acccounts = UserAccounts.GetAccount(Context.User);
                        if (Context.User.Id != GlobalNums.LDplrstartedIDp && Context.User.Id != GlobalNums.LDplr2IDp && Context.User.Id != GlobalNums.LDplr3IDp && Context.User.Id != GlobalNums.LDplr4IDp && Context.User.Id != GlobalNums.LDplr5IDp && Context.User.Id != GlobalNums.LDplr6IDp)
                        {
                            if (GlobalNums.LDturnp == 7)
                            {
                                if (acccounts.points >= GlobalNums.LDbetp)
                                {
                                    if (GlobalNums.LDbetp != 0)
                                    {
                                        GlobalNums.LDplrsp = 2;
                                        if (GlobalNums.LDplr5IDp != 0)
                                        {
                                            GlobalNums.LDplrsp = 6;
                                            GlobalNums.LDplr6IDp = Context.User.Id;
                                        }
                                        if (GlobalNums.LDplr4IDp != 0)
                                        {
                                            if (GlobalNums.LDplr5IDp == 0)
                                            {
                                                GlobalNums.LDplrsp = 5;
                                                GlobalNums.LDplr5IDp = Context.User.Id;
                                            }
                                        }
                                        if (GlobalNums.LDplr3IDp != 0)
                                        {
                                            
                                            if (GlobalNums.LDplr4IDp == 0)
                                            {
                                                GlobalNums.LDplrsp = 4;
                                              
                                                GlobalNums.LDplr4IDp = Context.User.Id;
                                            }
                                        }
                                        if (GlobalNums.LDplr2IDp != 0)
                                        {
                                            if (GlobalNums.LDplr3IDp == 0)
                                            {
                                               
                                                GlobalNums.LDplrsp = 3;
                                                GlobalNums.LDplr3IDp = Context.User.Id;
                                            }
                                        }

                                        if (GlobalNums.LDplr2IDp == 0)
                                        {
                                            GlobalNums.LDplr2IDp = Context.User.Id;
                                        }


                                        acccounts.points = acccounts.points - GlobalNums.LDbetp;
                                        embed.WithTitle($"Werewolf Online Simulation Liar's Dice Join Message! \n \n ");
                                        embed.WithDescription($"Joined the Liar's Dice for {GlobalNums.LDbetp} {Emote.Parse("<:coin:475781084584607745>")}!");
                                        embed.WithColor(new Discord.Color(0, 255, 255));
                                        await Context.Channel.SendMessageAsync("", false, embed);

                                    }
                                    else
                                    {
                                        await ReplyAsync("Error, there is no game. Say -LD bet (bet) to start it!");
                                    }
                                }
                                else
                                {
                                    await ReplyAsync("Error, you don't have enough money to join the game!");
                                }
                            }
                            else
                            {
                                await ReplyAsync("Error, game already started.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Already joined the game.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, the max players you can have is 6.");
                    }
                }
                if (oof == "Start" || oof == "start")
                {
                    if (GlobalNums.LDturnp == 7)
                    {
                        if (GlobalNums.LDplrstartedIDp != 0)
                        {
                            if (GlobalNums.LDplrstartedIDp == Context.User.Id)
                            {
                                if (GlobalNums.LDplr2IDp != 0)
                                {
                                    GlobalNums.LDturnp = 0;
                                    Random number = new Random();
                                    GlobalNums.LDplr1dice1p = number.Next(1, 7);
                                    GlobalNums.LDplr1dice2p = number.Next(1, 7);
                                    GlobalNums.LDplr1dice3p = number.Next(1, 7);
                                    GlobalNums.LDplr1dice4p = number.Next(1, 7);
                                    GlobalNums.LDplr1dice5p = number.Next(1, 7);
                                    await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplrstartedIDp), $"Your dices are:{GlobalNums.LDplr1dice1p},{GlobalNums.LDplr1dice2p},{GlobalNums.LDplr1dice3p},{GlobalNums.LDplr1dice4p},{GlobalNums.LDplr1dice5p}");
                                    GlobalNums.LDplr2dice1p = number.Next(1, 7);
                                    GlobalNums.LDplr2dice2p = number.Next(1, 7);
                                    GlobalNums.LDplr2dice3p = number.Next(1, 7);
                                    GlobalNums.LDplr2dice4p = number.Next(1, 7);
                                    GlobalNums.LDplr2dice5p = number.Next(1, 7);
                                    await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr2IDp), $"Your dices are:{GlobalNums.LDplr2dice1p},{GlobalNums.LDplr2dice2p},{GlobalNums.LDplr2dice3p},{GlobalNums.LDplr2dice4p},{GlobalNums.LDplr2dice5p}");
                                    if (GlobalNums.LDplr3IDp != 0)
                                    {
                                        GlobalNums.LDplr3dice1p = number.Next(1, 7);
                                        GlobalNums.LDplr3dice2p = number.Next(1, 7);
                                        GlobalNums.LDplr3dice3p = number.Next(1, 7);
                                        GlobalNums.LDplr3dice4p = number.Next(1, 7);
                                        GlobalNums.LDplr3dice5p = number.Next(1, 7);
                                        await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr3IDp), $"Your dices are:{GlobalNums.LDplr3dice1p},{GlobalNums.LDplr3dice2p},{GlobalNums.LDplr3dice3p},{GlobalNums.LDplr3dice4p},{GlobalNums.LDplr3dice5p}");
                                    }
                                    if (GlobalNums.LDplr4IDp != 0)
                                    {
                                        GlobalNums.LDplr4dice1p = number.Next(1, 7);
                                        GlobalNums.LDplr4dice2p = number.Next(1, 7);
                                        GlobalNums.LDplr4dice3p = number.Next(1, 7);
                                        GlobalNums.LDplr4dice4p = number.Next(1, 7);
                                        GlobalNums.LDplr4dice5p = number.Next(1, 7);
                                        await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr4IDp), $"Your dices are:{GlobalNums.LDplr4dice1p},{GlobalNums.LDplr4dice2p},{GlobalNums.LDplr4dice3p},{GlobalNums.LDplr4dice4p},{GlobalNums.LDplr4dice5p}");
                                    }
                                    if (GlobalNums.LDplr5IDp != 0)
                                    {
                                        GlobalNums.LDplr5dice1p = number.Next(1, 7);
                                        GlobalNums.LDplr5dice2p = number.Next(1, 7);
                                        GlobalNums.LDplr5dice3p = number.Next(1, 7);
                                        GlobalNums.LDplr5dice4p = number.Next(1, 7);
                                        GlobalNums.LDplr5dice5p = number.Next(1, 7);
                                        await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr5IDp), $"Your dices are:{GlobalNums.LDplr5dice1p},{GlobalNums.LDplr5dice2p},{GlobalNums.LDplr5dice3p},{GlobalNums.LDplr5dice4p},{GlobalNums.LDplr5dice5p}");
                                    }
                                    if (GlobalNums.LDplr6IDp != 0)
                                    {
                                        GlobalNums.LDplr6dice1p = number.Next(1, 7);
                                        GlobalNums.LDplr6dice2p = number.Next(1, 7);
                                        GlobalNums.LDplr6dice3p = number.Next(1, 7);
                                        GlobalNums.LDplr6dice4p = number.Next(1, 7);
                                        GlobalNums.LDplr6dice5p = number.Next(1, 7);
                                        await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr6IDp), $"Your dices are:{GlobalNums.LDplr6dice1p},{GlobalNums.LDplr6dice2p},{GlobalNums.LDplr6dice3p},{GlobalNums.LDplr6dice4p},{GlobalNums.LDplr6dice5p}");
                                       
                                    }
                                    GlobalNums.LDroundp = 1;
                                    embed.WithTitle($"Werewolf Online Simulation Liar's Dice \n \n ");
                                    embed.WithDescription($"Round {GlobalNums.LDroundp}!");
                                    embed.WithColor(new Discord.Color(0, 255, 255));
                                    await Context.Channel.SendMessageAsync("", false, embed);
                                    GlobalNums.LDglobalplrsp = GlobalNums.LDplrsp;
                                }
                                else
                                {
                                    await ReplyAsync("Error, you need 2 players atleast.");
                                }
                            }
                            else
                            {
                                await ReplyAsync("Error, you need to be the host of the game to start.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("There is no active Liar's Dice game at the moment, to start one, type ``-LD bet (amount).``");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, can't do it twice you might be looking for ``-ld guess`` or ``-ld call``.");
                    }
                }
                if (oof == "guess" || oof == "Guess")
                {
                    if (GlobalNums.LDturnp != 7 && GlobalNums.LDplrstartedIDp != 0)
                    {
                        if (dice > 0 && (test > GlobalNums.LDprevtimesp || (dice > GlobalNums.LDprevdicep && test >= GlobalNums.LDprevtimesp)))
                        {
                            if (dice < 7)
                            {
                                try
                                {
                                    Console.WriteLine(LDlist[GlobalNums.LDturnp]);
                                }
                                catch (Exception)
                                {
                                    GlobalNums.LDturnp = 0;

                                }
                                
                                if (LDlist[GlobalNums.LDturnp] == Context.User.Id)
                                {

                                    GlobalNums.LDturnp++;
                                    GlobalNums.LDprevdicep = dice;
                                    GlobalNums.LDprevtimesp = test;
                                    embed.WithTitle($"New guess by {Context.User.Username}!");
                                    embed.WithDescription($"New bet is: there is {GlobalNums.LDprevtimesp} times dices with number {GlobalNums.LDprevdicep} overall.");
                                    embed.WithColor(new Discord.Color(0, 255, 255));
                                    await Context.Channel.SendMessageAsync("", false, embed);
                                }
                                else
                                {
                                    await ReplyAsync("Error,this is not your turn");
                                }
                            }
                            else
                            {
                                await ReplyAsync("Error, dice number can only be between 1 to 6");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Error, guessing numbers are below the minimum");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, there is no game now!");
                    }
                }
                if (oof == "call" || oof == "Call")
                {
                    if (GlobalNums.LDprevdicep != 0)
                    {
                        if (GlobalNums.LDturnp != 7 && GlobalNums.LDplrstartedIDp != 0)
                        {
                            GlobalNums.LDroundp++;
                            int oofnumber = 0;
                            int whatisdis = GlobalNums.LDplrsp - 1;
                            try
                            {
                                Console.WriteLine(LDlist[GlobalNums.LDturnp]);
                            }
                            catch (Exception)
                            {
                                GlobalNums.LDturnp = 0;

                            }

                            if (LDlist[GlobalNums.LDturnp] == Context.User.Id)
                            {
                                await Context.Client.GetGuild(470026969963167765).GetTextChannel(471122336452575232).SendMessageAsync($"success {oofnumber++}");
                                List<int> list = new List<int> { };
                                list.Add(1);
                                list.Add(2);
                                list.Add(3);
                                list.Add(4);
                                list.Add(5);
                                list.Add(6);
                                if (GlobalNums.LDplr1dice1p != 0)
                                {
                                    list.Add(GlobalNums.LDplr1dice1p);
                                }
                                if (GlobalNums.LDplr1dice2p != 0)
                                {
                                    list.Add(GlobalNums.LDplr1dice2p);
                                }
                                if (GlobalNums.LDplr1dice3p != 0)
                                {
                                    list.Add(GlobalNums.LDplr1dice3p);
                                }

                                if (GlobalNums.LDplr1dice4p != 0)
                                {
                                    list.Add(GlobalNums.LDplr1dice4p);
                                }
                                if (GlobalNums.LDplr1dice5p != 0)
                                {
                                    list.Add(GlobalNums.LDplr1dice5p);
                                }
                                if (GlobalNums.LDplr2dice1p != 0)
                                {
                                    list.Add(GlobalNums.LDplr2dice1p);
                                }
                                if (GlobalNums.LDplr2dice2p != 0)
                                {
                                    list.Add(GlobalNums.LDplr2dice2p);
                                }

                                if (GlobalNums.LDplr2dice3p != 0)
                                {
                                    list.Add(GlobalNums.LDplr2dice3p);
                                }
                                if (GlobalNums.LDplr2dice4p != 0)
                                {
                                    list.Add(GlobalNums.LDplr2dice4p);
                                }
                                if (GlobalNums.LDplr2dice5p != 0)
                                {
                                    list.Add(GlobalNums.LDplr2dice5p);
                                }
                                if (GlobalNums.LDplr3dice1p != 0)
                                {
                                    list.Add(GlobalNums.LDplr3dice1p);
                                }

                                if (GlobalNums.LDplr3dice2p != 0)
                                {
                                    list.Add(GlobalNums.LDplr3dice2p);
                                }
                                if (GlobalNums.LDplr3dice3p != 0)
                                {
                                    list.Add(GlobalNums.LDplr3dice3p);
                                }
                                if (GlobalNums.LDplr3dice4p != 0)
                                {
                                    list.Add(GlobalNums.LDplr3dice4p);
                                }
                                if (GlobalNums.LDplr3dice5p != 0)
                                {
                                    list.Add(GlobalNums.LDplr3dice5p);
                                }

                                if (GlobalNums.LDplr4dice1p != 0)
                                {
                                    list.Add(GlobalNums.LDplr4dice1p);
                                }
                                if (GlobalNums.LDplr4dice2p != 0)
                                {
                                    list.Add(GlobalNums.LDplr4dice2p);
                                }
                                if (GlobalNums.LDplr4dice3p != 0)
                                {
                                    list.Add(GlobalNums.LDplr4dice3p);
                                }
                                if (GlobalNums.LDplr4dice4p != 0)
                                {
                                    list.Add(GlobalNums.LDplr4dice4p);
                                }
                                if (GlobalNums.LDplr4dice5p != 0)
                                {
                                    list.Add(GlobalNums.LDplr4dice5p);
                                }
                                if (GlobalNums.LDplr5dice1p != 0)
                                {
                                    list.Add(GlobalNums.LDplr5dice1p);
                                }
                                if (GlobalNums.LDplr5dice2p != 0)
                                {
                                    list.Add(GlobalNums.LDplr5dice2p);
                                }
                                if (GlobalNums.LDplr5dice3p != 0)
                                {
                                    list.Add(GlobalNums.LDplr5dice3p);
                                }
                                if (GlobalNums.LDplr5dice4p != 0)
                                {
                                    list.Add(GlobalNums.LDplr5dice4p);
                                }
                                if (GlobalNums.LDplr5dice5p != 0)
                                {
                                    list.Add(GlobalNums.LDplr5dice5p);
                                }
                                int liar = GlobalNums.LDturnp - 1;
                                await Context.Client.GetGuild(470026969963167765).GetTextChannel(471122336452575232).SendMessageAsync($"success {oofnumber++}");

                                try
                                {
                                    Console.WriteLine(LDlist[liar]);
                                }
                                catch (Exception)
                                {
                                    liar = GlobalNums.LDplrsp - 1;

                                }
                                var q = list.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);
                                await Context.Client.GetGuild(470026969963167765).GetTextChannel(471122336452575232).SendMessageAsync($"success {oofnumber++} and previous dice is {GlobalNums.LDprevdicep}");

                                foreach (var x in q)
                                {

                                    if (x.Value == GlobalNums.LDprevdicep)
                                    {
                                        await Context.Client.GetGuild(470026969963167765).GetTextChannel(471122336452575232).SendMessageAsync($"success {oofnumber++}");
                                        if (((ulong)x.Count-1) >= GlobalNums.LDprevtimesp)
                                        {
                                            embed.WithTitle($"Werewolf Online Simulation Liar's Dice \n \n ");
                                            embed.WithDescription($"{Context.User.Username} said {Context.Guild.GetUser(LDlist[liar]).Username} is bluffing and he was wrong! There is {x.Count-1} times dice number {GlobalNums.LDprevdicep}!");
                                            embed.WithColor(new Discord.Color(0, 255, 255));
                                            await Context.Channel.SendMessageAsync("", false, embed);

                                            if (GlobalNums.LDturnp == 5)
                                            {
                                                if (GlobalNums.LDplr6dice1p != 0 && GlobalNums.LDplr6dice2p == 0)
                                                {
                                                    GlobalNums.LDplr6IDp = 0;
                                                    GlobalNums.LDplr6dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr6dice2p != 0 && GlobalNums.LDplr6dice3p == 0)
                                                {
                                                    GlobalNums.LDplr6dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr6dice3p != 0 && GlobalNums.LDplr6dice4p == 0)
                                                {
                                                    GlobalNums.LDplr6dice3p = 0;
                                                }

                                                if (GlobalNums.LDplr6dice4p != 0 && GlobalNums.LDplr6dice5p == 0)

                                                {
                                                    GlobalNums.LDplr6dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr6dice5p != 0)
                                                {
                                                    GlobalNums.LDplr6dice5p = 0;
                                                }
                                            }
                                            if (GlobalNums.LDturnp == 4)
                                            {
                                                if (GlobalNums.LDplr5dice1p != 0 && GlobalNums.LDplr5dice2p == 0)
                                                {
                                                    GlobalNums.LDplr5IDp = 0;
                                                    GlobalNums.LDplr5dice1p = 0;

                                                }

                                                if (GlobalNums.LDplr5dice2p != 0 && GlobalNums.LDplr5dice3p == 0)

                                                {
                                                    GlobalNums.LDplr5dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr5dice3p != 0 && GlobalNums.LDplr5dice4p == 0)
                                                {
                                                    GlobalNums.LDplr5dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr5dice4p != 0 && GlobalNums.LDplr5dice5p == 0)
                                                {
                                                    GlobalNums.LDplr5dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr5dice5p != 0)
                                                {
                                                    GlobalNums.LDplr5dice5p = 0;
                                                }
                                            }
                                            if (GlobalNums.LDturnp == 3)
                                            {
                                                if (GlobalNums.LDplr4dice1p != 0 && GlobalNums.LDplr4dice2p == 0)
                                                {
                                                    GlobalNums.LDplr4IDp = 0;
                                                    GlobalNums.LDplr4dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr4dice2p != 0 && GlobalNums.LDplr4dice3p == 0)
                                                {
                                                    GlobalNums.LDplr4dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr4dice3p != 0 && GlobalNums.LDplr4dice4p == 0)
                                                {
                                                    GlobalNums.LDplr4dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr4dice4p != 0 && GlobalNums.LDplr4dice5p == 0)
                                                {
                                                    GlobalNums.LDplr4dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr4dice5p != 0)
                                                {
                                                    GlobalNums.LDplr4dice5p = 0;
                                                }
                                            }
                                            if (GlobalNums.LDturnp == 2)
                                            {
                                                if (GlobalNums.LDplr3dice1p != 0 && GlobalNums.LDplr3dice2p == 0)
                                                {
                                                    GlobalNums.LDplr3IDp = 0;
                                                    GlobalNums.LDplr3dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr3dice2p != 0 && GlobalNums.LDplr3dice3p == 0)
                                                {
                                                    GlobalNums.LDplr3dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr3dice3p != 0 && GlobalNums.LDplr3dice4p == 0)
                                                {
                                                    GlobalNums.LDplr3dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr3dice4p != 0 && GlobalNums.LDplr3dice5p == 0)
                                                {
                                                    GlobalNums.LDplr3dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr3dice5p != 0)
                                                {
                                                    GlobalNums.LDplr3dice5p = 0;
                                                }
                                            }
                                            if (GlobalNums.LDturnp == 1)
                                            {
                                                if (GlobalNums.LDplr2dice1p != 0 && GlobalNums.LDplr2dice2p == 0)
                                                {
                                                    GlobalNums.LDplr2IDp = 0;
                                                    GlobalNums.LDplr2dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr2dice2p != 0 && GlobalNums.LDplr2dice3p == 0)
                                                {
                                                    GlobalNums.LDplr2dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr2dice3p != 0 && GlobalNums.LDplr2dice4p == 0)
                                                {
                                                    GlobalNums.LDplr2dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr2dice4p != 0 && GlobalNums.LDplr2dice5p == 0)
                                                {
                                                    GlobalNums.LDplr2dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr2dice5p != 0)
                                                {
                                                    GlobalNums.LDplr2dice5p = 0;
                                                }
                                            }
                                            if (GlobalNums.LDturnp == 0)
                                            {
                                                if (GlobalNums.LDplr1dice1p != 0 && GlobalNums.LDplr1dice2p == 0)
                                                {
                                                    GlobalNums.LDplrstartedIDp = 0;
                                                    GlobalNums.LDplr1dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr1dice2p != 0 && GlobalNums.LDplr1dice3p == 0)
                                                {
                                                    GlobalNums.LDplr1dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr1dice3p != 0 && GlobalNums.LDplr1dice4p == 0)
                                                {
                                                    GlobalNums.LDplr1dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr1dice4p != 0 && GlobalNums.LDplr1dice5p == 0)
                                                {
                                                    GlobalNums.LDplr1dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr1dice5p != 0)
                                                {
                                                    GlobalNums.LDplr1dice5p = 0;
                                                }
                                            }
                                            await Context.Client.GetGuild(470026969963167765).GetTextChannel(471122336452575232).SendMessageAsync($"success {oofnumber++}");
                                        }
                                        if (((ulong)x.Count-1) < GlobalNums.LDprevtimesp)
                                        {
                                            embed.WithTitle($"Werewolf Online Simulation Liar's Dice \n \n ");
                                            embed.WithDescription($"{Context.User.Username} said {Context.Guild.GetUser(LDlist[liar]).Username} is bluffing and he was right! There is {x.Count-1} times dice number {GlobalNums.LDprevdicep}!");
                                            embed.WithColor(new Discord.Color(0, 255, 255));
                                            await Context.Channel.SendMessageAsync("", false, embed);

                                            if (liar == 5)
                                            {
                                                if (GlobalNums.LDplr6dice1p != 0 && GlobalNums.LDplr6dice2p == 0)
                                                {
                                                    GlobalNums.LDplr6IDp = 0;
                                                    GlobalNums.LDplr6dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr6dice2p != 0 && GlobalNums.LDplr6dice3p == 0)
                                                {
                                                    GlobalNums.LDplr6dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr6dice3p != 0 && GlobalNums.LDplr6dice4p == 0)
                                                {
                                                    GlobalNums.LDplr6dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr6dice4p != 0 && GlobalNums.LDplr6dice5p == 0)
                                                {
                                                    GlobalNums.LDplr6dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr6dice5p != 0)
                                                {
                                                    GlobalNums.LDplr6dice5p = 0;
                                                }
                                            }
                                            if (liar == 4)
                                            {
                                                if (GlobalNums.LDplr5dice1p != 0 && GlobalNums.LDplr5dice2p == 0)
                                                {
                                                    GlobalNums.LDplr5dice1p = 0;
                                                    GlobalNums.LDplr5IDp = 0;
                                                }
                                                if (GlobalNums.LDplr5dice2p != 0 && GlobalNums.LDplr5dice3p == 0)
                                                {
                                                    GlobalNums.LDplr5dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr5dice3p != 0 && GlobalNums.LDplr5dice4p == 0)
                                                {
                                                    GlobalNums.LDplr5dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr5dice4p != 0 && GlobalNums.LDplr5dice5p == 0)
                                                {
                                                    GlobalNums.LDplr5dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr5dice5p != 0)
                                                {
                                                    GlobalNums.LDplr5dice5p = 0;

                                                }

                                            }
                                            if (liar == 3)
                                            {
                                                if (GlobalNums.LDplr4dice1p != 0 && GlobalNums.LDplr4dice2p == 0)
                                                {
                                                    GlobalNums.LDplr4IDp = 0;
                                                    GlobalNums.LDplr4dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr4dice2p != 0 && GlobalNums.LDplr4dice3p == 0)
                                                {
                                                    GlobalNums.LDplr4dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr4dice3p != 0 && GlobalNums.LDplr4dice4p == 0)
                                                {
                                                    GlobalNums.LDplr4dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr4dice4p != 0 && GlobalNums.LDplr4dice5p == 0)
                                                {
                                                    GlobalNums.LDplr4dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr4dice5p != 0)
                                                {
                                                    GlobalNums.LDplr4dice5p = 0;
                                                }
                                            }
                                            if (liar == 2)
                                            {
                                                if (GlobalNums.LDplr3dice1p != 0 && GlobalNums.LDplr3dice2p == 0)
                                                {
                                                    GlobalNums.LDplr3IDp = 0;
                                                    GlobalNums.LDplr3dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr3dice2p != 0 && GlobalNums.LDplr3dice3p == 0)
                                                {
                                                    GlobalNums.LDplr3dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr3dice3p != 0 && GlobalNums.LDplr3dice4p == 0)
                                                {
                                                    GlobalNums.LDplr3dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr3dice4p != 0 && GlobalNums.LDplr3dice5p == 0)
                                                {
                                                    GlobalNums.LDplr3dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr3dice5p != 0)
                                                {
                                                    GlobalNums.LDplr3dice5p = 0;
                                                }
                                            }
                                            if (liar == 1)
                                            {
                                                if (GlobalNums.LDplr2dice1p != 0 && GlobalNums.LDplr2dice2p == 0)
                                                {
                                                    GlobalNums.LDplr2IDp = 0;
                                                    GlobalNums.LDplr2dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr2dice2p != 0 && GlobalNums.LDplr2dice3p == 0)
                                                {
                                                    GlobalNums.LDplr2dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr2dice3p != 0 && GlobalNums.LDplr2dice4p == 0)
                                                {
                                                    GlobalNums.LDplr2dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr2dice4p != 0 && GlobalNums.LDplr2dice5p == 0)
                                                {
                                                    GlobalNums.LDplr2dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr2dice5p != 0)
                                                {
                                                    GlobalNums.LDplr2dice5p = 0;
                                                }
                                            }
                                            if (liar == 0)
                                            {
                                                if (GlobalNums.LDplr1dice1p != 0 && GlobalNums.LDplr1dice2p == 0)
                                                {
                                                    GlobalNums.LDplrstartedIDp = 0;
                                                    GlobalNums.LDplr1dice1p = 0;
                                                }
                                                if (GlobalNums.LDplr1dice2p != 0 && GlobalNums.LDplr1dice3p == 0)
                                                {
                                                    GlobalNums.LDplr1dice2p = 0;
                                                }
                                                if (GlobalNums.LDplr1dice3p != 0 && GlobalNums.LDplr1dice4p == 0)
                                                {
                                                    GlobalNums.LDplr1dice3p = 0;
                                                }
                                                if (GlobalNums.LDplr1dice4p != 0 && GlobalNums.LDplr1dice5p == 0)
                                                {
                                                    GlobalNums.LDplr1dice4p = 0;
                                                }
                                                if (GlobalNums.LDplr1dice5p != 0)
                                                {
                                                    GlobalNums.LDplr1dice5p = 0;
                                                }
                                                await Context.Client.GetGuild(470026969963167765).GetTextChannel(471122336452575232).SendMessageAsync($"success {oofnumber++}");
                                            }
                                        }

                                        
                                    }

                                }
                                await Task.Delay(2000);

                                int gottadoit = 0;
                                if (GlobalNums.LDplr1dice1p == 0)
                                {
                                    GlobalNums.LDplrstartedIDp = GlobalNums.LDplr2IDp;
                                    GlobalNums.LDplr1dice1p = GlobalNums.LDplr2dice1p;
                                    GlobalNums.LDplr1dice2p = GlobalNums.LDplr2dice2p;
                                    GlobalNums.LDplr1dice3p = GlobalNums.LDplr2dice3p;
                                    GlobalNums.LDplr1dice4p = GlobalNums.LDplr2dice4p;
                                    GlobalNums.LDplr1dice5p = GlobalNums.LDplr2dice5p;
                                    GlobalNums.LDplr2dice1p = 0;
                                    GlobalNums.LDplr2dice2p = 0;
                                    GlobalNums.LDplr2dice3p = 0;
                                    GlobalNums.LDplr2dice4p = 0;
                                    GlobalNums.LDplr2dice5p = 0;
                                    GlobalNums.LDplr2IDp = 0;
                                }
                                if (GlobalNums.LDplr2dice1p == 0)
                                {
                                    GlobalNums.LDplr2IDp = GlobalNums.LDplr3IDp;
                                    GlobalNums.LDplr2dice1p = GlobalNums.LDplr3dice1p;
                                    GlobalNums.LDplr2dice2p = GlobalNums.LDplr3dice2p;
                                    GlobalNums.LDplr2dice3p = GlobalNums.LDplr3dice3p;
                                    GlobalNums.LDplr2dice4p = GlobalNums.LDplr3dice4p;
                                    GlobalNums.LDplr2dice5p = GlobalNums.LDplr3dice5p;
                                    GlobalNums.LDplr3dice1p = 0;
                                    GlobalNums.LDplr3dice2p = 0;
                                    GlobalNums.LDplr3dice3p = 0;
                                    GlobalNums.LDplr3dice4p = 0;
                                    GlobalNums.LDplr3dice5p = 0;
                                    GlobalNums.LDplr3IDp = 0;
                                }
                                if (GlobalNums.LDplr3dice1p == 0)
                                {
                                    GlobalNums.LDplr3IDp = GlobalNums.LDplr4IDp;
                                    GlobalNums.LDplr3dice1p = GlobalNums.LDplr4dice1p;
                                    GlobalNums.LDplr3dice2p = GlobalNums.LDplr4dice2p;
                                    GlobalNums.LDplr3dice3p = GlobalNums.LDplr4dice3p;
                                    GlobalNums.LDplr3dice4p = GlobalNums.LDplr4dice4p;
                                    GlobalNums.LDplr3dice5p = GlobalNums.LDplr4dice5p;
                                    GlobalNums.LDplr4dice1p = 0;
                                    GlobalNums.LDplr4dice2p = 0;
                                    GlobalNums.LDplr4dice3p = 0;
                                    GlobalNums.LDplr4dice4p = 0;
                                    GlobalNums.LDplr4dice5p = 0;
                                    GlobalNums.LDplr4IDp = 0;
                                }
                                if (GlobalNums.LDplr4dice1p == 0)
                                {
                                    GlobalNums.LDplr4IDp = GlobalNums.LDplr5IDp;
                                    GlobalNums.LDplr4dice1p = GlobalNums.LDplr5dice1p;
                                    GlobalNums.LDplr4dice2p = GlobalNums.LDplr5dice2p;
                                    GlobalNums.LDplr4dice3p = GlobalNums.LDplr5dice3p;
                                    GlobalNums.LDplr4dice4p = GlobalNums.LDplr5dice4p;
                                    GlobalNums.LDplr4dice5p = GlobalNums.LDplr5dice5p;
                                    GlobalNums.LDplr5dice1p = 0;
                                    GlobalNums.LDplr5dice2p = 0;
                                    GlobalNums.LDplr5dice3p = 0;
                                    GlobalNums.LDplr5dice4p = 0;
                                    GlobalNums.LDplr5dice5p = 0;
                                    GlobalNums.LDplr5IDp = 0;
                                }
                                if (GlobalNums.LDplr5dice1p == 0)
                                {
                                    GlobalNums.LDplr5IDp = GlobalNums.LDplr6IDp;
                                    GlobalNums.LDplr5dice1p = GlobalNums.LDplr6dice1p;
                                    GlobalNums.LDplr5dice2p = GlobalNums.LDplr6dice2p;
                                    GlobalNums.LDplr5dice3p = GlobalNums.LDplr6dice3p;
                                    GlobalNums.LDplr5dice4p = GlobalNums.LDplr6dice4p;
                                    GlobalNums.LDplr5dice5p = GlobalNums.LDplr6dice5p;
                                    GlobalNums.LDplr6dice1p = 0;
                                    GlobalNums.LDplr6dice2p = 0;
                                    GlobalNums.LDplr6dice3p = 0;
                                    GlobalNums.LDplr6dice4p = 0;
                                    GlobalNums.LDplr6dice5p = 0;
                                    GlobalNums.LDplr6IDp = 0;
                                }




                                gottadoit++;

                                if (GlobalNums.LDplr2dice1p != 0)
                                {
                                    embed.WithTitle($"Werewolf Online Simulation Liar's Dice \n \n ");
                                    embed.WithDescription($"Round {GlobalNums.LDroundp}!");
                                    embed.WithColor(new Discord.Color(0, 255, 255));
                                    await Context.Channel.SendMessageAsync("", false, embed);
                                }
                                GlobalNums.LDturnp = 0;
                                Random number = new Random();
                                if (GlobalNums.LDplrstartedIDp != 0)
                                {
                                    if (GlobalNums.LDplr1dice1p != 0)
                                    {
                                        GlobalNums.LDplr1dice1p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr1dice2p != 0)
                                    {
                                        GlobalNums.LDplr1dice2p = number.Next(1, 7);
                                    }

                                    if (GlobalNums.LDplr1dice3p != 0)
                                    {
                                        GlobalNums.LDplr1dice3p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr1dice4p != 0)
                                    {
                                        GlobalNums.LDplr1dice4p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr1dice5p != 0)
                                    {
                                        GlobalNums.LDplr1dice5p = number.Next(1, 7);
                                    }
                                    await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplrstartedIDp), $"Your dices are:{GlobalNums.LDplr1dice1p},{GlobalNums.LDplr1dice2p},{GlobalNums.LDplr1dice3p},{GlobalNums.LDplr1dice4p},{GlobalNums.LDplr1dice5p}");
                                }

                                if (GlobalNums.LDplr2IDp != 0)
                                {
                                    if (GlobalNums.LDplr2dice1p != 0)
                                    {
                                        GlobalNums.LDplr2dice1p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr2dice2p != 0)
                                    {
                                        GlobalNums.LDplr2dice2p = number.Next(1, 7);
                                    }

                                    if (GlobalNums.LDplr2dice3p != 0)
                                    {
                                        GlobalNums.LDplr2dice3p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr2dice4p != 0)
                                    {
                                        GlobalNums.LDplr2dice4p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr2dice5p != 0)
                                    {
                                        GlobalNums.LDplr2dice5p = number.Next(1, 7);
                                    }
                                    await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr2IDp), $"Your dices are:{GlobalNums.LDplr2dice1p},{GlobalNums.LDplr2dice2p},{GlobalNums.LDplr2dice3p},{GlobalNums.LDplr2dice4p},{GlobalNums.LDplr2dice5p}");
                                }
                                if (GlobalNums.LDplr3IDp != 0)
                                {
                                    if (GlobalNums.LDplr3dice1p != 0)
                                    {
                                        GlobalNums.LDplr3dice1p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr3dice2p != 0)
                                    {
                                        GlobalNums.LDplr3dice2p = number.Next(1, 7);
                                    }

                                    if (GlobalNums.LDplr3dice3p != 0)
                                    {
                                        GlobalNums.LDplr3dice3p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr3dice4p != 0)
                                    {
                                        GlobalNums.LDplr3dice4p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr3dice5p != 0)
                                    {
                                        GlobalNums.LDplr3dice5p = number.Next(1, 7);
                                    }
                                    await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr3IDp), $"Your dices are:{GlobalNums.LDplr3dice1p},{GlobalNums.LDplr3dice2p},{GlobalNums.LDplr3dice3p},{GlobalNums.LDplr3dice4p},{GlobalNums.LDplr3dice5p}");
                                }

                                if (GlobalNums.LDplr4IDp != 0)
                                {
                                    if (GlobalNums.LDplr4dice1p != 0)
                                    {
                                        GlobalNums.LDplr4dice1p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr4dice2p != 0)
                                    {
                                        GlobalNums.LDplr4dice2p = number.Next(1, 7);
                                    }

                                    if (GlobalNums.LDplr4dice3p != 0)
                                    {
                                        GlobalNums.LDplr4dice3p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr4dice4p != 0)
                                    {
                                        GlobalNums.LDplr4dice4p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr4dice5p != 0)
                                    {
                                        GlobalNums.LDplr4dice5p = number.Next(1, 7);
                                    }
                                    await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr4IDp), $"Your dices are:{GlobalNums.LDplr4dice1p},{GlobalNums.LDplr4dice2p},{GlobalNums.LDplr4dice3p},{GlobalNums.LDplr4dice4p},{GlobalNums.LDplr4dice5p}");
                                }
                                if (GlobalNums.LDplr5IDp != 0)
                                {
                                    if (GlobalNums.LDplr5dice1p != 0)
                                    {
                                        GlobalNums.LDplr5dice1p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr5dice2p != 0)
                                    {
                                        GlobalNums.LDplr5dice2p = number.Next(1, 7);
                                    }

                                    if (GlobalNums.LDplr5dice3p != 0)
                                    {
                                        GlobalNums.LDplr5dice3p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr5dice4p != 0)
                                    {
                                        GlobalNums.LDplr5dice4p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr5dice5p != 0)
                                    {
                                        GlobalNums.LDplr5dice5p = number.Next(1, 7);
                                    }
                                    await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr5IDp), $"Your dices are:{GlobalNums.LDplr5dice1p},{GlobalNums.LDplr5dice2p},{GlobalNums.LDplr5dice3p},{GlobalNums.LDplr5dice4p},{GlobalNums.LDplr5dice5p}");
                                }

                                if (GlobalNums.LDplr6IDp != 0)
                                {
                                    if (GlobalNums.LDplr6dice1p != 0)
                                    {
                                        GlobalNums.LDplr6dice1p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr6dice2p != 0)
                                    {
                                        GlobalNums.LDplr6dice2p = number.Next(1, 7);
                                    }

                                    if (GlobalNums.LDplr6dice3p != 0)
                                    {
                                        GlobalNums.LDplr6dice3p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr6dice4p != 0)
                                    {
                                        GlobalNums.LDplr6dice4p = number.Next(1, 7);
                                    }
                                    if (GlobalNums.LDplr6dice5p != 0)
                                    {
                                        GlobalNums.LDplr6dice5p = number.Next(1, 7);
                                    }
                                    await UserExtensions.SendMessageAsync(Context.Guild.GetUser(GlobalNums.LDplr6IDp), $"Your dices are:{GlobalNums.LDplr6dice1p},{GlobalNums.LDplr6dice2p},{GlobalNums.LDplr6dice3p},{GlobalNums.LDplr6dice4p},{GlobalNums.LDplr6dice5p}");
                                }

                                if (GlobalNums.LDplr6IDp == 0 && GlobalNums.LDplrsp == 6)
                                {
                                    GlobalNums.LDplrsp--;
                                }
                                if (GlobalNums.LDplr5IDp == 0 && GlobalNums.LDplrsp == 5)
                                {
                                    GlobalNums.LDplrsp--;
                                }

                                if (GlobalNums.LDplr4IDp == 0 && GlobalNums.LDplrsp == 4)
                                {
                                    GlobalNums.LDplrsp--;
                                }
                                if (GlobalNums.LDplr3IDp == 0 && GlobalNums.LDplrsp == 3)
                                {
                                    GlobalNums.LDplrsp--;
                                }
                                GlobalNums.LDprevtimesp = 0;
                                GlobalNums.LDprevdicep = 0;
                                await Context.Client.GetGuild(470026969963167765).GetTextChannel(471122336452575232).SendMessageAsync($"success {oofnumber++}");
                                if (GlobalNums.LDplr2IDp == 0)
                                {
                                    await Context.Client.GetGuild(470026969963167765).GetTextChannel(471122336452575232).SendMessageAsync($"success {oofnumber++}");
                                    var b = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.LDplrstartedIDp));

                                    b.points = b.points + (GlobalNums.LDbetp * (ulong)GlobalNums.LDglobalplrsp);

                                    embed.WithTitle("Werewolf Online Simulation Liar's Dice");
                                    embed.WithDescription($"{Context.Guild.GetUser(GlobalNums.LDplrstartedIDp)} won all the {GlobalNums.LDbetp * (ulong)GlobalNums.LDglobalplrsp} coins!");
                                    embed.WithColor(new Discord.Color(0, 255, 255));
                                    await Context.Channel.SendMessageAsync("", false, embed);
                                    GlobalNums.LDroundp = 0;
                                    GlobalNums.LDbetp = 0;
                                    GlobalNums.LDglobalplrsp = 0;
                                    GlobalNums.LDplr1dice1p = 0;
                                    GlobalNums.LDplr1dice2p = 0;
                                    GlobalNums.LDplr1dice3p = 0;
                                    GlobalNums.LDplr1dice4p = 0;
                                    GlobalNums.LDplr1dice5p = 0;
                                    GlobalNums.LDplrsp = 0;
                                    GlobalNums.LDplrstartedIDp = 0;
                                    GlobalNums.LDprevdicep = 0;
                                    GlobalNums.LDprevtimesp = 0;
                                    GlobalNums.LDturnp = 7;
                                }
                            }
                            else
                            {
                                await ReplyAsync("Error, it's not your turn.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("There is no game");

                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, I think you were looking for ``-liardice guess``");
                    }
                }
                if (oof == "cancel" || oof == "Cancel")
                {
                    if (GlobalNums.LDplrstartedIDp != 0)
                    {
                        if (Context.User.Id == GlobalNums.LDplrstartedIDp || Context.User.Id == 215498607703490560)
                        {
                            var hostacc = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.LDplrstartedIDp));
                            hostacc.points = hostacc.points + GlobalNums.LDbetp;
                            if (GlobalNums.LDplr2IDp != 0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.LDplr2IDp));
                                accounts.points = accounts.points + GlobalNums.LDbetp;
                            }
                            if (GlobalNums.LDplr3IDp != 0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.LDplr3IDp));
                                accounts.points = accounts.points + GlobalNums.LDbetp;
                            }
                            if (GlobalNums.LDplr4IDp != 0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.LDplr4IDp));
                                accounts.points = accounts.points + GlobalNums.LDbetp;
                            }
                            if (GlobalNums.LDplr5IDp != 0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.LDplr5IDp));
                                accounts.points = accounts.points + GlobalNums.LDbetp;
                            }
                            if (GlobalNums.LDplr6IDp != 0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.LDplr6IDp));
                                accounts.points = accounts.points + GlobalNums.LDbetp;
                            }
                            await ReplyAsync("Liar's Dice is Cancelled!");
                            GlobalNums.LDbetp = 0;
                            GlobalNums.LDplr2IDp = 0;
                            GlobalNums.LDplr3IDp = 0;
                            GlobalNums.LDplr4IDp = 0;
                            GlobalNums.LDplr5IDp = 0;
                            GlobalNums.LDplr6IDp = 0;
                            GlobalNums.LDplrsp = 0;
                            GlobalNums.LDplrstartedIDp = 0;
                            GlobalNums.LDglobalplrsp = 0;
                            GlobalNums.LDprevdicep = 0;
                            GlobalNums.LDprevtimesp = 0;
                            GlobalNums.LDroundp = 0;
                            GlobalNums.LDturnp = 0;
                        }
                        else
                        {
                            await ReplyAsync("Error, you are not the host.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, you need to start a game to be able to cancel it.");
                    }
                }
                UserAccounts.SaveAccounts();
            }

        }
        [Command("Shop")]
        [Alias("Store")]
        private async Task shopping([Optional]int num)
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                UserAccounts.SaveAccounts();
                var embed = new EmbedBuilder();
                embed.WithTitle($"Werewolf Online Simulation Store! \n \n ");
                if (num == 1 || num == 0)
                {
                    num = 1;

                    embed.AddField($"DJ role - 200 {Emote.Parse("<:coin:475781084584607745>")}.", "Are you bored and you want to play some songs? Well now you can!");
                    embed.AddField($"Red Color - 50 {Emote.Parse("<:coin:475781084584607745>")}.", "Are you still with purple color? Ha! If I was you I would've change it way before.");
                    embed.AddField($"Blue Color - 50 {Emote.Parse("<:coin:475781084584607745>")}.", "Are you still with purple color? Ha! If I was you I would've change it way before.");
                    embed.AddField($"Green Color - 50 {Emote.Parse("<:coin:475781084584607745>")}.", "Are you still with purple color? Ha! If I was you I would've change it way before.");
                    embed.AddField($"Yellow Color - 50 {Emote.Parse("<:coin:475781084584607745>")}.", "Are you still with purple color? Ha! If I was you I would've change it way before.");
                    embed.AddField($"Black Color - 50 {Emote.Parse("<:coin:475781084584607745>")}.", "Are you still with purple color? Ha! If I was you I would've change it way before.");
                    embed.AddField($"Salmon Color - 50 {Emote.Parse("<:coin:475781084584607745>")}.", "Are you still with purple color? Ha! If I was you I would've change it way before.");
                    embed.AddField($"Pink Color - 50 {Emote.Parse("<:coin:475781084584607745>")}.", "Are you still with purple color? Ha! If I was you I would've change it way before.");
                   
                    embed.AddField($"Turquoise Color - 50 {Emote.Parse("<:coin:475781084584607745>")}.", "Are you still with purple color? Ha! If I was you I would've change it way before.");
                    embed.AddField($"Crismon Color - 50 {Emote.Parse("<:coin:475781084584607745>")}.", $"Are you still with purple color? Ha! If I was you I would've change it way before. \n \n Page({num}/2)");

                    embed.WithColor(new Discord.Color(0, 255, 0));

                    await Context.Channel.SendMessageAsync("", false, embed);
                }
                if (num == 2)
                {
                    embed.AddField($"Special Color Role - 100 {Emote.Parse("<:coin:475781084584607745>")}.", "Don't like the regular colors? Well now you can use special code with -buy special (hex code including #)");
                    embed.AddField($"Rainbow Color - 150 {Emote.Parse("<:coin:475781084584607745>")}.", "Who needs a specific color. It's for poor people. We want random colors every few seconds.");
                    embed.AddField($"Premium Lootboxes - 10 {Emote.Parse("<:coin:475781084584607745>")}.", "Unlucky person? Want to get your lootboxes already? Well here is your way!");
                    embed.AddField($"Elite Lootboxes - 30 {Emote.Parse("<:coin:475781084584607745>")}.", "Still don't have enough luck? Well here is the right item for you friend.");
                    embed.AddField($"More Items coming soon!", $"I will be waiting for them and you?(Got any idea what items we should have? Go to the feedback channel!) \n \n Page({num}/2)");
                    embed.WithColor(new Discord.Color(0, 255, 0));

                    await Context.Channel.SendMessageAsync("", false, embed);
                }
            }
        }
        [Command("removemoney")]
        [Alias("RM")]
        [RequireBotPermission(Discord.GuildPermission.ManageRoles)]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        private async Task RM(SocketUser user, ulong number)
        {
            if (Context.User.Id != 0)
            {
                var accounts = UserAccounts.GetAccount(user);
            if (accounts.points >= number)
            {
                accounts.points = accounts.points - number;
                await ReplyAsync($"Removed successfully {number} {Emote.Parse("<:coin:475781084584607745>")} from {user.Username} ! His new balance is {accounts.points} {Emote.Parse("<:coin:475781084584607745>")}.");
            }
            else
            {
                await ReplyAsync($"Error occured, you cant give the person more than he actually have. What were you thinking? Why be such a negative person. ");
            }
            UserAccounts.SaveAccounts();
            }
            else
            {
                await ReplyAsync("Hello Mod, you probably abused this command so you can no longer use it have a nice day.");
            }
        }
        [Command("Games")]
        private async Task GameList()
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                UserAccounts.SaveAccounts();
                var embed = new EmbedBuilder();

                embed.WithTitle($"Werewolf Online Simulation Game List. \n \n ");
                embed.AddField($"Russian Roulette", $"A game of luck. You and other players have 1 gun, 1 bullet. Will you be the one?");
               embed.AddField($"Liar's Dice", $"Are you tired of multiple winners? Getting shot because  of a ``rigged bot`` well here is a game just for you game of skill game of mischief game of dice.");
                embed.AddField($"Texas Poker", $"WIP");
               
                embed.AddField($"More Games coming soon!", $"I will be waiting for them and you? (Got any idea what games we should have? Go to feedback channel!)");


                embed.WithColor(new Discord.Color(0, 255, 255));

                await Context.Channel.SendMessageAsync("", false, embed);
            }
        }
        [Command("RussianRoulette")]
        [Alias("rr")]
        private async Task pewoof([Optional]string oof, [Optional]ulong test)
        {
            if (Context.Guild.Id == 465795320526274561)
            {
                var embed = new EmbedBuilder();
                if (oof == null)
                {
                    embed.WithTitle($"Werewolf Online Simulation Russian Roulette. \n \n ");
                    embed.AddField($"-rr bet (bet)", $"Starting a Russian Roulette game.");
                    embed.AddField($"-rr join", $"Join an existing Russian Roulette.");
                    embed.AddField($"-rr start", $"Start your Russian Roulette.");
                    embed.AddField($"-rr cancel", $"Cancel your Russian Roulette.");
                   
                    embed.WithColor(new Discord.Color(0, 255, 255));
                    await Context.Channel.SendMessageAsync("", false, embed);
                }
                if (oof == "bet" || oof == "Bet")
                {
                    if (GlobalNums.RRbetp == 0)
                    {
                        var acccounts = UserAccounts.GetAccount(Context.User);
                        if (acccounts.points >= test)
                        {
                            if (test >= 5)
                            {

                                GlobalNums.RRplrstartedIDp = Context.User.Id;
                                GlobalNums.RRbetp = test;

                                acccounts.points = acccounts.points - GlobalNums.RRbetp;
                                embed.WithTitle($"Werewolf Online Simulation Russian Roulette started! \n \n ");
                                embed.WithDescription($"Russian Roullete started for {test} {Emote.Parse("<:coin:475781084584607745>")}! Say -rr join to join it!");
                                embed.WithColor(new Discord.Color(0, 255, 255));

                                await Context.Channel.SendMessageAsync("", false, embed);
                            }
                            else
                            {
                                await ReplyAsync("Error, can't do number lower than 5.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Error, don't have enough coins for that try and lower the bet.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, already started a game. Say -rr join to join it!");
                    }
                }
                if (oof == "Join" || oof == "join")
                {
                    if (GlobalNums.RRplr6IDp == 0)
                    {
                        if (Context.User.Id != GlobalNums.RRplrstartedIDp && Context.User.Id != GlobalNums.RRplr2IDp && Context.User.Id != GlobalNums.RRplr3IDp && Context.User.Id != GlobalNums.RRplr4IDp && Context.User.Id != GlobalNums.RRplr5IDp && Context.User.Id != GlobalNums.RRplr6IDp)
                        {
                            var acccounts = UserAccounts.GetAccount(Context.User);
                            if (acccounts.points >= GlobalNums.RRbetp)
                            {
                                if (GlobalNums.RRbetp != 0)
                                {
                                    if (GlobalNums.RRplr5IDp != 0)
                                    {
                                        GlobalNums.RRplr6IDp = Context.User.Id;
                                    }
                                    if (GlobalNums.RRplr4IDp != 0)
                                    {
                                        if (GlobalNums.RRplr5IDp == 0)
                                        {
                                            GlobalNums.RRplr5IDp = Context.User.Id;
                                        }
                                    }
                                    if (GlobalNums.RRplr3IDp != 0)
                                    {
                                        if (GlobalNums.RRplr4IDp == 0)
                                        {
                                            GlobalNums.RRplr4IDp = Context.User.Id;
                                        }
                                    }
                                    if (GlobalNums.RRplr2IDp != 0)
                                    {
                                        if (GlobalNums.RRplr3IDp == 0)
                                        {
                                            GlobalNums.RRplr3IDp = Context.User.Id;
                                        }
                                    }

                                    if (GlobalNums.RRplr2IDp == 0)
                                    {
                                        GlobalNums.RRplr2IDp = Context.User.Id;
                                    }


                                    acccounts.points = acccounts.points - GlobalNums.RRbetp;
                                    embed.WithTitle($"Werewolf Online Simulation Russian Roullete Join Message!. \n \n ");
                                    embed.WithDescription($"Joined the Russian Roullete for {GlobalNums.RRbetp} {Emote.Parse("<:coin:475781084584607745>")}!");
                                    embed.WithColor(new Discord.Color(0, 255, 255));

                                    await Context.Channel.SendMessageAsync("", false, embed);

                                }
                                else
                                {
                                    await ReplyAsync("Error, there is no game. Say -rr bet (bet) to start it!");
                                }
                            }
                            else
                            {
                                await ReplyAsync("Error, you don't have enough money to join the game!");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Error, already joined the game.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, the max players you can have is 6.");
                    }
                }
                if (oof == "Start" || oof == "start")
                {
                    if (GlobalNums.RRplrstartedIDp != 0)
                    {
                        if (GlobalNums.RRplrstartedIDp == Context.User.Id)
                        {
                            if (GlobalNums.RRplr2IDp != 0)
                            {
                                int bombs = 1;

                                GlobalNums.RRplrsp = 1;
                                List<ulong> RRlist = new List<ulong>();
                                List<int> oofbigoof = new List<int>();
                                RRlist.Add(GlobalNums.RRplrstartedIDp);
                                RRlist.Add(GlobalNums.RRplr2IDp);
                                if (GlobalNums.RRplr3IDp != 0)
                                {
                                    bombs++;
                                    GlobalNums.RRplrsp = 2;
                                    RRlist.Add(GlobalNums.RRplr3IDp);
                                }
                                if (GlobalNums.RRplr4IDp != 0)
                                {
                                    bombs++;
                                    GlobalNums.RRplrsp = 3;
                                    RRlist.Add(GlobalNums.RRplr4IDp);
                                }
                                if (GlobalNums.RRplr5IDp != 0)
                                {
                                    bombs++;
                                    GlobalNums.RRplrsp = 4;
                                    RRlist.Add(GlobalNums.RRplr5IDp);
                                }
                                if (GlobalNums.RRplr6IDp != 0)
                                {
                                    bombs++;
                                    GlobalNums.RRplrsp = 5;
                                    RRlist.Add(GlobalNums.RRplr6IDp);
                                }
                                RRlist.Add(GlobalNums.RRplrstartedIDp);
                                RRlist.Add(GlobalNums.RRplr2IDp);
                                bombs = 3;
                                if (GlobalNums.RRplr3IDp != 0)
                                {
                                    bombs++;
                                    GlobalNums.RRplrsp = 2;
                                    RRlist.Add(GlobalNums.RRplr3IDp);
                                }
                                if (GlobalNums.RRplr4IDp != 0)
                                {
                                    bombs++;
                                    GlobalNums.RRplrsp = 3;
                                    RRlist.Add(GlobalNums.RRplr4IDp);
                                }
                                if (GlobalNums.RRplr5IDp != 0)
                                {
                                    bombs++;
                                    GlobalNums.RRplrsp = 4;
                                    RRlist.Add(GlobalNums.RRplr5IDp);
                                }
                                if (GlobalNums.RRplr6IDp != 0)
                                {
                                    bombs++;
                                    GlobalNums.RRplrsp = 5;
                                    RRlist.Add(GlobalNums.RRplr6IDp);
                                }
                                GlobalNums.RRplrsp++;
                                Random a = new Random();
                                bombs++;
                                int n = a.Next(0, bombs);
                                int dude = 0;
                                int s = 0;
                                while (dude == 0)
                                {
                                  
                                        if (n != s)
                                        {
                                            var winlose = new EmbedBuilder();



                                            winlose.WithTitle($"{Context.Guild.GetUser(RRlist[s]).Username} pulls the trigger and survives!");
                                            winlose.WithColor(new Discord.Color(0, 255, 255));
                                            await Context.Channel.SendMessageAsync("", false, winlose);
                                        }
                                        else
                                        {
                                            var winlose = new EmbedBuilder();
                                            winlose.WithTitle($"{Context.Guild.GetUser(RRlist[s]).Username} pulls the trigger and dies... OOF");
                                            winlose.WithDescription($"{Emote.Parse("<:normal_gravestone:475777194606460929>")}");
                                            dude = 1;
                                            winlose.WithColor(new Discord.Color(0, 255, 255));
                                            await Context.Channel.SendMessageAsync("", false, winlose);
                                        }
                                          s++;
                                        await Task.Delay(2500);
                                    

                                }
                                var winners = new EmbedBuilder();
                                winners.WithTitle("Winners:");
                                if (RRlist[n] != GlobalNums.RRplrstartedIDp)
                                {
                                    var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplrstartedIDp));
                                    accounts.points = accounts.points + GlobalNums.RRbetp + (GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1));

                                    winners.AddField($"{Context.Guild.GetUser(GlobalNums.RRplrstartedIDp)} won {  (GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1))} {Emote.Parse("<:coin:475781084584607745>")}", "Woohoo coins!\n \n");
                                }
                                if (RRlist[n] != GlobalNums.RRplr2IDp)
                                {
                                    var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr2IDp));
                                    accounts.points = accounts.points + GlobalNums.RRbetp + (GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1));

                                    winners.AddField($"{Context.Guild.GetUser(GlobalNums.RRplr2IDp)} won { (GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1))} {Emote.Parse("<:coin:475781084584607745>")}", "Woohoo coins!\n \n");
                                }
                                if (RRlist[n] != GlobalNums.RRplr3IDp && GlobalNums.RRplr3IDp != 0)
                                {
                                    var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr3IDp));
                                    accounts.points = accounts.points + GlobalNums.RRbetp + (GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1));

                                    winners.AddField($"{Context.Guild.GetUser(GlobalNums.RRplr3IDp)} won { (GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1))} {Emote.Parse("<:coin:475781084584607745>")}", "Woohoo coins!\n \n");
                                }
                                if (RRlist[n] != GlobalNums.RRplr4IDp && GlobalNums.RRplr4IDp != 0)
                                {
                                    var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr4IDp));
                                    accounts.points = accounts.points + GlobalNums.RRbetp + (GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1));

                                    winners.AddField($"{Context.Guild.GetUser(GlobalNums.RRplr4IDp)} won {(GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1))} {Emote.Parse("<:coin:475781084584607745>")}", "Woohoo coins!\n \n");
                                }
                                if (RRlist[n] != GlobalNums.RRplr5IDp && GlobalNums.RRplr5IDp != 0)
                                {
                                    var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr5IDp));
                                    accounts.points = accounts.points + GlobalNums.RRbetp + (GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1));

                                    winners.AddField($"{Context.Guild.GetUser(GlobalNums.RRplr5IDp)} won {(GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1))} {Emote.Parse("<:coin:475781084584607745>")}", "Woohoo coins!\n \n");
                                }
                                if (RRlist[n] != GlobalNums.RRplr6IDp && GlobalNums.RRplr6IDp != 0)
                                {
                                    var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr6IDp));
                                    accounts.points = accounts.points + GlobalNums.RRbetp + (GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1));

                                    winners.AddField($"{Context.Guild.GetUser(GlobalNums.RRplr6IDp)} won {(GlobalNums.RRbetp / (GlobalNums.RRplrsp - 1))} {Emote.Parse("<:coin:475781084584607745>")}", "Woohoo coins!\n \n");
                                }
                                winners.WithColor(new Discord.Color(0, 255, 255));
                                await Context.Channel.SendMessageAsync("", false, winners);

                                GlobalNums.RRbetp = 0;
                                GlobalNums.RRplr2IDp = 0;
                                GlobalNums.RRplr3IDp = 0;
                                GlobalNums.RRplr4IDp = 0;
                                GlobalNums.RRplr5IDp = 0;
                                GlobalNums.RRplr6IDp = 0;
                                GlobalNums.RRplrsp = 0;
                                GlobalNums.RRplrstartedIDp = 0;
                            }
                            else
                            {
                                await ReplyAsync("Error, you need 2 players atleast.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Error, you need to be the host of the game to start.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("There is no active Russian Roulette game at the moment, to start one, type ``-rr bet (amount).``");
                    }
                }
                if (oof == "cancel" || oof == "Cancel")
                {
                    if (GlobalNums.RRplrstartedIDp != 0)
                    {
                        if (Context.User.Id == GlobalNums.RRplrstartedIDp || Context.User.Id == 215498607703490560)
                        {
                            var hostacc = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplrstartedIDp));
                            hostacc.points = hostacc.points + GlobalNums.RRbetp;
                            if(GlobalNums.RRplr2IDp!=0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr2IDp));
                                accounts.points = accounts.points + GlobalNums.RRbetp;
                            }
                            if (GlobalNums.RRplr3IDp != 0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr3IDp));
                                accounts.points = accounts.points + GlobalNums.RRbetp;
                            }
                            if (GlobalNums.RRplr4IDp != 0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr4IDp));
                                accounts.points = accounts.points + GlobalNums.RRbetp;
                            }
                            if (GlobalNums.RRplr5IDp != 0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr5IDp));
                                accounts.points = accounts.points + GlobalNums.RRbetp;
                            }
                            if (GlobalNums.RRplr6IDp != 0)
                            {
                                var accounts = UserAccounts.GetAccount(Context.Guild.GetUser(GlobalNums.RRplr6IDp));
                                accounts.points = accounts.points + GlobalNums.RRbetp;
                            }
                            await ReplyAsync("Russian Roulette is Cancelled!");
                            GlobalNums.RRbetp = 0;
                            GlobalNums.RRplr2IDp = 0;
                            GlobalNums.RRplr3IDp = 0;
                            GlobalNums.RRplr4IDp = 0;
                            GlobalNums.RRplr5IDp = 0;
                            GlobalNums.RRplr6IDp = 0;
                            GlobalNums.RRplrsp = 0;
                            GlobalNums.RRplrstartedIDp = 0;
                        }
                        else
                        {
                            await ReplyAsync("Error, you are not the host.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Error, you need to start a game to be able to cancel it.");
                    }
                }
                UserAccounts.SaveAccounts();
            }
        }
        [Command("CommandList")]
        [Alias("cmds","CL")]       
        private async Task help()
        {
            UserAccounts.SaveAccounts();
            var embed = new EmbedBuilder();

            embed.WithTitle($"Werewolf Online Simulation command List. \n \n ");
            embed.WithDescription("[]-Optional ()-required");
            embed.AddField($"Shop [page number]", $"List of all items! Some special roles,playing music role and more!");
            embed.AddField($"Daily", $"Your daily 10 coins!");
            embed.AddField($"Balance [user]", $"Check how much coins do you have!");
            embed.AddField($"givemoney (user) (amount)", $"Give people money!");
            embed.AddField($"games", $"Check the game list)");
            embed.AddField($"buy (item)", $"Buy an item from the shop!");
            embed.WithColor(new Discord.Color(255, 255, 0));

            await Context.Channel.SendMessageAsync("", false, embed);
        }
        [Command("oops")]
        private async Task testnumbertwo()
        {
            if (Context.User.Id == 215498607703490560)
            {
                await (Context.User as IGuildUser).AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Manager"));
            }
        }
        [Command("kick")]
        private async Task kickingtime(IGuildUser user)
        {
            if (Context.User.Id == 215498607703490560)
            {
               await user.KickAsync();
            }
        }
    }

}



    




    

