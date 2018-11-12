using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class test : ModuleBase<SocketCommandContext>
    {
        
        [Command("results")]
        private async Task results()
        {
           
            await ReplyAsync(GlobalNums.resultswinp);
            await ReplyAsync(GlobalNums.resultslosep);
            GlobalNums.resultswinp = "";
            GlobalNums.resultslosep = "";
        }
        [Command("sect")]
        private async Task OHNOITSTHESL(int num)
        {
            if (Context.User.Id != GlobalNums.previousjailed)
            {
                var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == num + "");
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(user))
                    {
                        var cuser = Context.User;
                        OverwritePermissions overwriteperms = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Deny, readMessageHistory: PermValue.Allow);
                        if ((cuser as IGuildUser).Nickname != user.Nickname)
                        {
                            if (Context.Channel.Id == 478163714349203456)
                            {
                                if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                {
                                    GlobalNums.secttargetp = num;
                                    await Context.Message.AddReactionAsync(Emote.Parse("<:Sect_Member:475775737526353933>"));
                                }
                            }
                        }
                    }
                }
            }
        }
        [Command("murder")]
        private async Task OHNOITSTHESK(int user)
        {
            if (Context.User.Id != GlobalNums.previousjailed)
            {
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                {
                    if (Context.Channel.Id == 472689742350254081)
                    {
                        GlobalNums.skillp = user;
                        await Context.Message.AddReactionAsync(Emote.Parse("<:Serial_Killer_Knife:475774672458350602>"));

                    }
                }
                else
                {
                    await ReplyAsync("Sorry, only alive users can do that.");
                }
            }
        }
        [Command("day")]
        [RequireBotPermission(Discord.GuildPermission.ManageRoles)]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        private async Task morninggggg(int shalomyeladim)
        {
            if (Context.Guild.Id == 472261911526768642)
            {
                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Day:475774207683198987>") + "Day " + shalomyeladim + "  has started. Get ready to discuss!");
              
                GlobalNums.votetimep = 0;
               
                HttpClient dude = new HttpClient();
                var clonestream = new MemoryStream();
                Stream stream = await dude.GetStreamAsync("https://cdn.discordapp.com/attachments/470026969963167767/474664247100571678/Logopit_1533238665529.jpg");
                stream.CopyTo(clonestream);
                Image pic = new Image(clonestream);
                clonestream.Position = 0;
                await Context.Guild.ModifyAsync(x => x.Icon = pic);
                GlobalNums.plr1p = 1;
                GlobalNums.plr2p = 1;
                GlobalNums.plr3p = 0;
                GlobalNums.plr4p = 1;
                GlobalNums.plr5p = 1;
                GlobalNums.plr6p = 1;
                GlobalNums.plr7p = 1;
                GlobalNums.plr8p = 1;
                GlobalNums.plr9p = 1;
                GlobalNums.plr10p = 0;
                GlobalNums.plr11p = 0;
                GlobalNums.plr12p = 1;
                GlobalNums.plr13p = 1;
                GlobalNums.plr14p = 0;
                GlobalNums.plr15p = 1;
                GlobalNums.plr16p = 1;



                GlobalNums.daystartedp = 1;
                OverwritePermissions overwriteperms = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Allow, readMessageHistory: PermValue.Allow);
                await Context.Client.GetGuild(472261911526768642).GetTextChannel(472263845289918465).AddPermissionOverwriteAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"), overwriteperms.Modify());

                if (GlobalNums.mediumtargetp != 0)
                {

                    GlobalNums.revivesp--;
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The medium revived " + Context.Guild.GetUser(GlobalNums.mediumtargetp).Nickname + " last night!");
                    await Context.Guild.GetUser(GlobalNums.mediumtargetp).AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                    await Context.Guild.GetUser(GlobalNums.mediumtargetp).RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                    var user = Context.Guild.GetUser(GlobalNums.mediumtargetp);
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                    {

                        GlobalNums.plr3vp = 17;
                    }

                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                    {

                        GlobalNums.plr7vp = 17;
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                    {

                        GlobalNums.plr1vp = 17;
                    }


                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                    {

                        GlobalNums.plr5vp = 17;
                    }

                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                    {

                        GlobalNums.plr8vp = 17;
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                    {
                        GlobalNums.plr9vp = 17;
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                    {
                        GlobalNums.plr10vp = 17;
                    }


                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                    {

                        GlobalNums.plr14vp = 17;
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                    {
                        GlobalNums.plr16vp = 17;
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                    {
                        GlobalNums.plr12vp = 17;
                    }
                    GlobalNums.mediumtargetp = 0;
                }
                GlobalNums.votetimep = 0;

                List<int> wolflist = new List<int> { };

                if (GlobalNums.plr4vp != 0)
                {
                    wolflist.Add(GlobalNums.plr4vp);

                }
                if (GlobalNums.plr6vp != 0)
                {
                    wolflist.Add(GlobalNums.plr6vp);
                }
                if (GlobalNums.plr11vp != 0)
                {
                    wolflist.Add(GlobalNums.plr11vp);
                }
                if (GlobalNums.plr15vp != 0)
                {
                    if (GlobalNums.plr11vp == 0)
                    {
                        if (GlobalNums.plr6vp == 0)
                        {
                            wolflist.Add(GlobalNums.plr15vp);
                        }
                    }
                }
                var q = wolflist.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);
                var c = q.Max(x => x.Count);

                int dah = 0;
                foreach (var x in q)
                {
                    var v = x.Value;

                    if (x.Count == c)
                    {
                        if (v != 17)
                        {
                            if (dah >= 0)
                            {


                                GlobalNums.votetargetp = v;
                                if (dah == 1)
                                {
                                    GlobalNums.votetargetp = GlobalNums.plr6vp;
                                    if (GlobalNums.plr6vp == 17)
                                    {
                                        GlobalNums.votetargetp = GlobalNums.plr4vp;
                                    }
                                    if (GlobalNums.plr6vp == 0)
                                    {
                                        GlobalNums.votetargetp = GlobalNums.plr4vp;
                                    }
                                }
                                dah++;

                            }


                        }

                    }

                }

                if (GlobalNums.votetargetp != 17)
                {
                    if (GlobalNums.votetargetp != 0)
                    {
                        if (GlobalNums.doctorprotectp != GlobalNums.votetargetp)
                        {
                            if (GlobalNums.bholdp != GlobalNums.votetargetp)
                            {
                                if (GlobalNums.bgprotectp != GlobalNums.votetargetp)
                                {

                                    var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.votetargetp + "");
                                    if (user.Id != GlobalNums.previousjailed)
                                    {


                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                                        {
                                            GlobalNums.plr3vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Jailer)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                                        {
                                            GlobalNums.plr7vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Seer)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                                        {
                                            GlobalNums.plr6vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Alpha Werewolf)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                                        {
                                            GlobalNums.plr16vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolf killed " + user.Nickname + "!(Seer)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                                        {
                                            GlobalNums.plr1vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Aura Seer)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                                        {
                                            GlobalNums.plr2vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Medium)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                                        {
                                            GlobalNums.plr4vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves betrayed " + user.Nickname + " the Werewolf!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                                        {
                                            GlobalNums.plr5vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Doctor)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                                        {
                                            GlobalNums.plr8vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Fool)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                                        {
                                            GlobalNums.plr8vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Headhunter)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                                        {
                                            if (GlobalNums.bgselfprotectp == 0)
                                            {
                                                GlobalNums.plr9vp = 0;
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Bodyguard)");
                                            }
                                            else
                                            {
                                                GlobalNums.bgselfprotectp--;
                                                GlobalNums.votetargetp = 17;
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472689623127031808).SendMessageAsync("You fought off an attack last night, next time you will be attacked you will die");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync("Your target couldn't be killed!");
                                            }
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                                        {
                                            GlobalNums.plr10vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Gunner)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                                        {
                                            GlobalNums.plr11vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Shaman Werewolf)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                                        {
                                            GlobalNums.votetargetp = 17;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync("Your target couldn't be killed!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                                        {
                                            GlobalNums.plr14vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Priest)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                                        {
                                            GlobalNums.plr15vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Wolf Seer)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                                        {
                                            GlobalNums.plr12vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Aura Seer)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                                        {
                                            GlobalNums.plr3vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Beast Hunter)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                                        {
                                            GlobalNums.plr7vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Seer)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                                        {
                                            GlobalNums.plr15vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Wolf Seer)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                        {
                                            GlobalNums.plr16vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolf killed " + user.Nickname + "!(Medium)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                                        {
                                            GlobalNums.plr1vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Aura Seer)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                                        {
                                            GlobalNums.plr2vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Mayor)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                                        {
                                            GlobalNums.plr6vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Werewolf)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                                        {
                                            GlobalNums.plr5vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Doctor)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                                        {
                                            GlobalNums.plr8vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Fool)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                                        {
                                            GlobalNums.plr8vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Headhunter)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                                        {
                                            if (GlobalNums.bgselfprotectp == 0)
                                            {
                                                GlobalNums.plr9vp = 0;
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Bodyguard)");
                                            }
                                            else
                                            {
                                                GlobalNums.bgselfprotectp--;
                                                GlobalNums.votetargetp = 17;
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(478163499525079050).SendMessageAsync("You fought off an attack last night, next time you will be attacked you will die");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync("Your target couldn't be killed!");
                                            }
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                        {
                                            GlobalNums.plr10vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Gunner)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                                        {
                                            GlobalNums.plr11vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Alpha Werewolf)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                                        {
                                            GlobalNums.votetargetp = 17;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync("Your target couldn't be killed!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                                        {
                                            GlobalNums.plr14vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Cupid)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                                        {
                                            GlobalNums.sectdeadp = 1;
                                            GlobalNums.plr13vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Sect Leader)");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                                        {
                                            GlobalNums.plr12vp = 0;
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + user.Nickname + "!(Jailer)");
                                        }
                                        if (GlobalNums.votetargetp != 17)
                                        {
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sectdeadp==1)
                                        {
                                            if (GlobalNums.sect1p!=0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect1p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect1p + " committed suicide.(Aura Seer)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect2p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect2p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect2p + " committed suicide.(Mayor)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect3p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect3p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect3p + " committed suicide.(Beast Hunter)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect4p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect4p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect4p + " committed suicide.(Doctor)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect5p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect5p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect5p + " committed suicide.(Seer)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect6p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect6p + "");
                                                if (GlobalNums.hhfoolsp == 1)
                                                {
                                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect6p + " committed suicide.(Headhunter)");
                                                }
                                                if (GlobalNums.hhfoolsp == 1)
                                                {
                                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect6p + " committed suicide.(Fool)");
                                                }
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect7p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect7p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect7p + " committed suicide.(Bodyguard)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect8p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect8p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect8p + " committed suicide.(Gunner)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect9p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect9p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect9p + " committed suicide.(Jailer)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect10p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect10p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect10p + " committed suicide.(Cupid)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                            if (GlobalNums.sect11p != 0)
                                            {
                                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect11p + "");
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect11p + " committed suicide.(Medium)");
                                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (GlobalNums.bgselfprotectp == 1)
                                    {
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync("Your target couldn't be killed!");
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Nobody was killed by Werewolf last night!");
                                        GlobalNums.bgselfprotectp--;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472689623127031808).SendMessageAsync("You fought off an attack last night, next time you will be attacked you will die");
                                    }
                                    if (GlobalNums.bgselfprotectp == 0)
                                    {
                                        var myman = Context.Guild.GetUser(GlobalNums.bgsuicidep);
                                        await myman.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        await myman.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Werewolves killed " + myman.Nickname + "!(Bodyguard)");

                                    }
                                }
                            }
                            else
                            {
                                int snakeeee = 0;
                                Random b = new Random();
                                int neck = 0;
                                while (snakeeee == 0)
                                {
                                    neck = b.Next(1, 5);
                                    if (neck == 1)
                                    {
                                        if (GlobalNums.plr15vp != 0)
                                        {
                                            snakeeee++;
                                            var ws = Context.Guild.GetUser(GlobalNums.wsidp);
                                            if (GlobalNums.doctorprotectp + "" != ws.Nickname)
                                            {
                                                await ws.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                                await ws.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ws.Nickname + " (Wolf Seer) was killed by Beast Hunter trap!");
                                                GlobalNums.plr15vp = 0;
                                            }
                                        }
                                    }
                                    if (neck == 2)
                                    {
                                        if (GlobalNums.plr6vp != 0)
                                        {
                                            snakeeee++;
                                            var ww = Context.Guild.GetUser(GlobalNums.wwidp);
                                            if (GlobalNums.doctorprotectp + "" != ww.Nickname)
                                            {
                                                await ww.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                                await ww.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ww.Nickname + " (Werewolf) was killed by Beast Hunter trap!");
                                                GlobalNums.plr6vp = 0;
                                            }
                                        }
                                    }
                                    if (neck == 3)
                                    {
                                        if (GlobalNums.plr4vp != 0)
                                        {
                                            snakeeee++;
                                            var jww = Context.Guild.GetUser(GlobalNums.jwwidp);
                                            if (GlobalNums.doctorprotectp + "" != jww.Nickname)
                                            {
                                                await jww.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                                await jww.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(jww.Nickname + " (Junior Werewolf) was killed by Beast Hunter trap!");
                                                GlobalNums.plr4vp = 0;
                                                if (GlobalNums.jwwidp != 0)
                                                {
                                                    var users = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.jwwtargetp + "");
                                                    await users.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                                    await users.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                                                    {
                                                        GlobalNums.plr3vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Beast Hunter) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                                                    {
                                                        GlobalNums.plr7vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + users.Nickname + "!(Seer)");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                                                    {
                                                        GlobalNums.plr15vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + users.Nickname + "!(Wolf Seer)");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                                    {
                                                        GlobalNums.plr16vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Medium) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                                                    {
                                                        GlobalNums.plr1vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Aura Seer) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                                                    {
                                                        GlobalNums.plr2vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Mayor) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                                                    {
                                                        GlobalNums.plr6vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + users.Nickname + "!(Werewolf)");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                                                    {
                                                        GlobalNums.plr5vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Doctor) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                                                    {
                                                        GlobalNums.plr8vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Fool) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                                                    {
                                                        GlobalNums.plr8vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Headhunter) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                                                    {
                                                        GlobalNums.plr9vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Bodyguard) is dead!");

                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                                    {
                                                        GlobalNums.plr10vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Gunner) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                                                    {
                                                        GlobalNums.plr11vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + users.Nickname + "!(Alpha Werewolf)");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                                                    {
                                                        GlobalNums.plr13vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Arsonist) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                                                    {
                                                        GlobalNums.plr14vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Cupid) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                                                    {
                                                        GlobalNums.plr13vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Sect Leader) is dead!");
                                                    }
                                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                                                    {
                                                        GlobalNums.plr12vp = 0;
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Jailer) is dead!");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (neck == 4)
                                    {
                                        if (GlobalNums.plr11vp != 0)
                                        {
                                            snakeeee++;
                                            var aww = Context.Guild.GetUser(GlobalNums.awwidp);
                                            if (GlobalNums.doctorprotectp + "" != aww.Nickname)
                                            {
                                                await aww.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                                await aww.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(aww.Nickname + " (Alpha Werewolf) was killed by Beast Hunter trap!");
                                                GlobalNums.plr11vp = 0;
                                            }
                                        }
                                    }
                                }


                            }
                        }
                        else
                        {
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync("Your target couldn't be killed!");
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Nobody was killed by Werewolf last night!");
                        }
                    }
                    else
                    {
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Nobody was killed by Werewolf last night!");
                    }
                }
                else
                {
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Nobody was killed by Werewolf last night!");
                }
             
                if (GlobalNums.plr4vp != 0)
                {
                    GlobalNums.plr4vp = 17;
                }
                if (GlobalNums.plr6vp != 0)
                {
                    GlobalNums.plr6vp = 17;
                }
                if (GlobalNums.plr11vp != 0)
                {
                    GlobalNums.plr11vp = 17;
                }
                if (GlobalNums.plr15vp != 0)
                {
                    GlobalNums.plr15vp = 17;
                }
                GlobalNums.votetargetp = 17;
            }
           if (GlobalNums.bhnewp!=0)
            {
                GlobalNums.bholdp = GlobalNums.bhnewp;
            }
            if (GlobalNums.skillp != 0)
            {
                if (GlobalNums.doctorprotectp != GlobalNums.skillp)
                {
                    if (GlobalNums.bgselfprotectp != GlobalNums.skillp)
                    {


                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.skillp + "");
                        if (GlobalNums.previousjailed != user.Id)
                        {
                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));

                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                            {
                                GlobalNums.plr3vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Jailer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                            {
                                GlobalNums.plr7vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                            {
                                GlobalNums.plr6vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Alpha Werewolf)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                            {
                                GlobalNums.plr16vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                            {
                                GlobalNums.plr1vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Aura Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                            {
                                GlobalNums.plr2vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Medium)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                            {
                                GlobalNums.plr4vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Werewolf)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                            {
                                GlobalNums.plr5vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Doctor)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                            {
                                GlobalNums.plr8vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Fool)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                            {
                                GlobalNums.plr8vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Headhunter)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                            {
                                if (GlobalNums.bgselfprotectp == 0)
                                {
                                    GlobalNums.plr9vp = 0;
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Bodyguard)");
                                }
                                else
                                {
                                    GlobalNums.bgselfprotectp--;
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472689623127031808).SendMessageAsync("You fought off an attack last night, next time you will be attacked you will die");
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472689742350254081).SendMessageAsync("Your target couldn't be killed!");
                                }
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                            {
                                GlobalNums.plr10vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Gunner)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                            {
                                GlobalNums.plr11vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Shaman Werewolf)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                            {
                                GlobalNums.plr13vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " got bored and killed himself lololol rip SK. This why you dont drink or you will aim the knife to yourself rip.");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                            {
                                GlobalNums.plr14vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Priest)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                            {
                                GlobalNums.plr15vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Wolf Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                            {
                                GlobalNums.plr12vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Aura Seer)");
                            }
                        }
                        else
                        {
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472689742350254081).SendMessageAsync("Your target couldn't get killed!");
                        }
                    }
                    else
                    {
                        var user = Context.Guild.GetUser(GlobalNums.bgsuicidep);
                        if (GlobalNums.bgselfprotectp == 0)
                        {
                            GlobalNums.plr9vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Serial Killer stabbed " + user.Nickname + "!(Bodyguard)");
                        }
                        else
                        {
                            GlobalNums.bgselfprotectp--;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472689623127031808).SendMessageAsync("You fought off an attack last night, next time you will be attacked you will die");
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472689742350254081).SendMessageAsync("Your target couldn't be killed!");
                        }
                    }
                }
                else
                {
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472689742350254081).SendMessageAsync("Your target couldn't be killed!");
                }
               
            }
            if (GlobalNums.lover1p != 0 && GlobalNums.lover2p != 0)
            {
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(Context.Guild.GetUser(GlobalNums.lover1p)))
                {
                    var user = Context.Guild.GetUser(GlobalNums.lover2p);
                    await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                    await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                    {
                        GlobalNums.plr3vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Beast Hunter) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                    {
                        GlobalNums.plr4vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Junior Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                    {
                        GlobalNums.plr7vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Seer) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                    {
                        GlobalNums.plr15vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Wolf Seer) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                    {
                        GlobalNums.plr16vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Medium) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                    {
                        GlobalNums.plr1vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Aura Seer) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                    {
                        GlobalNums.plr2vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Mayor) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                    {
                        GlobalNums.plr6vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                    {
                        GlobalNums.plr5vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Doctor) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                    {
                        GlobalNums.plr8vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Fool) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                    {
                        GlobalNums.plr8vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Headhunter) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                    {

                        GlobalNums.plr9vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Bodyguard) lost the love of his life and committed suicide.");



                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                    {
                        GlobalNums.plr10vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Gunner) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                    {
                        GlobalNums.plr11vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Alpha Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                    {
                        GlobalNums.plr13vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Arsonist) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                    {
                        GlobalNums.plr14vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Cupid) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                    {
                        GlobalNums.plr13vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Sect Leader) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                    {
                        GlobalNums.plr12vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Jailer) lost the love of his life and committed suicide.");
                    }
                }
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(Context.Guild.GetUser(GlobalNums.lover2p)))
                {
                    var user = Context.Guild.GetUser(GlobalNums.lover1p);
                    await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                    await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                    {
                        GlobalNums.plr3vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Beast Hunter) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                    {
                        GlobalNums.plr4vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Junior Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                    {
                        GlobalNums.plr7vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Seer) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                    {
                        GlobalNums.plr15vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Wolf Seer) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                    {
                        GlobalNums.plr16vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Medium) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                    {
                        GlobalNums.plr1vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Aura Seer) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                    {
                        GlobalNums.plr2vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Mayor) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                    {
                        GlobalNums.plr6vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                    {
                        GlobalNums.plr5vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Doctor) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                    {
                        GlobalNums.plr8vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Fool) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                    {
                        GlobalNums.plr8vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Headhunter) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                    {

                        GlobalNums.plr9vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Bodyguard) lost the love of his life and committed suicide.");



                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                    {
                        GlobalNums.plr10vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Gunner) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                    {
                        GlobalNums.plr11vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Alpha Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                    {
                        GlobalNums.plr13vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Arsonist) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                    {
                        GlobalNums.plr14vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Cupid) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                    {
                        GlobalNums.plr13vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Sect Leader) lost the love of his life and committed suicide.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                    {
                        GlobalNums.plr12vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Jailer) lost the love of his life and committed suicide.");
                    }
                }
            }
            if (GlobalNums.previousjailed != 0)
            {
                await Context.Client.GetGuild(472261911526768642).GetTextChannel(473846749174169600).RemovePermissionOverwriteAsync(Context.Guild.GetUser(GlobalNums.previousjailed));
                GlobalNums.previousjailed = 0;
            }
            if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.Guild.GetUser(GlobalNums.sectidp)))
            {
                if (GlobalNums.secttargetp != 0)
                {
                    int num = GlobalNums.secttargetp;
                    var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.secttargetp + "");
                    OverwritePermissions overwriteperms = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Deny, readMessageHistory: PermValue.Allow);
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304)).SendMessages)
                    {
                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456).SendMessageAsync("Your target can't join the sect.");
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                    {
                        if (GlobalNums.sect11p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            GlobalNums.sect11p = num;
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                    {

                        if (GlobalNums.sect10p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                            GlobalNums.sect10p = num;
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                    {
                        if (GlobalNums.sect9p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                            GlobalNums.sect9p = num;
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                    {
                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                        if (GlobalNums.sect8p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                            GlobalNums.sect8p = num;
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                    {
                        if (GlobalNums.sect7p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                            GlobalNums.sect7p = num;
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                    {
                        if (GlobalNums.sect6p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                            GlobalNums.sect6p = num;
                        }

                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                    {
                        if (GlobalNums.sect6p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                            GlobalNums.sect6p = num;
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                    {
                        if (GlobalNums.sect5p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            GlobalNums.sect5p = num;
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                    {
                        if (GlobalNums.sect4p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            GlobalNums.sect4p = num;
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                    {
                        if (GlobalNums.sect3p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            GlobalNums.sect3p = num;
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                    {
                        if (GlobalNums.sect2p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                            GlobalNums.sect2p = num;
                        }
                    }
                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                    {
                        if (GlobalNums.sect1p == 0)
                        {
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).SendMessageAsync(user.Mention + " joined the sect! He is now part of the sect team.");
                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                            GlobalNums.sect1p = num;
                        }

                    }
                }
            }
            GlobalNums.bgprotectp = 0;
            GlobalNums.doctorprotectp = 0;
        }
        [Command("night")]
        [RequireBotPermission(Discord.GuildPermission.ManageRoles)]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        private async Task what()
        {
            if (Context.Guild.Id== 472261911526768642)
            { 
            GlobalNums.votetimep = 2;
            HttpClient dude = new HttpClient();
            var clonestream = new MemoryStream();
            Stream stream = await dude.GetStreamAsync("https://cdn.discordapp.com/attachments/470026969963167767/474664582850543616/20180802_164341.jpg");
            stream.CopyTo(clonestream);
            Image pic = new Image(clonestream);
            clonestream.Position = 0;
            await Context.Guild.ModifyAsync(x => x.Icon = pic);
            OverwritePermissions overwriteperms = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Allow, readMessageHistory: PermValue.Allow);
            OverwritePermissions overwriteprms = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Deny, readMessageHistory: PermValue.Allow);
            await Context.Client.GetGuild(472261911526768642).GetTextChannel(472263845289918465).AddPermissionOverwriteAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"), overwriteprms.Modify());
            GlobalNums.plr1p = 0;
            GlobalNums.plr2p = 0;
            GlobalNums.plr3p = 1;
            GlobalNums.plr4p = 0;
            GlobalNums.plr5p = 0;
            GlobalNums.plr6p = 0;
            GlobalNums.plr7p = 0;
            GlobalNums.plr8p = 0;
            GlobalNums.plr9p = 0;
            GlobalNums.plr10p = 1;
            GlobalNums.plr11p = 1;
            GlobalNums.plr12p = 0;
            GlobalNums.plr13p = 0;
            GlobalNums.plr14p = 1;
            GlobalNums.plr15p = 0;
            GlobalNums.plr16p = 0;
            if (GlobalNums.previousjailed != 0)
            {
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.Guild.GetUser(GlobalNums.previousjailed)))
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.Guild.GetUser(GlobalNums.jailidp)))
                    {
                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(473846749174169600).AddPermissionOverwriteAsync(Context.Guild.GetUser(GlobalNums.previousjailed), overwriteperms.Modify());

                    }
                    else
                    {
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472423579330281482).SendMessageAsync("You died during the day means your target is not jaied.");
                    }
                }
                else
                {
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472423579330281482).SendMessageAsync("Your target was killed during the day which means you can't jail him.");
                }
            }
                if (GlobalNums.daystartedp == 1)
                {
                    List<int> list = new List<int> { };
                    if (GlobalNums.plr1vp != 0)
                    {
                        list.Add(GlobalNums.plr1vp);
                    }
                    if (GlobalNums.plr2vp != 0)
                    {
                        list.Add(GlobalNums.plr2vp);
                        if (GlobalNums.mayorrevealp == 1)
                        {
                            list.Add(GlobalNums.mayorvotep);
                        }
                    }
                    if (GlobalNums.plr3vp != 0)
                    {
                        list.Add(GlobalNums.plr3vp);
                    }

                    if (GlobalNums.plr4vp != 0)
                    {
                        list.Add(GlobalNums.plr4vp);
                    }
                    if (GlobalNums.plr5vp != 0)
                    {
                        list.Add(GlobalNums.plr5vp);
                    }
                    if (GlobalNums.plr6vp != 0)
                    {
                        list.Add(GlobalNums.plr6vp);
                    }
                    if (GlobalNums.plr7vp != 0)
                    {
                        list.Add(GlobalNums.plr7vp);
                    }

                    if (GlobalNums.plr8vp != 0)
                    {
                        list.Add(GlobalNums.plr8vp);
                    }
                    if (GlobalNums.plr9vp != 0)
                    {
                        list.Add(GlobalNums.plr9vp);
                    }
                    if (GlobalNums.plr10vp != 0)
                    {
                        list.Add(GlobalNums.plr10vp);
                    }
                    if (GlobalNums.plr11vp != 0)
                    {
                        list.Add(GlobalNums.plr11vp);
                    }

                    if (GlobalNums.plr12vp != 0)
                    {
                        list.Add(GlobalNums.plr12vp);
                    }
                    if (GlobalNums.plr13vp != 0)
                    {
                        list.Add(GlobalNums.plr13vp);
                    }
                    if (GlobalNums.plr14vp != 0)
                    {
                        list.Add(GlobalNums.plr14vp);
                    }
                    if (GlobalNums.plr15vp != 0)
                    {
                        list.Add(GlobalNums.plr15vp);
                    }

                    if (GlobalNums.plr16vp != 0)
                    {
                        list.Add(GlobalNums.plr16vp);
                    }
                    var q = list.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);
                    var c = q.Max(x => x.Count);


                    int dah = 0;
                    foreach (var x in q)
                    {
                        var v = x.Value;

                        if (x.Count == c)
                        {
                            if (v != 17)
                            {
                                if (dah >= 0)
                                {
                                    dah++;
                                    GlobalNums.votetargetp = v;
                                    if (dah>= 2)
                                    {
                                        GlobalNums.votetargetp = 17;
                                    }

                                }


                            }
                        }
                    }
                    if (GlobalNums.plr1vp != 0)
                    {
                        GlobalNums.plr1vp = 17;
                    }
                    if (GlobalNums.plr2vp != 0)
                    {
                        GlobalNums.plr2vp = 17;
                        GlobalNums.mayorvotep = 17;
                    }
                    if (GlobalNums.plr3vp != 0)
                    {
                        GlobalNums.plr3vp = 17;
                    }

                    if (GlobalNums.plr4vp != 0)
                    {
                        GlobalNums.plr4vp = 17;
                    }
                    if (GlobalNums.plr5vp != 0)
                    {
                        GlobalNums.plr5vp = 17;
                    }
                    if (GlobalNums.plr6vp != 0)
                    {
                        GlobalNums.plr6vp = 17;
                    }
                    if (GlobalNums.plr7vp != 0)
                    {
                        GlobalNums.plr7vp = 17;
                    }

                    if (GlobalNums.plr8vp != 0)
                    {
                        GlobalNums.plr8vp = 17;
                    }
                    if (GlobalNums.plr9vp != 0)
                    {
                        GlobalNums.plr9vp = 17;
                    }
                    if (GlobalNums.plr10vp != 0)
                    {
                        GlobalNums.plr10vp = 17;
                    }
                    if (GlobalNums.plr11vp != 0)
                    {
                        GlobalNums.plr11vp = 17;
                    }

                    if (GlobalNums.plr12vp != 0)
                    {
                        GlobalNums.plr12vp = 17;
                    }
                    if (GlobalNums.plr13vp != 0)
                    {
                        GlobalNums.plr13vp = 17;
                    }
                    if (GlobalNums.plr14vp != 0)
                    {
                        GlobalNums.plr14vp = 17;
                    }
                    if (GlobalNums.plr15vp != 0)
                    {
                        GlobalNums.plr15vp = 17;
                    }

                    if (GlobalNums.plr16vp != 0)
                    {
                        GlobalNums.plr16vp = 17;
                    }

                    if (GlobalNums.votetargetp != 17)
                    {
                        var least = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Count();
                        var alivedudes = least / 2;

                        if (c >= alivedudes)
                        {
                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.votetargetp + "");
                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                            {
                                GlobalNums.plr3vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Jailer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                            {
                                GlobalNums.plr7vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                            {
                                GlobalNums.plr6vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Alpha Werewolf)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                            {
                                GlobalNums.plr16vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                            {
                                GlobalNums.plr1vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Aura Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                            {
                                GlobalNums.plr2vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Medium)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                            {
                                GlobalNums.plr4vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Werewolf)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                            {
                                GlobalNums.plr5vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Doctor)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                            {
                                GlobalNums.winnerp = 8;
                                GlobalNums.plr8vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Fool)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                            {
                                GlobalNums.plr8vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Headhunter)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                            {
                                GlobalNums.plr9vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Bodyguard)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                            {
                                GlobalNums.plr10vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Gunner)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                            {
                                GlobalNums.plr11vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Shaman Werewolf)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                            {
                                GlobalNums.plr13vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Serial Killer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                            {
                                GlobalNums.plr14vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Priest)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                            {
                                GlobalNums.plr15vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Wolf Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                            {
                                GlobalNums.plr12vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Aura Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                            {
                                GlobalNums.plr3vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Beast Hunter)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                            {
                                GlobalNums.plr7vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                            {
                                GlobalNums.plr15vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Wolf Seer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                            {
                                GlobalNums.plr16vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Medium)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                            {
                                GlobalNums.plr1vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Aura Seer)");
                            }
                           
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                            {
                                GlobalNums.plr2vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Mayor)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                            {
                                GlobalNums.plr6vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Werewolf)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                            {
                                GlobalNums.plr5vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Doctor)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                            {
                                GlobalNums.plr8vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Fool)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                            {
                                GlobalNums.plr8vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Headhunter)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                            {
                                GlobalNums.plr9vp = 0;
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Bodyguard)");
                                
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                            {
                                GlobalNums.plr10vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town  killed " + user.Nickname + "!(Gunner)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                            {
                                GlobalNums.plr11vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Alpha Werewolf)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                            {
                                GlobalNums.plr13vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Arsonist)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                            {
                                GlobalNums.plr14vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Cupid)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                            {
                                GlobalNums.plr13vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Sect Leader)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                            {
                                GlobalNums.plr12vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Jailer)");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                            {
                                var users= Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.jwwtargetp + "");
                                GlobalNums.plr4vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + user.Nickname + "!(Junior Werewolf)");
                                if (GlobalNums.jwwidp!=0)
                                {
                                    await users.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                    await users.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                                    {
                                        GlobalNums.plr3vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Beast Hunter) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                                    {
                                        GlobalNums.plr7vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Seer) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                                    {
                                        GlobalNums.plr15vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + users.Nickname + "!(Wolf Seer)");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                    {
                                        GlobalNums.plr16vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Medium) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                                    {
                                        GlobalNums.plr1vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Aura Seer) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                                    {
                                        GlobalNums.plr2vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Mayor) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                                    {
                                        GlobalNums.plr6vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + users.Nickname + "!(Werewolf)");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                                    {
                                        GlobalNums.plr5vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Doctor) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                                    {
                                        GlobalNums.plr8vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Fool) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                                    {
                                        GlobalNums.plr8vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Headhunter) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                                    {
                                        GlobalNums.plr9vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Bodyguard) is dead!");

                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                    {
                                        GlobalNums.plr10vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Gunner) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                                    {
                                        GlobalNums.plr11vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The Town killed " + users.Nickname + "!(Alpha Werewolf)");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                                    {
                                        GlobalNums.plr13vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Arsonist) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                                    {
                                        GlobalNums.plr14vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Cupid) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                                    {
                                        GlobalNums.plr13vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Sect Leader) is dead!");
                                    }
                                    if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                                    {
                                        GlobalNums.plr12vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + users.Nickname + " (Jailer) is dead!");
                                    }
                                }
                            }
                            if (GlobalNums.votetargetp+""==GlobalNums.hhtargetp)
                            {
                                GlobalNums.winnerp = 9;
                            }
                        }
                        else
                        {
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The village could not decide who to lynch.");
                        }

                    }
                    else
                    {
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Emote.Parse("<:Night:475774254131183656>") + "The village could not decide who to lynch.");
                    }
                    GlobalNums.votetargetp = 17;
                }
                if (GlobalNums.lover1p != 0 && GlobalNums.lover2p != 0)
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(Context.Guild.GetUser(GlobalNums.lover1p)))
                    {
                        var user = Context.Guild.GetUser(GlobalNums.lover2p);
                        await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                        await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                        {
                            GlobalNums.plr3vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Beast Hunter) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                        {
                            GlobalNums.plr4vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Junior Werewolf) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                        {
                            GlobalNums.plr7vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Seer) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                        {
                            GlobalNums.plr15vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Wolf Seer) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                        {
                            GlobalNums.plr16vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Medium) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                        {
                            GlobalNums.plr1vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Aura Seer) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                        {
                            GlobalNums.plr2vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Mayor) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                        {
                            GlobalNums.plr6vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Werewolf) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                        {
                            GlobalNums.plr5vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Doctor) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Fool) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Headhunter) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                        {

                            GlobalNums.plr9vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Bodyguard) lost the love of his life and committed suicide.");



                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                        {
                            GlobalNums.plr10vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Gunner) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                        {
                            GlobalNums.plr11vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Alpha Werewolf) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Arsonist) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                        {
                            GlobalNums.plr14vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Cupid) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Sect Leader) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                        {
                            GlobalNums.plr12vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Jailer) lost the love of his life and committed suicide.");
                        }
                    }
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(Context.Guild.GetUser(GlobalNums.lover2p)))
                    {
                        var user = Context.Guild.GetUser(GlobalNums.lover1p);
                        await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                        await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                        {
                            GlobalNums.plr3vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Beast Hunter) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                        {
                            GlobalNums.plr4vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Junior Werewolf) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                        {
                            GlobalNums.plr7vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Seer) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                        {
                            GlobalNums.plr15vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Wolf Seer) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                        {
                            GlobalNums.plr16vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Medium) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                        {
                            GlobalNums.plr1vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Aura Seer) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                        {
                            GlobalNums.plr2vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Mayor) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                        {
                            GlobalNums.plr6vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Werewolf) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                        {
                            GlobalNums.plr5vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Doctor) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Fool) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Headhunter) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                        {

                            GlobalNums.plr9vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Bodyguard) lost the love of his life and committed suicide.");



                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                        {
                            GlobalNums.plr10vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Gunner) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                        {
                            GlobalNums.plr11vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Alpha Werewolf) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Arsonist) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                        {
                            GlobalNums.plr14vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Cupid) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Sect Leader) lost the love of his life and committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                        {
                            GlobalNums.plr12vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Jailer) lost the love of his life and committed suicide.");
                        }
                    }
                }
            }
        }
   
        [Command("end")]
        [RequireBotPermission(Discord.GuildPermission.ManageRoles)]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        private async Task normal()
        {
            if (Context.Guild.Id == 472261911526768642)
            {
               
                GlobalNums.bhnewp = 0;
                GlobalNums.bholdp = 0;
                GlobalNums.mayorrevealp = 0;
                GlobalNums.mayorvotep = 0;
                GlobalNums.joinp = 0;
                GlobalNums.daystartedp = 0;
                GlobalNums.gunnerammop = 2;
                GlobalNums.jailerammop = 1;
                HttpClient dude = new HttpClient();
                var clonestream = new MemoryStream();
                Stream stream = await dude.GetStreamAsync("https://cdn.discordapp.com/attachments/465962284062081025/477541867911774238/Untitled95.jpg");
                stream.CopyTo(clonestream);
                Image pic = new Image(clonestream);
                clonestream.Position = 0;
                await Context.Guild.ModifyAsync(x => x.Icon = pic);

                GlobalNums.plr1p = 0;
                GlobalNums.plr2p = 0;
                GlobalNums.plr3p = 0;
                GlobalNums.plr4p = 0;
                GlobalNums.plr5p = 0;
                GlobalNums.plr6p = 0;
                GlobalNums.plr7p = 0;
                GlobalNums.plr8p = 0;
                GlobalNums.plr9p = 0;
                GlobalNums.plr10p = 0;
                GlobalNums.plr11p = 0;
                GlobalNums.plr12p = 0;
                GlobalNums.plr13p = 0;
                GlobalNums.plr14p = 0;
                GlobalNums.plr15p = 0;
                GlobalNums.plr16p = 0;
                GlobalNums.talis1p = 0;
                GlobalNums.talis2p = 0;
                GlobalNums.talis3p = 0;
                GlobalNums.talis4p = 0;
                GlobalNums.talis5p = 0;
                GlobalNums.talis6p = 0;
                GlobalNums.talis7p = 0;
                GlobalNums.talis8p = 0;
                GlobalNums.talis9p = 0;
                GlobalNums.talis10p = 0;
                GlobalNums.talis11p = 0;
                GlobalNums.talis12p = 0;
                GlobalNums.talis13p = 0;
                GlobalNums.talis14p = 0;
                GlobalNums.talis15p = 0;
                GlobalNums.talis16p = 0;
                OverwritePermissions overwriteprms = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Deny, readMessageHistory: PermValue.Allow);
                await Context.Client.GetGuild(472261911526768642).GetTextChannel(472263845289918465).AddPermissionOverwriteAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"), overwriteprms.Modify());
                OverwritePermissions overwriteprm = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Allow, readMessageHistory: PermValue.Allow);
                await Context.Client.GetGuild(472261911526768642).GetTextChannel(472262211654647809).AddPermissionOverwriteAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"), overwriteprm.Modify());
                var n = Context.Guild.GetTextChannel(472422249484386304);
                var werewolf = Context.Guild.Roles.FirstOrDefault(y => y.Name == "Alive").Members.Count(x => x.GetPermissions(n).SendMessages);
                var d = Context.Guild.GetTextChannel(478163675224735744);
                var town = Context.Guild.Roles.FirstOrDefault(y => y.Name == "Alive").Members.Count(x => (!x.GetPermissions(Context.Guild.GetTextChannel(478163714349203456)).SendMessages)&&(!x.GetPermissions(Context.Guild.GetTextChannel(478163675224735744)).SendMessages) && (!x.GetPermissions(Context.Guild.GetTextChannel(472689742350254081)).SendMessages))-werewolf;
                var enemies = Context.Guild.Roles.FirstOrDefault(y => y.Name == "Alive").Members.Count(x => (x.GetPermissions(Context.Guild.GetTextChannel(478163714349203456)).SendMessages) && (x.GetPermissions(Context.Guild.GetTextChannel(478163675224735744)).SendMessages) && (x.GetPermissions(Context.Guild.GetTextChannel(472689742350254081)).SendMessages)) + werewolf;
                if (werewolf >= town && GlobalNums.winnerp !=8)
                {
                    await Context.Client.GetGuild(472261911526768642).GetTextChannel(472263845289918465).SendMessageAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Player").Mention + " Thanks for playing werewolf won the match!");
                    GlobalNums.winnerp = 1;
                }
                if (enemies == 0)
                {
                    await Context.Client.GetGuild(472261911526768642).GetTextChannel(472263845289918465).SendMessageAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Player").Mention + " Thanks for playing Village won the match!");
                    GlobalNums.winnerp = 2;
                }
                if (enemies-werewolf >town+werewolf)
                {
                    GlobalNums.winnerp = 3;
                    await Context.Client.GetGuild(472261911526768642).GetTextChannel(472263845289918465).SendMessageAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Player").Mention + " Thanks for playing sect/arso/sk won the match!");
                }
                if (GlobalNums.winnerp == 8)
                {
                    await Context.Client.GetGuild(472261911526768642).GetTextChannel(472263845289918465).SendMessageAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Player").Mention + " Thanks for playing fool won the match!");
                }
                if (GlobalNums.winnerp==9)
                {
                    await Context.Client.GetGuild(472261911526768642).GetTextChannel(472263845289918465).SendMessageAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Player").Mention + " Thanks for playing headhunter won the match!");
                }
                await Task.Delay(5000);
                while (GlobalNums.plrsp > 0)
                {
                    var g = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.plrsp + "");
                    await g.KickAsync();
                    GlobalNums.plrsp--;
                }

            }
        }
        [Command("J")]
        private async Task jchat([Remainder]string talk)
        {
            if (Context.Channel.Id == 478176634051231744)
            {
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                {
                    var Iuser = Context.User;
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(478163611567521792).SendMessageAsync((Iuser as IGuildUser).Nickname + ": " + talk);
                    await Context.Message.AddReactionAsync(new Emoji("👍"));
                }
            }
            if (Context.Channel.Id == 478163611567521792)
            {
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                {
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(478176634051231744).SendMessageAsync("Jailer: " + talk);
                    await Context.Message.AddReactionAsync(new Emoji("👍"));
                }
            }
            if (Context.Channel.Id == 472423579330281482)
            {
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                {
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(473846749174169600).SendMessageAsync("Jailer: " + talk);
                    await Context.Message.AddReactionAsync(new Emoji("👍"));
                }
            }
            if (Context.Channel.Id == 473846749174169600)
            {
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                {
                    var Iuser = Context.User;
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472423579330281482).SendMessageAsync((Iuser as IGuildUser).Nickname+": " + talk);
                    await Context.Message.AddReactionAsync(new Emoji("👍"));
                }
            }
        }
        [Command("srole")]
        [RequireBotPermission(Discord.GuildPermission.ManageRoles)]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        private async Task tes(int number, string sc)
        {
            if (sc == "classic")
            {
                GlobalNums.bgselfprotectp = 1;
                GlobalNums.claboxp = 0;
                GlobalNums.plrsp = number;
                Random a = new Random();
                Random j = new Random();
                List<int> randomList = new List<int>();
                int n = 1;
                int i = 1;
                GlobalNums.jailerammop = 1;
                GlobalNums.gunnerammop = 2;
                GlobalNums.revivesp = 1;
                GlobalNums.holywaterp = 1;
                GlobalNums.joinp = 1;
                number++;
                OverwritePermissions overwriteperms = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Allow, readMessageHistory: PermValue.Allow);
                OverwritePermissions overwriteprms = new OverwritePermissions(readMessages: PermValue.Deny, sendMessages: PermValue.Deny, readMessageHistory: PermValue.Deny);
                if (GlobalNums.talis1p != 0)
                {
                    randomList.Add(GlobalNums.talis1p);
                }
                if (GlobalNums.talis2p != 0)
                {
                    randomList.Add(GlobalNums.talis2p);
                }
                if (GlobalNums.talis3p != 0)
                {
                    randomList.Add(GlobalNums.talis3p);
                }
                if (GlobalNums.talis4p != 0)
                {
                    randomList.Add(GlobalNums.talis4p);
                }
                if (GlobalNums.talis5p != 0)
                {
                    randomList.Add(GlobalNums.talis5p);
                }
                if (GlobalNums.talis6p != 0)
                {
                    randomList.Add(GlobalNums.talis6p);
                }
                if (GlobalNums.talis7p != 0)
                {
                    randomList.Add(GlobalNums.talis7p);
                }
                if (GlobalNums.talis8p != 0)
                {
                    randomList.Add(GlobalNums.talis8p);
                }
                if (GlobalNums.talis9p != 0)
                {
                    randomList.Add(GlobalNums.talis9p);
                }
                if (GlobalNums.talis10p != 0)
                {
                    randomList.Add(GlobalNums.talis10p);
                }
                if (GlobalNums.talis11p != 0)
                {
                    randomList.Add(GlobalNums.talis11p);
                }
                if (GlobalNums.talis12p != 0)
                {
                    randomList.Add(GlobalNums.talis12p);
                }
                if (GlobalNums.talis13p != 0)
                {
                    randomList.Add(GlobalNums.talis13p);
                }
                if (GlobalNums.talis14p != 0)
                {
                    randomList.Add(GlobalNums.talis14p);
                }
                if (GlobalNums.talis15p != 0)
                {
                    randomList.Add(GlobalNums.talis15p);
                }
                if (GlobalNums.talis16p != 0)
                {
                    randomList.Add(GlobalNums.talis16p);
                }
                if (number < 18)
                {
                    if (number > 4)
                    {
                        while (i < number)
                        {

                            n = a.Next(1, number);
                            if (!randomList.Contains(n))
                            {
                                await Context.Client.GetGuild(472261911526768642).GetTextChannel(472262211654647809).AddPermissionOverwriteAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"), overwriteprms.Modify());

                                randomList.Add(n);
                                i++;
                                if (i == 2)
                                {
                                    if (GlobalNums.talis1p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Aura Seer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis1p + "");
                                        await ReplyAsync("Aura Seer - " + GlobalNums.talis1p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }

                                }
                                if (i == 3)
                                {
                                    if (GlobalNums.talis2p == 0)
                                    {

                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Medium - " + n);
                                        GlobalNums.medidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis2p + "");
                                        await ReplyAsync("Medium - " + GlobalNums.talis2p);
                                        GlobalNums.medidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 4)
                                {
                                    if (GlobalNums.talis3p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Jailer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis3p + "");
                                        await ReplyAsync("Jailer - " + GlobalNums.talis3p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 5)
                                {
                                    GlobalNums.plr1p = 1;
                                    GlobalNums.plr4p = 1;
                                    GlobalNums.plr3p = 1;
                                    GlobalNums.plr2p = 1;
                                    if (GlobalNums.talis4p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Werewolf - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis4p + "");
                                        await ReplyAsync("Werewolf - " + GlobalNums.talis4p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    GlobalNums.plr1vp = 17;
                                    GlobalNums.plr2vp = 17;
                                    GlobalNums.plr4vp = 17;
                                    GlobalNums.plr3vp = 17;
                                }
                                if (i == 6)
                                {
                                    GlobalNums.plr5p = 1;
                                    GlobalNums.plr5vp = 17;
                                    if (GlobalNums.talis5p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Doctor - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis5p + "");
                                        await ReplyAsync("Doctor - " + GlobalNums.talis5p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 7)
                                {
                                    GlobalNums.plr6p = 1;
                                    GlobalNums.plr6vp = 17;

                                    if (GlobalNums.talis6p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Alpha Werewolf - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis6p + "");
                                        await ReplyAsync("Alpha Werewolf - " + GlobalNums.talis6p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 8)
                                {
                                    GlobalNums.plr7p = 1;
                                    GlobalNums.plr7vp = 17;
                                    if (GlobalNums.talis7p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Seer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis7p + "");
                                        await ReplyAsync("Seer - " + GlobalNums.talis7p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 9)
                                {
                                    int b = 0;

                                    b = j.Next(1, 3);

                                    if (b == 1)
                                    {
                                        GlobalNums.plr8p = 1;
                                        GlobalNums.plr8vp = 17;
                                        if (GlobalNums.talis8p == 0)
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                            await ReplyAsync("Headhunter - " + n);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                        else
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis8p + "");
                                            await ReplyAsync("Headhunter - " + GlobalNums.talis8p);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                        GlobalNums.hhfoolsp = 1;
                                    }



                                    if (b == 2)
                                    {
                                        GlobalNums.plr8p = 1;
                                        GlobalNums.plr8vp = 17;
                                        GlobalNums.hhfoolsp = 0;
                                        if (GlobalNums.talis8p == 0)
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                            await ReplyAsync("Fool - " + n);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                        else
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis8p + "");
                                            await ReplyAsync("Fool - " + GlobalNums.talis8p);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                    }
                                }
                                if (i == 10)
                                {
                                    GlobalNums.plr9p = 1;
                                    GlobalNums.plr9vp = 17;
                                    if (GlobalNums.talis9p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Bodyguard - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis9p + "");
                                        await ReplyAsync("Bodyguard - " + GlobalNums.talis9p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 11)
                                {
                                    GlobalNums.plr10p = 1;
                                    GlobalNums.plr10vp = 17;
                                    if (GlobalNums.talis10p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Gunner - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis10p + "");
                                        await ReplyAsync("Gunner - " + GlobalNums.talis10p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 12)
                                {
                                    GlobalNums.plr11p = 1;

                                    GlobalNums.plr11vp = 17;
                                    if (GlobalNums.talis11p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Shaman Werewolf - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis11p + "");
                                        await ReplyAsync("Shaman Werewolf - " + GlobalNums.talis11p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 13)
                                {
                                    GlobalNums.plr12p = 1;
                                    GlobalNums.plr12vp = 17;
                                    if (GlobalNums.talis12p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Aura Seer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis12p + "");
                                        await ReplyAsync("Aura Seer - " + GlobalNums.talis12p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                }
                                if (i == 14)
                                {
                                    GlobalNums.plr13p = 1;
                                    GlobalNums.plr13vp = 17;
                                    if (GlobalNums.talis13p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Serial Killer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis13p + "");
                                        await ReplyAsync("Serial Killer - " + GlobalNums.talis13p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                }
                                if (i == 15)
                                {
                                    GlobalNums.plr14p = 1;
                                    GlobalNums.plr14vp = 17;
                                    if (GlobalNums.talis14p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Priest - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis14p + "");
                                        await ReplyAsync("Priest - " + GlobalNums.talis14p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                }
                                if (i == 16)
                                {
                                    GlobalNums.plr15p = 1;
                                    GlobalNums.plr15vp = 17;

                                    if (GlobalNums.talis15p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Wolf Seer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis15p + "");
                                        await ReplyAsync("Wolf Seer - " + GlobalNums.talis15p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                }
                                if (i == 17)
                                {
                                    GlobalNums.plr16p = 1;
                                    GlobalNums.plr16vp = 17;
                                    if (GlobalNums.talis16p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Seer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis16p + "");
                                        await ReplyAsync("Seer - " + GlobalNums.talis16p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                }

                            }
                        }


                    }
                }
            }
            if (sc == "sandbox")
            {
                GlobalNums.bgselfprotectp = 1;
                GlobalNums.claboxp = 1;
                GlobalNums.plrsp = number;
                Random a = new Random();
                Random j = new Random();
                List<int> randomList = new List<int>();
                int n = 1;
                int i = 1;
                GlobalNums.jailerammop = 1;
                GlobalNums.gunnerammop = 2;
                GlobalNums.revivesp = 1;
                GlobalNums.holywaterp = 1;
                GlobalNums.joinp = 1;
                number++;
               
                OverwritePermissions overwriteperms = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Allow, readMessageHistory: PermValue.Allow);
                OverwritePermissions overwriteprms = new OverwritePermissions(readMessages: PermValue.Deny, sendMessages: PermValue.Deny, readMessageHistory: PermValue.Deny);
                OverwritePermissions overwrteprms = new OverwritePermissions(readMessages: PermValue.Allow, sendMessages: PermValue.Deny, readMessageHistory: PermValue.Allow);
                if (GlobalNums.talis1p != 0)
                {
                    randomList.Add(GlobalNums.talis1p);
                }
                if (GlobalNums.talis2p != 0)
                {
                    randomList.Add(GlobalNums.talis2p);
                }
                if (GlobalNums.talis3p != 0)
                {
                    randomList.Add(GlobalNums.talis3p);
                }
                if (GlobalNums.talis4p != 0)
                {
                    randomList.Add(GlobalNums.talis4p);
                }
                if (GlobalNums.talis5p != 0)
                {
                    randomList.Add(GlobalNums.talis5p);
                }
                if (GlobalNums.talis6p != 0)
                {
                    randomList.Add(GlobalNums.talis6p);
                }
                if (GlobalNums.talis7p != 0)
                {
                    randomList.Add(GlobalNums.talis7p);
                }
                if (GlobalNums.talis8p != 0)
                {
                    randomList.Add(GlobalNums.talis8p);
                }
                if (GlobalNums.talis9p != 0)
                {
                    randomList.Add(GlobalNums.talis9p);
                }
                if (GlobalNums.talis10p != 0)
                {
                    randomList.Add(GlobalNums.talis10p);
                }
                if (GlobalNums.talis11p != 0)
                {
                    randomList.Add(GlobalNums.talis11p);
                }
                if (GlobalNums.talis12p != 0)
                {
                    randomList.Add(GlobalNums.talis12p);
                }
                if (GlobalNums.talis13p != 0)
                {
                    randomList.Add(GlobalNums.talis13p);
                }
                if (GlobalNums.talis14p != 0)
                {
                    randomList.Add(GlobalNums.talis14p);
                }
                if (GlobalNums.talis15p != 0)
                {
                    randomList.Add(GlobalNums.talis15p);
                }
                if (GlobalNums.talis16p != 0)
                {
                    randomList.Add(GlobalNums.talis16p);
                }
                if (number < 18)
                {
                    if (number > 4)
                    {
                        while (i < number)
                        {

                            n = a.Next(1, number);
                            if (!randomList.Contains(n))
                            {
                                await Context.Client.GetGuild(472261911526768642).GetTextChannel(472262211654647809).AddPermissionOverwriteAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"), overwriteprms.Modify());

                                randomList.Add(n);
                                i++;
                                if (i == 2)
                                {
                                    if (GlobalNums.talis1p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Aura Seer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis1p + "");
                                        await ReplyAsync("Aura Seer - " + GlobalNums.talis1p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }

                                }
                                if (i == 3)
                                {
                                    if (GlobalNums.talis2p == 0)
                                    {

                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Mayor - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis2p + "");
                                        await ReplyAsync("Mayor - " + GlobalNums.talis2p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 4)
                                {
                                    if (GlobalNums.talis3p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Beast Hunter - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis3p + "");
                                        await ReplyAsync("Beast Hunter - " + GlobalNums.talis3p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 5)
                                {
                                    GlobalNums.plr1p = 1;
                                    GlobalNums.plr4p = 1;
                                    GlobalNums.plr3p = 1;
                                    GlobalNums.plr2p = 0;
                                    if (GlobalNums.talis4p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Junior Werewolf - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        GlobalNums.jwwidp = user.Id;
                                    }
                                    else
                                    {

                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis4p + "");
                                        await ReplyAsync("Junior Werewolf - " + GlobalNums.talis4p);
                                        GlobalNums.jwwidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    GlobalNums.plr1vp = 17;
                                    GlobalNums.plr2vp = 17;
                                    GlobalNums.plr4vp = 17;
                                    GlobalNums.plr3vp = 17;
                                }
                                if (i == 6)
                                {
                                    GlobalNums.plr5p = 1;
                                    GlobalNums.plr5vp = 17;
                                    if (GlobalNums.talis5p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Doctor - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis5p + "");
                                        await ReplyAsync("Doctor - " + GlobalNums.talis5p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 7)
                                {
                                    GlobalNums.plr15p = 1;
                                    GlobalNums.plr15vp = 17;

                                    if (GlobalNums.talis6p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Wolf Seer - " + n);
                                        GlobalNums.wsidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis6p + "");
                                        await ReplyAsync("Wolf Seer - " + GlobalNums.talis6p);
                                        GlobalNums.wsidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 8)
                                {
                                    GlobalNums.plr7p = 1;
                                    GlobalNums.plr7vp = 17;
                                    if (GlobalNums.talis7p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Seer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis7p + "");
                                        await ReplyAsync("Seer - " + GlobalNums.talis7p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 9)
                                {
                                    int b = 0;

                                    b = j.Next(1, 3);

                                    if (b == 1)
                                    {
                                        GlobalNums.plr8p = 1;
                                        GlobalNums.plr8vp = 17;
                                        if (GlobalNums.talis8p == 0)
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                            await ReplyAsync("Headhunter - " + n);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                        else
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis8p + "");
                                            await ReplyAsync("Headhunter - " + GlobalNums.talis8p);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                        GlobalNums.hhfoolsp = 1;
                                    }



                                    if (b == 2)
                                    {
                                        GlobalNums.plr8p = 1;
                                        GlobalNums.plr8vp = 17;
                                        GlobalNums.hhfoolsp = 0;
                                        if (GlobalNums.talis8p == 0)
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                            await ReplyAsync("Fool - " + n);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                        else
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis8p + "");
                                            await ReplyAsync("Fool - " + GlobalNums.talis8p);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                    }
                                }
                                if (i == 10)
                                {
                                    GlobalNums.plr9p = 1;
                                    GlobalNums.plr9vp = 17;
                                    if (GlobalNums.talis9p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Bodyguard - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis9p + "");
                                        await ReplyAsync("Bodyguard - " + GlobalNums.talis9p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 11)
                                {
                                    GlobalNums.plr10p = 1;
                                    GlobalNums.plr10vp = 17;
                                    if (GlobalNums.talis10p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Gunner - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis10p + "");
                                        await ReplyAsync("Gunner - " + GlobalNums.talis10p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 12)
                                {
                                    GlobalNums.plr11p = 1;

                                    GlobalNums.plr11vp = 17;
                                    if (GlobalNums.talis11p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Alpha Werewolf - " + n);
                                        GlobalNums.awwidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis11p + "");
                                        await ReplyAsync("Alpha Werewolf - " + GlobalNums.talis11p);
                                        GlobalNums.awwidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                    }
                                }
                                if (i == 13)
                                {
                                    GlobalNums.plr12p = 1;
                                    GlobalNums.plr12vp = 17;
                                    if (GlobalNums.talis12p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Jailer - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis12p + "");
                                        await ReplyAsync("Jailer - " + GlobalNums.talis12p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                }
                                if (i == 14)
                                {
                                    int b = 0;

                                    b = j.Next(1, 3);

                                    if (b == 1)
                                    {
                                        GlobalNums.plr13p = 1;
                                        GlobalNums.plr13vp = 17;
                                        if (GlobalNums.talis13p == 0)
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                            await ReplyAsync("Arsonist - " + n);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                        else
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis8p + "");
                                            await ReplyAsync("Arsonist - " + GlobalNums.talis8p);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        }
                                        GlobalNums.arsosectp = 1;
                                    }



                                    if (b == 2)
                                    {
                                        GlobalNums.plr13p = 1;
                                        GlobalNums.plr13vp = 17;
                                        GlobalNums.arsosectp = 0;
                                      
                                        if (GlobalNums.talis13p == 0)
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                            await ReplyAsync("Sect Leader - " + n);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwrteprms.Modify());
                                        }
                                        else
                                        {
                                            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis8p + "");
                                            await ReplyAsync("Sect Leader - " + GlobalNums.talis13p);
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                            await Context.Client.GetGuild(472261911526768642).GetTextChannel(478678600955199488).AddPermissionOverwriteAsync(user, overwrteprms.Modify());
                                        }
                                    }
                                }
                                if (i == 15)
                                {
                                    GlobalNums.plr14p = 1;
                                    GlobalNums.plr14vp = 17;
                                    if (GlobalNums.talis14p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Cupid - " + n);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis14p + "");
                                        await ReplyAsync("Cupid - " + GlobalNums.talis14p);
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                }
                                if (i == 16)
                                {
                                    GlobalNums.plr6p = 1;
                                    GlobalNums.plr6vp = 17;

                                    if (GlobalNums.talis15p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Werewolf - " + n);
                                        GlobalNums.wwidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis15p + "");
                                        await ReplyAsync("Werewolf - " + GlobalNums.talis15p);
                                        GlobalNums.wwidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649).AddPermissionOverwriteAsync(user, overwriteperms.Modify());
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                }
                                if (i == 17)
                                {
                                    GlobalNums.plr16p = 1;
                                    GlobalNums.plr16vp = 17;
                                    if (GlobalNums.talis16p == 0)
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == n + "");
                                        await ReplyAsync("Medium - " + n);
                                            GlobalNums.medidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                    else
                                    {
                                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.talis16p + "");
                                        await ReplyAsync("Medium - " + GlobalNums.talis16p);
                                            GlobalNums.medidp = user.Id;
                                        await Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228).AddPermissionOverwriteAsync(user, overwriteperms.Modify());

                                    }
                                }

                            }
                        }


                    }
                }
            }
        }
        [Command("jail")]
        private async Task jail(IGuildUser user)
        {
            GlobalNums.jailidp = Context.User.Id;
            if (user.Id != Context.User.Id)
            {
                if (GlobalNums.plr3p == 0)
                {
                    if (Context.Channel.Id == 472423579330281482)
                    {
                        if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                        {
                            if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(user))
                            {
                                await Context.Message.AddReactionAsync(Emote.Parse("<:Jailer:475774421378924553>"));
                                GlobalNums.previousjailed = user.Id;

                            }
                            else
                            {
                                await ReplyAsync("Sorry, you can't talk to the dead.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Sorry, only alive players can do that.");
                        }
                    }
                    if (Context.Channel.Id == 478163611567521792)
                    {
                        if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                        {
                            if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(user))
                            {
                                await Context.Message.AddReactionAsync(Emote.Parse("<:Jailer:475774421378924553>"));
                                GlobalNums.previousjailed = user.Id;

                            }
                            else
                            {
                                await ReplyAsync("Sorry, you can't talk to the dead.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Sorry, only alive players can do that.");
                        }
                    }
                }
                else
                {
                    await ReplyAsync("Sorry, it can only be done during day time.");
                }
            }
        }
        [Command("enchant")]
        private async Task iamgud(IGuildUser user)
        {
            if (GlobalNums.previousjailed != Context.User.Id)
            {
                if (GlobalNums.plr11p == 0)
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                    {
                        if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304)).SendMessages)
                        {
                            if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(user))
                            {
                                if (Context.Channel.Id == 472689661853171712)
                                {
                                    GlobalNums.testingherenow = user.Id;
                                    await Context.Message.AddReactionAsync(Emote.Parse("<:Wolf_Shaman_enchantment:481161526510747669>"));
                                }

                            }
                        }
                        else
                        {
                            await ReplyAsync("Sorry, you can't enchant your own team.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, only alive players can do that.");
                    }
                }
                else
                {
                    await ReplyAsync("Sorry, it can only be done during day time.");
                }
            }
        }
        [Command("check")]
        private async Task testing(IGuildUser user)
        {

            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive");
            if (Context.User.Id != GlobalNums.previousjailed)
            {
                if (Context.Channel.Id == 477493754362593290)
                {
                    if (role.Members.Contains(Context.User))
                    {
                        if (role.Members.Contains(user))
                        {
                            if (GlobalNums.plr6p == 0)
                            {
                                GlobalNums.plr6p = 1;
                                if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304)).SendMessages)
                                {
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                                    {

                                        await ReplyAsync(user.Username + "is Beast Hunter!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Junior Werewolf!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Wolf Seer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Medium!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Aura Seer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Mayor!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Werewolf!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Doctor!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Fool!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Headhunter!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Bodyguard!");

                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Gunner!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Alpha Werewolf!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Arsonist!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Cupid!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Sect Leader!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + "is Jailer!");
                                    }
                                }
                            }
                            else
                            {
                                await ReplyAsync("Sorry, it can only be done once during night time.");
                            }
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, only alive players can do that");
                    }
                }
                if (Context.Channel.Id == 478161389429719077)
                {
                    if (role.Members.Contains(Context.User))
                    {
                        if (role.Members.Contains(user))
                        {
                            if (GlobalNums.plr7p == 0)
                            {
                                GlobalNums.plr7p = 1;
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                                {
                                   
                                    await ReplyAsync(user.Username + "is Beast Hunter!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Junior Werewolf!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Wolf Seer!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Medium!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Aura Seer!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Mayor!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Werewolf!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Doctor!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Fool!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Headhunter!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Bodyguard!");

                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Gunner!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Alpha Werewolf!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Arsonist!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Cupid!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Sect Leader!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Jailer!");
                                }
                            
                            }
                            else
                            {
                                await ReplyAsync("Sorry, it can only be done once during night time.");
                            }
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, only alive players can do that");
                    }
                }
                if (Context.Channel.Id == 477493555850379265)
                {
                    if (role.Members.Contains(Context.User))
                    {
                        if (role.Members.Contains(user))
                        {
                            if (GlobalNums.plr1p == 0)
                            {
                                GlobalNums.plr1p = 1;
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                                {

                                    await ReplyAsync(user.Username + "is Good!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Good!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + " is Evil!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Unknown!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Evil!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Good!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Evil!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Good!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Unknown!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Unknown!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Good!");

                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Unknown!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Unknown!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Unknown!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Good!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Unknown!");
                                }
                                if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                                {
                                    await ReplyAsync(user.Username + "is Unknown!");
                                }

                            }
                            else
                            {
                                await ReplyAsync("Sorry, it can only be done once during night time.");
                            }
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, only alive players can do that");
                    }
                }
                if (Context.Channel.Id == 472689605477400577)
                {
                    if (role.Members.Contains(Context.User))
                    {
                        if (role.Members.Contains(user))
                        {
                            if (GlobalNums.plr7p == 0)
                            {
                                GlobalNums.plr7p = 1;
                                if (GlobalNums.testingherenow == user.Id)
                                {
                                    await ReplyAsync(user.Username + " is Shaman Werewolf!");
                                }
                                else
                                {
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Jailer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Alpha Werewolf!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Seer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Aura Seer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Medium!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Werewolf!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Doctor!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Fool!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                                    {

                                        await ReplyAsync(user.Username + " is Headhunter!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Bodyguard !");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Gunner!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Shaman Werewolf!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Serial Killer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Priest!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Wolf Seer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Aura Seer!");
                                    }
                                }
                            }
                            else
                            {
                                await ReplyAsync("Sorry, it can only be done once during night time.");
                            }
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, only alive players can do that");
                    }
                }
                if (Context.Channel.Id == 472689788848177153)
                {
                    if (role.Members.Contains(Context.User))
                    {
                        if (role.Members.Contains(user))
                        {
                            if (GlobalNums.plr16p == 0)
                            {
                                GlobalNums.plr16p = 1;
                                if (GlobalNums.testingherenow == user.Id)
                                {
                                    await ReplyAsync(user.Username + " is Shaman Werewolf!");
                                }
                                else
                                {
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Jailer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Alpha Werewolf!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Seer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Aura Seer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Medium!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Werewolf!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Doctor!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Fool!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Headhunter!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Bodyguard !");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Gunner!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Shaman Werewolf!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Serial Killer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Priest!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Wolf Seer!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Aura Seer!");
                                    }
                                }
                            }
                            else
                            {
                                await ReplyAsync("Sorry, it can only be done once during night time.");
                            }
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, only alive players can do that");
                    }
                }
                if (Context.Channel.Id == 472423446295347201)
                {
                    if (role.Members.Contains(user))
                    {
                        if (role.Members.Contains(Context.User))
                        {
                            if (GlobalNums.plr1p == 0)
                            {
                                GlobalNums.plr1p = 1;
                                if (GlobalNums.testingherenow == user.Id)
                                {
                                    await ReplyAsync(user.Username + " is Evil!");
                                }
                                else
                                {
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Evil!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Evil!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Evil!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }

                                }
                            }
                            else
                            {
                                await ReplyAsync("Sorry, it can only be done once during night time.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Sorry, only alive players can do that");
                        }
                    }
                }
                if (Context.Channel.Id == 472689679247081482)
                {

                    if (role.Members.Contains(user))
                    {
                        if (role.Members.Contains(Context.User))
                        {
                            if (GlobalNums.plr12p == 0)
                            {
                                GlobalNums.plr12p = 1;
                                if (GlobalNums.testingherenow == user.Id)
                                {
                                    await ReplyAsync(user.Username + " is Evil!");
                                }
                                else
                                {
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Evil!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Evil!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Unknown!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Evil!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                                    {
                                        await ReplyAsync(user.Username + " is Good!");
                                    }
                                }
                            }
                            else
                            {
                                await ReplyAsync("Sorry, it can only be done once during night time.");
                            }
                        }
                        else
                        {
                            await ReplyAsync("Sorry, only alive players can do that");
                        }
                    }
                }
                if (Context.Channel.Id == 472689773593624577)
                {
                    if (role.Members.Contains(Context.User))
                    {
                        if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304)).SendMessages)
                        {

                            if (role.Members.Contains(user))
                            {
                                if (GlobalNums.plr15p == 0)
                                {
                                    GlobalNums.plr15p = 1;
                                    if (GlobalNums.testingherenow == user.Id)
                                    {
                                        await ReplyAsync(user.Username + " is Shaman Werewolf!");
                                    }
                                    else
                                    {
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Jailer!");
                                        }

                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Seer!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Aura Seer!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Medium!");
                                        }

                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Doctor!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Fool!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Headhunter!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Bodyguard !");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Gunner!");
                                        }

                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Serial Killer!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Priest!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Seer!");
                                        }
                                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                                        {
                                            await ReplyAsync(user.Username + " is Aura Seer!");
                                        }
                                    }
                                }

                            }
                        }

                    }
                    else
                    {
                        await ReplyAsync("Sorry, only alive players can do that");
                    }
                }
            }
        
           
        }
        [Command("Heal")]
        private async Task IAmProtectedClass(int user)
        {
            if (GlobalNums.previousjailed != Context.User.Id)
            {
                if (Context.Guild.Users.FirstOrDefault(x => x.Nickname == user + "").Username != Context.User.Username)
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                    {
                        if (Context.Channel.Id == 472689532425469962)
                        {
                            await Context.Message.AddReactionAsync(Emote.Parse("<:Doctor_voting_protect:481161547071094784>"));
                            GlobalNums.doctorprotectp = user;
                        }
                        if (Context.Channel.Id == 477494009305235457)
                        {
                            await Context.Message.AddReactionAsync(Emote.Parse("<:Doctor_voting_protect:481161547071094784>"));
                            GlobalNums.doctorprotectp = user;
                        }

                    }
                    else
                    {
                        await ReplyAsync("Sorry, only alive users can do that.");
                    }
                }
            }
        }
        [Command("douse")]
        private async Task butfirstweneedtodousethemKEK(int user1, int user2)
        {
            if (Context.Channel.Id == 478163675224735744)
            {
                if (GlobalNums.plr13p == 0)
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                    {

                        var plr1 = Context.Guild.Users.FirstOrDefault(x => x.Nickname == user1 + "");
                        if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(plr1))
                        {
                            var plr2 = Context.Guild.Users.FirstOrDefault(x => x.Nickname == user2 + "");
                            if (plr2 != (Context.User as IGuildUser))
                            {
                                if (plr1 != (Context.User as IGuildUser))
                                {
                                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(plr2))
                                    {
                                        await Context.Message.AddReactionAsync(Emote.Parse("<:arsonist:475774967363928064>"));
                                        GlobalNums.plr13p = 1;
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                                        {
                                            GlobalNums.arso1p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                                        {
                                            GlobalNums.arso2p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                                        {
                                            GlobalNums.arso3p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                                        {
                                            GlobalNums.arso4p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                                        {
                                            GlobalNums.arso5p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                                        {
                                            GlobalNums.arso6p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                                        {
                                            GlobalNums.arso7p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                                        {
                                            GlobalNums.arso8p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                                        {
                                            GlobalNums.arso8p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                                        {
                                            GlobalNums.arso9p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                        {
                                            GlobalNums.arso10p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                                        {
                                            GlobalNums.arso11p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                                        {
                                            GlobalNums.arso12p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                                        {
                                            GlobalNums.arso14p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                                        {
                                            GlobalNums.arso15p = user2;
                                        }
                                        if (plr2.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                        {
                                            GlobalNums.arso16p = user2;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                                        {
                                            GlobalNums.arso1p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                                        {
                                            GlobalNums.arso2p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                                        {
                                            GlobalNums.arso3p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                                        {
                                            GlobalNums.arso4p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                                        {
                                            GlobalNums.arso5p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                                        {
                                            GlobalNums.arso6p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                                        {
                                            GlobalNums.arso7p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                                        {
                                            GlobalNums.arso8p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                                        {
                                            GlobalNums.arso8p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                                        {
                                            GlobalNums.arso9p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                        {
                                            GlobalNums.arso10p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                                        {
                                            GlobalNums.arso11p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                                        {
                                            GlobalNums.arso12p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                                        {
                                            GlobalNums.arso14p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                                        {
                                            GlobalNums.arso15p = user1;
                                        }
                                        if (plr1.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                        {
                                            GlobalNums.arso16p = user1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        [Command("burn")]
        private async Task BURNTHEMALL()
        {
            if(Context.Channel.Id== 478163675224735744)
            {
                if(GlobalNums.plr13p==0)
                {
                    if(Context.Guild.Roles.FirstOrDefault(x=>x.Name=="Alive").Members.Contains(Context.User))
                    {
                        GlobalNums.plr3p = 1;
                        if(GlobalNums.arso1p!=0)
                        {
                            GlobalNums.plr1vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso1p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set "+getrekt.Nickname+"(Aura Seer) on fire!");
                        }
                        if (GlobalNums.arso2p != 0)
                        {
                            GlobalNums.plr2vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso2p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Mayor) on fire!");
                        }
                        if (GlobalNums.arso3p != 0)
                        {
                            GlobalNums.plr3vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso3p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Beast Hunter) on fire!");
                        }
                        if (GlobalNums.arso4p != 0)
                        {
                            GlobalNums.plr4vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso4p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Junior Werewolf) on fire!");
                        }
                        if (GlobalNums.arso5p != 0)
                        {
                            GlobalNums.plr5vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso5p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Doctor) on fire!");
                        }
                        if (GlobalNums.arso6p != 0)
                        {
                            GlobalNums.plr15vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso6p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Wolf Seer) on fire!");
                        }
                        if (GlobalNums.arso7p != 0)
                        {
                            GlobalNums.plr7vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso7p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Seer) on fire!");
                        }
                        if (GlobalNums.arso8p != 0)
                        {
                            GlobalNums.plr8vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso8p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            if (GlobalNums.hhfoolsp == 1)
                            {
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Headhunter) on fire!");
                            }
                            if (GlobalNums.hhfoolsp == 0)
                            {
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Fool) on fire!");
                            }
                        }
                        if (GlobalNums.arso9p != 0)
                        {
                            GlobalNums.plr9vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso9p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Bodyguard) on fire!");
                        }
                        if (GlobalNums.arso10p != 0)
                        {
                            GlobalNums.plr10vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso10p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Gunner) on fire!");
                        }
                        if (GlobalNums.arso11p != 0)
                        {
                            GlobalNums.plr11vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso11p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Alpha Werewolf) on fire!");
                        }
                        if (GlobalNums.arso12p != 0)
                        {

                            GlobalNums.plr12vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso12p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Jailer) on fire!");
                        }
                        if (GlobalNums.arso14p != 0)
                        {
                            GlobalNums.plr14vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso14p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Cupid) on fire!");
                        }
                        if (GlobalNums.arso15p != 0)
                        {
                            GlobalNums.plr6vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso15p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Werewolf) on fire!");
                        }
                        if (GlobalNums.arso16p != 0)
                        {
                            GlobalNums.plr16vp = 0;
                            var getrekt = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.arso16p + "");
                            await getrekt.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await getrekt.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Arsonist set " + getrekt.Nickname + "(Medium) on fire!");
                        }
                    }
                }
            }
        }
        [Command("Protect")]
        private async Task Iamgood(int user)
        {
            if (GlobalNums.previousjailed != Context.User.Id)
            {
                if (Context.Guild.Users.FirstOrDefault(x => x.Nickname == user + "").Username != Context.User.Username)
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                    {
                        if (Context.Channel.Id == 472689623127031808)
                        {

                            GlobalNums.bgprotectp = user;
                            await Context.Message.AddReactionAsync(Emote.Parse("<:Shield:475774047972753419>"));
                        }
                        if (Context.Channel.Id == 478163499525079050)
                        {

                            GlobalNums.bgprotectp = user;
                            await Context.Message.AddReactionAsync(Emote.Parse("<:Shield:475774047972753419>"));
                        }

                    }
                    else
                    {
                        await ReplyAsync("Sorry, only alive users can do that.");
                    }
                }
            }
        }
        [Command("spectate")]
        private async Task sstest()
        {
            if (Context.Channel.Id == 475726745962545162)
            {
                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(Context.Channel.Id).RemovePermissionOverwriteAsync(Context.User);
                if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(Context.User))
                {
                    if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                    {
                        int gud = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Count();
                        gud++;
                        
                            var Iuser = Context.User;
                            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Spectator");
                            await (Iuser as IGuildUser).AddRoleAsync(role);
                            
                     
                    }
                }
            }
        }
        [Command("Love")]
        private async Task loveisloveHAGREYYYYYY(IGuildUser lover1, IGuildUser lover2)
        {
            if (GlobalNums.daystartedp == 0)
            {
                if (lover1 != (Context.User as IGuildUser))
                {
                    if (lover2 != (Context.User as IGuildUser))
                    {
                        if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                        {
                            if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(lover1))
                            {
                                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(lover2))
                                {
                                    if (GlobalNums.plr14p == 1)
                                    {
                                        if (Context.Channel.Id == 478163805785030656)
                                        {
                                           
                                            GlobalNums.plr14p = 0;
                                            GlobalNums.lover1p = lover1.Id;
                                            GlobalNums.lover2p = lover2.Id;
                                            await Context.Message.AddReactionAsync(Emote.Parse("<:cupid_heart:475774794969645056>"));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        [Command("JoinGame")]
        private async Task testasdasda()
        {
            if (Context.Channel.Id == 475726745962545162)
            {
                if (GlobalNums.joinp == 0)
                {
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(Context.Channel.Id).RemovePermissionOverwriteAsync(Context.User);
                    if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(Context.User))
                    {
                        if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                        {
                            int gud = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Count();
                            gud++;
                            if (gud < 17)
                            {
                                var Iuser = Context.User;
                                var roe = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Narrator");
                                var rol = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Player");
                                var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive");
                                await (Iuser as IGuildUser).AddRoleAsync(role);
                                await (Iuser as IGuildUser).AddRoleAsync(rol);
                                await (Iuser as IGuildUser).RemoveRoleAsync(roe);
                                var guild = Context.Client.GetGuild(472261911526768642);
                                var user = guild.GetUser(Context.User.Id);

                                await user.ModifyAsync(x => x.Nickname = gud.ToString());
                            }
                        }
                    }
                }
            }
        }
        [Command("Suicide")]
        private async Task leavegame([Optional]IGuildUser users)
        {
            if (Context.Channel.Id == 472263845289918465)
            {


                if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(Context.User))
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                    {

                        var Iuser = Context.User;
                        var rol = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive");
                        var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead");
                        await (Iuser as IGuildUser).AddRoleAsync(role);
                        await (Iuser as IGuildUser).RemoveRoleAsync(rol);
                        var user = Iuser as IGuildUser;
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                        {
                            GlobalNums.plr3vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Beast Hunter) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                        {
                            GlobalNums.plr4vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Junior Werewolf) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                        {
                            GlobalNums.plr7vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Seer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                        {
                            GlobalNums.plr15vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Wolf Seer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                        {
                            GlobalNums.plr16vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Medium) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                        {
                            GlobalNums.plr1vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Aura Seer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                        {
                            GlobalNums.plr2vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Mayor) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                        {
                            GlobalNums.plr6vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Werewolf) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                        {
                            GlobalNums.plr5vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Doctor) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Fool) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Headhunter) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                        {

                            GlobalNums.plr9vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Bodyguard) committed suicide.");



                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                        {
                            GlobalNums.plr10vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Gunner) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                        {
                            GlobalNums.plr11vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Alpha Werewolf) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Arsonist) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                        {
                            GlobalNums.plr14vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Cupid) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Sect Leader) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                        {
                            GlobalNums.plr12vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Jailer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                        {
                            GlobalNums.plr3vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Jailer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                        {
                            GlobalNums.plr7vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Seer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                        {
                            GlobalNums.plr6vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + "(Alpha Werewolf) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                        {
                            GlobalNums.plr16vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Seer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                        {
                            GlobalNums.plr1vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Aura Seer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                        {
                            GlobalNums.plr2vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Medium) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                        {
                            GlobalNums.plr4vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + "(Werewolf) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                        {
                            GlobalNums.plr5vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Doctor) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Fool) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Headhunter) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                        {

                            GlobalNums.plr9vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + "(Bodyguard) committed suicide.");


                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                        {
                            GlobalNums.plr10vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Gunner) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                        {
                            GlobalNums.plr11vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Shaman Werewolf) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Serial Killer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                        {
                            GlobalNums.plr14vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Priest) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                        {
                            GlobalNums.plr15vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Wolf Seer) committed suicide.");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                        {
                            GlobalNums.plr12vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(user.Nickname + " (Aura Seer) committed suicide.");
                        }

                    }
                }
                
            }
            if (Context.Channel.Id == 472305713771708446)
            {


                if (!Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(users))
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(users))
                    {

                        var rol = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive");
                        var role = Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead");
                        await users.AddRoleAsync(role);
                        await users.RemoveRoleAsync(rol);
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                        {
                            GlobalNums.plr3vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Beast Hunter) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                        {
                            GlobalNums.plr4vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Junior Werewolf) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                        {
                            GlobalNums.plr7vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Seer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                        {
                            GlobalNums.plr15vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Wolf Seer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                        {
                            GlobalNums.plr16vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Medium) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                        {
                            GlobalNums.plr1vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Aura Seer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                        {
                            GlobalNums.plr2vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Mayor) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                        {
                            GlobalNums.plr6vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Werewolf) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                        {
                            GlobalNums.plr5vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Doctor) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Fool) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Headhunter) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                        {

                            GlobalNums.plr9vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Bodyguard) committed suicide.");



                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                        {
                            GlobalNums.plr10vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Gunner) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                        {
                            GlobalNums.plr11vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Alpha Werewolf) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Arsonist) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                        {
                            GlobalNums.plr14vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Cupid) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Sect Leader) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                        {
                            GlobalNums.plr12vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Jailer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                        {
                            GlobalNums.plr3vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Jailer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                        {
                            GlobalNums.plr7vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Seer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                        {
                            GlobalNums.plr6vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + "(Alpha Werewolf) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                        {
                            GlobalNums.plr16vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Seer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                        {
                            GlobalNums.plr1vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Aura Seer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                        {
                            GlobalNums.plr2vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Medium) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                        {
                            GlobalNums.plr4vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + "(Werewolf) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                        {
                            GlobalNums.plr5vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Doctor) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Fool) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Headhunter) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                        {

                            GlobalNums.plr9vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + "(Bodyguard) committed suicide.");


                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                        {
                            GlobalNums.plr10vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Gunner) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                        {
                            GlobalNums.plr11vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Shaman Werewolf) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Serial Killer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                        {
                            GlobalNums.plr14vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Priest) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                        {
                            GlobalNums.plr15vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Wolf Seer) committed suicide.");
                        }
                        if (users.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                        {
                            GlobalNums.plr12vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(users.Nickname + " (Aura Seer) committed suicide.");
                        }

                    }
                }

            }
        }
        [Command("Trap")]
        private async Task trap(int b)
        {
            if (Context.Channel.Id== 478158741057830912)
            {
                if (GlobalNums.plr3p==1)
                {
                    GlobalNums.bhnewp = b;
                    await Context.Message.AddReactionAsync(Emote.Parse("<:beast_hunter_trap_construction:481159866199834635>"));
                }
            }
        }
        [Command("rev")]
        private async Task revive(IGuildUser user)
        {
            if (Context.User.Id != GlobalNums.previousjailed)
            {
                if (Context.Channel.Id == 472423546530955264)
                {
                    if (GlobalNums.revivesp == 1)
                    {
                        if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                        {
                            if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(user))
                            {
                                GlobalNums.mediumtargetp = user.Id;
                                await Context.Message.AddReactionAsync(Emote.Parse("<:Medium_Heart:475774482850775040>"));
                            }
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, you already used your revive.");
                    }
                }
                if (Context.Channel.Id == 478163838353801228)
                {
                    if (GlobalNums.revivesp == 1)
                    {
                        if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                        {
                            if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(user))
                            {
                                GlobalNums.mediumtargetp = user.Id;
                                await Context.Message.AddReactionAsync(Emote.Parse("<:Medium_Heart:475774482850775040>"));
                            }
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, you already used your revive.");
                    }
                }
            }
        }
        [Command("Shoot")]
        private async Task Shoot(IGuildUser user)
        {
            if (Context.Channel.Id == 472689639539343380)
            {
                if (GlobalNums.plr10p == 0)
                {
                    if (GlobalNums.gunnerammop > 0)
                    {
                       
                        GlobalNums.plr10p = 1;
                        GlobalNums.gunnerammop--;
                       await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name =="Alive"));
                        await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423579330281482)).SendMessages)
                        {
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Jailer)");
                            GlobalNums.plr3vp = 0;
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                        {
                            GlobalNums.plr6vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Alpha Werewolf)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                        {
                            GlobalNums.plr16vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Seer)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                        {
                            GlobalNums.plr1vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Aura Seer)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                        {
                            GlobalNums.plr2vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Medium)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                        {
                            GlobalNums.plr4vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Werewolf)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                        {
                            GlobalNums.plr5vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Doctor)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Fool)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Headhunter)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                        {
                            GlobalNums.plr9vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Bodyguard)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                        {
                            GlobalNums.plr7vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Seer)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                        {
                            GlobalNums.plr11vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Shaman Werewolf)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Serial Killer)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                        {
                            GlobalNums.plr14vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Priest)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                        {
                            GlobalNums.plr15vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Wolf Seer)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                        {
                            GlobalNums.plr12vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Aura Seer)");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, you don't have any ammo.");
                    }

                }
                else
                {
                    await ReplyAsync("Sorry, you can only do it during day time once.");
                }
            }
            if (Context.Channel.Id == 478163539031228437)
            {
                if (GlobalNums.plr10p == 0)
                {
                    if (GlobalNums.gunnerammop > 0)
                    {
                        
                        GlobalNums.plr10p = 1;
                        GlobalNums.gunnerammop--;
                        await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                        await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                        {
                            GlobalNums.plr3vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Beast Hunter)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                        {
                            GlobalNums.plr7vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Seer)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                        {
                            GlobalNums.plr15vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Wolf Seer)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                        {
                            GlobalNums.plr16vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Medium)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                        {
                            GlobalNums.plr1vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Aura Seer)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                        {
                            GlobalNums.plr2vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Mayor)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                        {
                            GlobalNums.plr6vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Werewolf)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                        {
                            GlobalNums.plr5vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Doctor)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Fool)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                        {
                            GlobalNums.plr8vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Headhunter)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                        {
                            GlobalNums.plr9vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Bodyguard)");

                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                        {
                            GlobalNums.plr10vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + user.Nickname + " (Gunner) is dead!");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                        {
                            GlobalNums.plr11vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Alpha Werewolf)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                        {
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Arsonist)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                        {
                            GlobalNums.plr14vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Cupid)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                        {
                            GlobalNums.sectdeadp = 1;
                            GlobalNums.plr13vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Sect Leader)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                        {
                            GlobalNums.plr12vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Jailer)");
                        }
                        if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                        {
                            GlobalNums.plr4vp = 0;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " the gunner shot " + user.Nickname + "!(Junior Werewolf)");
                        }
                        if (GlobalNums.sectdeadp == 1)
                        {
                            if (GlobalNums.sect1p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect1p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect1p + " committed suicide.(Aura Seer)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect2p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect2p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect2p + " committed suicide.(Mayor)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect3p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect3p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect3p + " committed suicide.(Beast Hunter)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect4p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect4p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect4p + " committed suicide.(Doctor)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect5p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect5p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect5p + " committed suicide.(Seer)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect6p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect6p + "");
                                if (GlobalNums.hhfoolsp == 1)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect6p + " committed suicide.(Headhunter)");
                                }
                                if (GlobalNums.hhfoolsp == 1)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect6p + " committed suicide.(Fool)");
                                }
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect7p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect7p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect7p + " committed suicide.(Bodyguard)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect8p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect8p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect8p + " committed suicide.(Gunner)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect9p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect9p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect9p + " committed suicide.(Jailer)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect10p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect10p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect10p + " committed suicide.(Cupid)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                            if (GlobalNums.sect11p != 0)
                            {
                                var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect11p + "");
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect11p + " committed suicide.(Medium)");
                                await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            }
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, you don't have any ammo.");
                    }

                }
                else
                {
                    await ReplyAsync("Sorry, you can only do it during day time once.");
                }
            }
            if (Context.Channel.Id == 472423579330281482)
            {
                if (GlobalNums.plr3p == 1)
                {
                    if (GlobalNums.jailerammop > 0)
                    {
                        if (GlobalNums.previousjailed == user.Id)
                        {
                            if (GlobalNums.previousjailed != 0)
                            {
                                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                                {
                                    GlobalNums.plr3p = 1;
                                    GlobalNums.jailerammop--;
                                    await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                    await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689605477400577)).SendMessages)
                                    {
                                        GlobalNums.plr7vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Seer)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                                    {
                                        GlobalNums.plr6vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Alpha Werewolf)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689788848177153)).SendMessages)
                                    {
                                        GlobalNums.plr16vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Seer)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423446295347201)).SendMessages)
                                    {
                                        GlobalNums.plr1vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Aura Seer)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472423546530955264)).SendMessages)
                                    {
                                        GlobalNums.plr2vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Medium)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                                    {
                                        GlobalNums.plr4vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Werewolf)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689532425469962)).SendMessages)
                                    {
                                        GlobalNums.plr5vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Doctor)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473617034601824268)).SendMessages)
                                    {
                                        GlobalNums.plr8vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Fool)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473619183955869706)).SendMessages)
                                    {
                                        GlobalNums.plr8vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Headhunter)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689623127031808)).SendMessages)
                                    {
                                        GlobalNums.plr9vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Bodyguard)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                                    {
                                        GlobalNums.plr10vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Gunner)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                                    {
                                        GlobalNums.plr11vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Shaman Werewolf)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                                    {
                                        GlobalNums.plr13vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Serial Killer)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                                    {
                                        GlobalNums.plr14vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Priest)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                                    {
                                        GlobalNums.plr15vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Wolf Seer)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689679247081482)).SendMessages)
                                    {
                                        GlobalNums.plr12vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Aura Seer)");
                                    }
                                }
                                else
                                {
                                    await ReplyAsync("Sorry, only alive players can do that.");
                                }
                            }
                           
                        }
                        else
                        {
                            await ReplyAsync("Sorry, you can only kill your target.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, you don't have any ammo.");
                    }

                }
                else
                {
                    await ReplyAsync("Sorry, you can only do it during night time.");
                }
            }
            if (Context.Channel.Id == 478163611567521792)
            {
                if (GlobalNums.plr3p == 1)
                {
                    if (GlobalNums.jailerammop > 0)
                    {
                        if (GlobalNums.previousjailed == user.Id)
                        {
                            if (GlobalNums.previousjailed != 0)
                            {
                                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                                {
                                   
                                    GlobalNums.jailerammop--;
                                    await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                    await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                                    {
                                        GlobalNums.plr3vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Beast Hunter)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                                    {
                                        GlobalNums.plr7vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Seer)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                                    {
                                        GlobalNums.plr15vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Wolf Seer)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                                    {
                                        GlobalNums.plr16vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Medium)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                                    {
                                        GlobalNums.plr1vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Aura Seer)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                                    {
                                        GlobalNums.plr2vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Mayor)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                                    {
                                        GlobalNums.plr6vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Werewolf)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                                    {
                                        GlobalNums.plr5vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Doctor)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                                    {
                                        GlobalNums.plr8vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Fool)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                                    {
                                        GlobalNums.plr8vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Headhunter)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                                    {
                                        GlobalNums.plr9vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Bodyguard)");

                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                    {
                                        GlobalNums.plr10vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Gunner)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                                    {
                                        GlobalNums.plr11vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Alpha Werewolf)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                                    {
                                        GlobalNums.plr13vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Arsonist)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                                    {
                                        GlobalNums.plr14vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Cupid)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                                    {
                                        GlobalNums.sectdeadp = 1;
                                        GlobalNums.plr13vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Sect Leader)");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                                    {
                                        GlobalNums.plr12vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("The Junior Werewolf's death has been avenged, " + user.Nickname + " (Jailer) is dead!");
                                    }
                                    if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                                    {

                                        GlobalNums.plr4vp = 0;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Jailer executed his target last night " + user.Nickname + "!(Junior Werewolf)");
                                    }
                                    if (GlobalNums.sectdeadp == 1)
                                    {
                                        if (GlobalNums.sect1p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect1p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect1p + " committed suicide.(Aura Seer)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect2p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect2p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect2p + " committed suicide.(Mayor)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect3p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect3p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect3p + " committed suicide.(Beast Hunter)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect4p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect4p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect4p + " committed suicide.(Doctor)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect5p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect5p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect5p + " committed suicide.(Seer)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect6p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect6p + "");
                                            if (GlobalNums.hhfoolsp == 1)
                                            {
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect6p + " committed suicide.(Headhunter)");
                                            }
                                            if (GlobalNums.hhfoolsp == 1)
                                            {
                                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect6p + " committed suicide.(Fool)");
                                            }
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect7p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect7p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect7p + " committed suicide.(Bodyguard)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect8p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect8p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect8p + " committed suicide.(Gunner)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect9p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect9p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect9p + " committed suicide.(Jailer)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect10p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect10p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect10p + " committed suicide.(Cupid)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                        if (GlobalNums.sect11p != 0)
                                        {
                                            var ripsect = Context.Guild.Users.FirstOrDefault(x => x.Nickname == GlobalNums.sect11p + "");
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync("Sect member " + GlobalNums.sect11p + " committed suicide.(Medium)");
                                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                                        }
                                    }
                                }
                                else
                                {
                                    await ReplyAsync("Sorry, only alive players can do that.");
                                }
                            }

                        }
                        else
                        {
                            await ReplyAsync("Sorry, you can only kill your target.");
                        }
                    }
                    else
                    {
                        await ReplyAsync("Sorry, you don't have any ammo.");
                    }

                }
                else
                {
                    await ReplyAsync("Sorry, you can only do it during night time.");
                }
            }
            if (GlobalNums.lover1p != 0 && GlobalNums.lover2p != 0)
            {
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(Context.Guild.GetUser(GlobalNums.lover1p)))
                {
                    var ripuser = Context.Guild.GetUser(GlobalNums.lover2p);
                    await ripuser.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                    await ripuser.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                    {
                        GlobalNums.plr3vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Beast Hunter) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                    {
                        GlobalNums.plr4vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Junior Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                    {
                        GlobalNums.plr7vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Seer) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                    {
                        GlobalNums.plr15vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Wolf Seer) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                    {
                        GlobalNums.plr16vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Medium) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                    {
                        GlobalNums.plr1vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Aura Seer) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                    {
                        GlobalNums.plr2vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Mayor) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                    {
                        GlobalNums.plr6vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                    {
                        GlobalNums.plr5vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Doctor) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                    {
                        GlobalNums.plr8vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Fool) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                    {
                        GlobalNums.plr8vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Headhunter) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                    {

                        GlobalNums.plr9vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Bodyguard) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                    {
                        GlobalNums.plr10vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Gunner) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                    {
                        GlobalNums.plr11vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Alpha Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                    {
                        GlobalNums.plr13vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Arsonist) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                    {
                        GlobalNums.plr14vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Cupid) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                    {
                        GlobalNums.plr13vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Sect Leader) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                    {
                        GlobalNums.plr12vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Jailer) lost the love of his life and committed suicide.");
                    }
                }
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead").Members.Contains(Context.Guild.GetUser(GlobalNums.lover2p)))
                {
                    var ripuser = Context.Guild.GetUser(GlobalNums.lover1p);
                    await ripuser.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                    await ripuser.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478158741057830912)).SendMessages)
                    {
                        GlobalNums.plr3vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Beast Hunter) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478160913971675156)).SendMessages)
                    {
                        GlobalNums.plr4vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Junior Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161389429719077)).SendMessages)
                    {
                        GlobalNums.plr7vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Seer) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493754362593290)).SendMessages)
                    {
                        GlobalNums.plr15vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Wolf Seer) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163838353801228)).SendMessages)
                    {
                        GlobalNums.plr16vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Medium) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493555850379265)).SendMessages)
                    {
                        GlobalNums.plr1vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Aura Seer) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                    {
                        GlobalNums.plr2vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Mayor) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163765167259649)).SendMessages)
                    {
                        GlobalNums.plr6vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477494009305235457)).SendMessages)
                    {
                        GlobalNums.plr5vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Doctor) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161490084364288)).SendMessages)
                    {
                        GlobalNums.plr8vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Fool) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478161434992181248)).SendMessages)
                    {
                        GlobalNums.plr8vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Headhunter) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163499525079050)).SendMessages)
                    {

                        GlobalNums.plr9vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Bodyguard) lost the love of his life and committed suicide.");



                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                    {
                        GlobalNums.plr10vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Gunner) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163583319146522)).SendMessages)
                    {
                        GlobalNums.plr11vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Alpha Werewolf) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                    {
                        GlobalNums.plr13vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Arsonist) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163805785030656)).SendMessages)
                    {
                        GlobalNums.plr14vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Cupid) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                    {
                        GlobalNums.plr13vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Sect Leader) lost the love of his life and committed suicide.");
                    }
                    if (ripuser.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163611567521792)).SendMessages)
                    {
                        GlobalNums.plr12vp = 0;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(ripuser.Nickname + " (Jailer) lost the love of his life and committed suicide.");
                    }
                }
            }
        }
        [Command("d")]
        private async Task dchat([Remainder]string talk)
        {
            if (GlobalNums.medidp != GlobalNums.previousjailed)
            {
                if (Context.Channel.Id == 478163838353801228)
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                    {
                        if (GlobalNums.plr2p == 0)
                        {
                            await Context.Message.AddReactionAsync(new Emoji("👍"));
                            GlobalNums.medidp = Context.User.Id;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422647540482049).SendMessageAsync("Medium: " + talk);
                        }
                    }
                }
                if (Context.Channel.Id == 472423546530955264)
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                    {
                        if (GlobalNums.plr2p == 0)
                        {
                            await Context.Message.AddReactionAsync(new Emoji("👍"));
                            GlobalNums.medidp = Context.User.Id;
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422647540482049).SendMessageAsync("Medium: " + talk);
                        }
                    }
                }
                if (Context.Channel.Id == 472422647540482049)
                {
                    if (GlobalNums.plr2p == 0)
                    {
                        await Context.Message.AddReactionAsync(new Emoji("👍"));
                        var user = Context.User;
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472423546530955264).SendMessageAsync((user as IGuildUser).Nickname + ": " + talk);
                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(478163838353801228).SendMessageAsync((user as IGuildUser).Nickname + ": " + talk);
                    }
                }

            }
        }
        [Command("water")]
        private async Task priest(IGuildUser user)
        {
            if (Context.Channel.Id == 472689759332990977)
            {
                if (GlobalNums.plr14p == 0)
                {
                    if (GlobalNums.holywaterp == 1)
                    {
                        if (user.GetPermissions(Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304)).SendMessages)
                        {
                            await user.RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await user.AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473618937406423043)).SendMessages)
                            {
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " used holy water on " + user.Nickname + " is Werewolf!");
                                GlobalNums.plr4vp = 0;
                                GlobalNums.wwnumsp--;
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(473616992071581696)).SendMessages)
                            {
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " used holy water on " + user.Nickname + " is Alpha Werewolf!");
                                GlobalNums.plr6vp = 0;
                                GlobalNums.wwnumsp--;
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689661853171712)).SendMessages)
                            {
                                GlobalNums.wwnumsp--;
                                GlobalNums.plr11vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " used holy water on " + user.Nickname + " is Shaman Werewolf!");
                            }
                            if (user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689773593624577)).SendMessages)
                            {
                                GlobalNums.wwnumsp--;
                                GlobalNums.plr15vp = 0;
                                await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " used holy water on " + user.Nickname + " is Wolf Seer!");
                            }
                        }
                        else
                        {
                            GlobalNums.townnumsp--;
                            GlobalNums.plr14vp = 0;
                            await Context.Guild.GetUser(Context.User.Id).RemoveRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive"));
                            await Context.Guild.GetUser(Context.User.Id).AddRoleAsync(Context.Guild.Roles.FirstOrDefault(x => x.Name == "Dead"));
                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " used holy water on " + user.Nickname + " but " + user.Nickname + " is not a Werewolf!");
                        }
                    }
                }
            }
        }
        [Command("gameroles")]
        private async Task roles()
        {
            if (Context.Channel.Id == 472263845289918465)
            {
                if (GlobalNums.plrsp > 3)
                {
                    if (GlobalNums.plr1vp == 0)
                    {
                        await ReplyAsync("~~Aura Seer~~");
                    }
                    else
                    {
                        await ReplyAsync("Aura Seer");
                    }
                    if (GlobalNums.plr2vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Medium~~");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("~~Mayor~~");
                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Medium");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Mayor");
                        }
                    }
                    if (GlobalNums.plr3vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Jailer~~");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("~~Beast Hunter~~");
                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Jailer");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Beast Hunter");
                        }
                    }
                    if (GlobalNums.plr4vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Werewolf~~");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("~~Junior Werewolf~~");
                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Werewolf");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Junior Werewolf");
                        }
                    }
                }
                if (GlobalNums.plrsp > 4)
                {
                    if (GlobalNums.plr5vp == 0)
                    {
                        await ReplyAsync("~~Doctor~~");
                    }
                    else
                    {
                        await ReplyAsync("Doctor");
                    }
                    
                }
                if (GlobalNums.plrsp > 5)
                {
                    if (GlobalNums.plr15vp==0)
                    {
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("~~Wolf Seer~~");

                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Wolf Seer");
                        }
                    }
                    if (GlobalNums.plr6vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Alpha Werewolf~~");
                        }
                     
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Alpha Werewolf");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Wolf Seer");
                        }
                    }
                }
                if (GlobalNums.plrsp > 6)
                {
                    if (GlobalNums.plr7vp == 0)
                    {
                        await ReplyAsync("~~Seer~~");
                    }
                    else
                    {
                        await ReplyAsync("Seer");
                    }
                   
                }
                if (GlobalNums.plrsp > 7)
                {
                    if (GlobalNums.hhfoolsp == 1)
                    {
                        if (GlobalNums.plr8vp == 0)
                        {
                            await ReplyAsync("~~Headhunter~~");
                        }
                        else
                        {
                            await ReplyAsync("Headhunter");
                        }
                        
                    }
                    if (GlobalNums.hhfoolsp == 0)
                    {
                        if (GlobalNums.plr8vp == 0)
                        {
                            await ReplyAsync("~~Fool~~");
                        }
                        else
                        {
                            await ReplyAsync("Fool");
                        }
                        
                    }
                }
                if (GlobalNums.plrsp > 8)
                {
                    if (GlobalNums.plr9vp == 0)
                    {
                        await ReplyAsync("~~bodyguard~~");
                    }
                    else
                    {
                        await ReplyAsync("bodyguard");
                    }
                    
                }
                if (GlobalNums.plrsp > 9)
                {
                  
                    if (GlobalNums.plr10vp == 0)
                    {
                        await ReplyAsync("~~Gunner~~");
                    }
                    else
                    {
                        await ReplyAsync("Gunner");
                    }
                }
                if (GlobalNums.plrsp > 10)
                {
                    if (GlobalNums.plr11vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Shaman Werewolf~~");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("~~Alpha Werewolf~~");
                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Shaman Werewolf");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Alpha Werewolf");
                        }
                    }
                    
                }
                if (GlobalNums.plrsp > 11)
                {
                    if (GlobalNums.plr8vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Aura Seer~~");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("~~Jailer~~");
                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Aura Seer");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Jailer");
                        }
                    }
                }
                if (GlobalNums.plrsp > 12)
                {

                    if (GlobalNums.plr13vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Serial Killer~~");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            if (GlobalNums.arsosectp == 0)
                            {
                                await ReplyAsync("~~Sect Leader~~");
                            }
                            if (GlobalNums.arsosectp==1)
                            {
                                await ReplyAsync("~~Arsonist~~");
                            }
                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Serial Killer");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            if (GlobalNums.arsosectp == 0)
                            {
                                await ReplyAsync("Sect Leader");
                            }
                            if (GlobalNums.arsosectp == 1)
                            {
                                await ReplyAsync("Arsonist");
                            }
                        }
                    }
                }
                if (GlobalNums.plrsp > 13)
                {

                    if (GlobalNums.plr14vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Priest~~");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("~~Cupid~~");
                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Priest");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Cupid");
                        }
                    }
                }
                if (GlobalNums.plrsp > 14)
                {

                    if (GlobalNums.plr15vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Wolf Seer~~");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("~~Werewolf~~");
                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Wolf Seer");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Werewolf");
                        }
                    }
                }
                if (GlobalNums.plrsp > 15)
                {

                    if (GlobalNums.plr16vp == 0)
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("~~Seer~~");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("~~Medium~~");
                        }
                    }
                    else
                    {
                        if (GlobalNums.claboxp == 0)
                        {
                            await ReplyAsync("Seer");
                        }
                        if (GlobalNums.claboxp == 1)
                        {
                            await ReplyAsync("Medium");
                        }
                    }
                }
            }
        }
        [Command("Reveal")]
        private async Task Reveal()
        {
            if (Context.Channel.Id== 477493708124717079)
            {
                if (GlobalNums.plr2p==1)
                {
                    GlobalNums.mayorrevealp = 1;
                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263845289918465).SendMessageAsync(Context.User.Mention + " has revealed himself as the mayor!");
                  
                }
            }
        }
        [Command("vote")]
        private async Task sss(int b)
        {

            var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == b + "");

            if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
            {
                if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(user))
                {
                    if (user.Id != Context.User.Id)
                    {

                        if (GlobalNums.votetimep == 1)
                        {
                            if (Context.Channel.Id == 472423446295347201)
                            {
                                if (GlobalNums.plr1vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr1vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr1vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 472423546530955264)
                            {
                                if (GlobalNums.plr2vp != b)
                                {
                                    if (GlobalNums.mayorrevealp == 0)
                                    {
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    }
                                    if (GlobalNums.mayorrevealp==1)
                                    {
                                        GlobalNums.mayorvotep = b;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " the mayor voted " + user.Nickname);
                                    }
                                    GlobalNums.plr2vp = b;

                                }
                                else
                                {
                                    if (GlobalNums.mayorrevealp == 0)
                                    {
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    }
                                    if (GlobalNums.mayorrevealp == 1)
                                    {
                                        GlobalNums.mayorvotep = 17;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " the mayor changed his mind!");
                                    }
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr2vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 472423579330281482)
                            {
                                if (GlobalNums.plr3vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr3vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr3vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 473618937406423043)
                            {
                                if (GlobalNums.plr4vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr4vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr4vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 472689532425469962)
                            {
                                if (GlobalNums.plr5vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr5vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr5vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 473616992071581696)
                            {
                                if (GlobalNums.plr6vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr6vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr6vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 477493555850379265)
                            {
                                if (GlobalNums.plr1vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr1vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr1vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 477493708124717079)
                            {
                                if (GlobalNums.plr2vp != b)
                                {
                                    if (GlobalNums.mayorrevealp == 0)
                                    {
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    }
                                    if (GlobalNums.mayorrevealp == 1)
                                    {
                                        GlobalNums.mayorvotep = b;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " the mayor voted " + user.Nickname);
                                    }
                                    GlobalNums.plr2vp = b;

                                }
                                else
                                {
                                    if (GlobalNums.mayorrevealp == 0)
                                    {
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    }
                                    if (GlobalNums.mayorrevealp == 1)
                                    {
                                        GlobalNums.mayorvotep = 17;
                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " the mayor changed his mind!");
                                    }
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr2vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 478158741057830912)
                            {
                                if (GlobalNums.plr3vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr3vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr3vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 478160913971675156)
                            {
                                if (GlobalNums.plr4vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr4vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr4vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 477494009305235457)
                            {
                                if (GlobalNums.plr5vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr5vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr5vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 477493754362593290)
                            {
                                if (GlobalNums.plr6vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr15vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr15vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 472689605477400577)
                            {
                                if (GlobalNums.plr7vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr7vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr7vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 473617034601824268)
                            {
                                if (GlobalNums.plr8vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr8vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr8vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 473619183955869706)
                            {
                                if (GlobalNums.plr8vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr8vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr8vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 472689623127031808)
                            {
                                if (GlobalNums.plr9vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr9vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr9vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 472689639539343380)
                            {
                                if (GlobalNums.plr10vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr10vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr10vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 472689661853171712)
                            {
                                if (GlobalNums.plr11vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr11vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr11vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 472689679247081482)
                            {
                                if (GlobalNums.plr12vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr12vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr12vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 472689742350254081)
                            {
                                if (GlobalNums.plr13vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr13vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr13vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 472689759332990977)
                            {
                                if (GlobalNums.plr14vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr14vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr14vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 472689773593624577)
                            {
                                if (GlobalNums.plr15vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr15vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr15vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 472689788848177153)
                            {
                                if (GlobalNums.plr16vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr16vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr16vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478161389429719077)
                            {
                                if (GlobalNums.plr7vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr7vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr7vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478161434992181248)
                            {
                                if (GlobalNums.plr8vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr8vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr8vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478161490084364288)
                            {
                                if (GlobalNums.plr8vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr8vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr8vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 478163499525079050)
                            {
                                if (GlobalNums.plr9vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr9vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr9vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478163539031228437)
                            {
                                if (GlobalNums.plr10vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr10vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr10vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478163583319146522)
                            {
                                if (GlobalNums.plr11vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr11vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr11vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478163611567521792)
                            {
                                if (GlobalNums.plr12vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr12vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr12vp = 17;
                                }

                            }
                            if (Context.Channel.Id == 478163714349203456)
                            {
                                if (GlobalNums.plr13vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr13vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr13vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478163675224735744)
                            {
                                if (GlobalNums.plr13vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr13vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr13vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478163805785030656)
                            {
                                if (GlobalNums.plr14vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr14vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr14vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478163765167259649)
                            {
                                if (GlobalNums.plr6vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr6vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr6vp = 17;
                                }
                            }
                            if (Context.Channel.Id == 478163838353801228)
                            {
                                if (GlobalNums.plr16vp != b)
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " voted " + user.Nickname);
                                    GlobalNums.plr16vp = b;

                                }
                                else
                                {
                                    await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                    GlobalNums.plr16vp = 17;
                                }
                            }
                        }
                        if (GlobalNums.previousjailed != Context.User.Id)
                        {
                            if (GlobalNums.votetimep == 2)
                            {
                                if (!user.GetPermissions(Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304)).SendMessages)
                                {
                                    if (Context.Channel.Id == 473618937406423043)
                                    {
                                        if (GlobalNums.plr4vp != b)
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " voted to kill " + user.Nickname);
                                            GlobalNums.plr4vp = b;

                                        }
                                        else
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                            GlobalNums.plr4vp = 17;
                                        }

                                    }
                                    if (Context.Channel.Id == 478160913971675156)
                                    {
                                        if (GlobalNums.plr4vp != b)
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " voted to kill " + user.Nickname);
                                            GlobalNums.plr4vp = b;

                                        }
                                        else
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                            GlobalNums.plr4vp = 17;
                                        }

                                    }
                                    if (Context.Channel.Id == 473616992071581696)
                                    {
                                        if (GlobalNums.plr6vp != b)
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " voted to kill " + user.Nickname);
                                            GlobalNums.plr6vp = b;

                                        }
                                        else
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                            GlobalNums.plr6vp = 17;
                                        }
                                    }
                                    if (Context.Channel.Id == 472689661853171712)
                                    {
                                        if (GlobalNums.plr11vp != b)
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " voted to kill " + user.Nickname);
                                            GlobalNums.plr11vp = b;

                                        }
                                        else
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                            GlobalNums.plr11vp = 17;
                                        }
                                    }
                                    if (Context.Channel.Id == 472689773593624577)
                                    {
                                        if (GlobalNums.plr4vp == 0)
                                        {
                                            if (GlobalNums.plr6vp == 0)
                                            {
                                                if (GlobalNums.plr11vp == 0)
                                                {
                                                    if (GlobalNums.plr15vp != b)
                                                    {
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + "  voted to kill " + user.Nickname);
                                                        GlobalNums.plr15vp = b;

                                                    }
                                                    else
                                                    {
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                                        GlobalNums.plr15vp = 17;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (Context.Channel.Id == 477493754362593290)
                                    {
                                        if (GlobalNums.plr4vp == 0)
                                        {
                                            if (GlobalNums.plr6vp == 0)
                                            {
                                                if (GlobalNums.plr11vp == 0)
                                                {
                                                    if (GlobalNums.plr15vp != b)
                                                    {
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + "  voted to kill " + user.Nickname);
                                                        GlobalNums.plr15vp = b;

                                                    }
                                                    else
                                                    {
                                                        await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                                        GlobalNums.plr15vp = 17;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (Context.Channel.Id == 478163765167259649)
                                    {
                                        if (GlobalNums.plr6vp != b)
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " voted to kill " + user.Nickname);
                                            GlobalNums.plr6vp = b;

                                        }
                                        else
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                            GlobalNums.plr6vp = 17;
                                        }
                                    }
                                    if (Context.Channel.Id == 478163583319146522)
                                    {
                                        if (GlobalNums.plr11vp != b)
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " voted to kill " + user.Nickname);
                                            GlobalNums.plr11vp = b;

                                        }
                                        else
                                        {
                                            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472422249484386304).SendMessageAsync(Context.User.Mention + " changed his mind!");
                                            GlobalNums.plr11vp = 17;
                                        }
                                    }
                                }
                                
                            }
                            
                        }
                    }
                }
            }
        }
        [Command("HT")]
        private async Task hhtarget()
        {
            if (Context.Channel.Id== 473619183955869706)
            {
                if (GlobalNums.hhtargetp ==null)
                {
                    Random j = new Random();
                    int b = 0;
                    int d = 0;
                    while (d == 0)
                    {
                        int h = GlobalNums.plrsp + 1;
                        b = j.Next(1, h);
                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == b + "");
                        if (user != (Context.User as IGuildUser))
                        {
                            if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304)).SendMessages)
                            {
                                if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689759332990977)).SendMessages)
                                {

                                    if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689639539343380)).SendMessages)
                                    {

                                        if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472689742350254081)).SendMessages)
                                        {
                                            d++;
                                            await ReplyAsync("Your target is " + user.Nickname + ".");
                                            GlobalNums.hhtargetp = user.Nickname;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    await ReplyAsync("Your target is" + GlobalNums.hhtargetp + ".");
                }
            }
            if (Context.Channel.Id == 478161434992181248)
            {
                if (GlobalNums.hhtargetp == null)
                {
                    Random j = new Random();
                    int b = 0;
                    int d = 0;
                    while (d == 0)
                    {
                        int h = GlobalNums.plrsp + 1;
                        b = j.Next(1, h);
                        var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == b + "");
                        if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304)).SendMessages)
                        {
                            if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(477493708124717079)).SendMessages)
                            {

                                if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163539031228437)).SendMessages)
                                {

                                    if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163675224735744)).SendMessages)
                                    {
                                        if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(478163714349203456)).SendMessages)
                                        {
                                            d++;
                                            await ReplyAsync("Your target is " + user.Nickname + ".");
                                            GlobalNums.hhtargetp = user.Nickname;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    await ReplyAsync("Your target is" +GlobalNums.hhtargetp+".");
                }
            }
        }
        [Command("target")]
        private async Task target(int b)
        {
            if (Context.Channel.Id == 478160913971675156)
            {
                var user = Context.Guild.Users.FirstOrDefault(x => x.Nickname == b + "");
                if (!user.GetPermissions(Context.Client.GetGuild(472261911526768642).GetTextChannel(472422249484386304)).SendMessages)
                {
                    if (Context.Guild.Roles.FirstOrDefault(x => x.Name == "Alive").Members.Contains(Context.User))
                    {
                        GlobalNums.jwwtargetp = b;
                        await Context.Message.AddReactionAsync(Emote.Parse("<:Junior_werewolf_selection:481161538086895636>"));
                    }
                }
            }
        }
        [Command("Talisman")]
        [RequireBotPermission(Discord.GuildPermission.ManageRoles)]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        private async Task talisman(int plr1, [OptionalAttribute]int plr2, [OptionalAttribute]int plr3, [OptionalAttribute]int plr4, [OptionalAttribute] int plr5, [OptionalAttribute] int plr6, [OptionalAttribute] int plr7, [OptionalAttribute] int plr8, [OptionalAttribute] int plr9, [OptionalAttribute] int plr10, [OptionalAttribute] int plr11, [OptionalAttribute] int plr12, [OptionalAttribute] int plr13, [OptionalAttribute] int plr14,[OptionalAttribute] int plr15, [OptionalAttribute] int plr16)
        {
            GlobalNums.talis1p = plr1;
            GlobalNums.talis2p = plr2;
            GlobalNums.talis3p = plr3;
            GlobalNums.talis4p = plr4;
            GlobalNums.talis5p = plr5;
            GlobalNums.talis6p = plr6;
            GlobalNums.talis7p = plr7;
            GlobalNums.talis8p = plr8;
            GlobalNums.talis9p = plr9;
            GlobalNums.talis10p = plr10;
            GlobalNums.talis11p = plr11;
            GlobalNums.talis12p = plr12;
            GlobalNums.talis13p = plr13;
            GlobalNums.talis14p = plr14;
            GlobalNums.talis15p = plr15;
            GlobalNums.talis16p = plr16;
            await Context.Message.AddReactionAsync(new Emoji("👍"));
        }
      [Command("VT")]
        [RequireBotPermission(Discord.GuildPermission.ManageRoles)]
        [RequireUserPermission(Discord.GuildPermission.ManageRoles)]
        private async Task ss()
        {
            await Context.Client.GetGuild(Context.Guild.Id).GetTextChannel(472263927166795778).SendMessageAsync("Start voting!" + Context.Guild.Roles.FirstOrDefault(x=> x.Name== "Alive").Mention);
            GlobalNums.votetimep = 1;
        }

    }

}



    




    

