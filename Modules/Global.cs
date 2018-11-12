using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using System.Threading;
using Discord.WebSocket;
using System.Linq;
using System.Globalization;


namespace ConsoleApp1.Modules
{

    public class GlobalNums
    {
        private static ulong dbet;
        public static ulong dbetp
        {
            get { return dbet; }
            set { dbet = value; }
        }
        private static ulong dduelrequest;
        public static ulong dduelrequestp
        {
            get { return dduelrequest; }
            set { djoiner = value; }
        }
        private static ulong djoiner;
        public static ulong djoinerp
        {
            get { return djoiner; }
            set { djoiner = value; }
        }
        private static ulong dhost;
        public static ulong dhostp
        {
            get { return dhost; }
            set { dhost = value; }
        }
        private static int winner;
        public static int winnerp
        {
            get { return winner; }
            set { winner = value; }
        }
        private static int LDturn;
        public static int LDturnp
        {
            get { return LDturn; }
            set { LDturn = value; }
        }
        private static ulong LDprevtimes;
        public static ulong LDprevtimesp
        {
            get { return LDprevtimes; }
            set { LDprevtimes = value; }
        }
        private static int LDglobalplrs;
        public static int LDglobalplrsp
        {
            get { return LDglobalplrs; }
            set { LDglobalplrs = value; }
        }
        private static int test;
        public static int testp
        {
            get { return test; }
            set { test = value; }
        }
        private static int LDround;
        public static int LDroundp
        {
            get { return LDround; }
            set { LDround = value; }
        }
        private static int LDprevdice;
        public static int LDprevdicep
        {
            get { return LDprevdice; }
            set { LDprevdice = value; }
        }
        private static int LDplr6dice5;
        public static int LDplr6dice5p
        {
            get { return LDplr6dice5; }
            set { LDplr6dice5 = value; }
        }
        private static int LDplr6dice3;
        public static int LDplr6dice3p
        {
            get { return LDplr6dice3; }
            set { LDplr6dice3 = value; }
        }
        private static int LDplr6dice4;
        public static int LDplr6dice4p
        {
            get { return LDplr6dice4; }
            set { LDplr6dice4 = value; }
        }
        private static int LDplr6dice2;
        public static int LDplr6dice2p
        {
            get { return LDplr6dice2; }
            set { LDplr6dice2 = value; }
        }
        private static int LDplr6dice1;
        public static int LDplr6dice1p
        {
            get { return LDplr6dice1; }
            set { LDplr6dice1 = value; }
        }
        private static int LDplr5dice5;
        public static int LDplr5dice5p
        {
            get { return LDplr5dice5; }
            set { LDplr5dice5 = value; }
        }
        private static int LDplr5dice3;
        public static int LDplr5dice3p
        {
            get { return LDplr5dice3; }
            set { LDplr5dice3 = value; }
        }
        private static int LDplr5dice4;
        public static int LDplr5dice4p
        {
            get { return LDplr5dice4; }
            set { LDplr5dice4 = value; }
        }
        private static int LDplr5dice2;
        public static int LDplr5dice2p
        {
            get { return LDplr5dice2; }
            set { LDplr5dice2 = value; }
        }
        private static int LDplr5dice1;
        public static int LDplr5dice1p
        {
            get { return LDplr5dice1; }
            set { LDplr5dice1 = value; }
        }
        private static int LDplr4dice5;
        public static int LDplr4dice5p
        {
            get { return LDplr4dice5; }
            set { LDplr4dice5 = value; }
        }
        private static int LDplr4dice3;
        public static int LDplr4dice3p
        {
            get { return LDplr4dice3; }
            set { LDplr4dice3 = value; }
        }
        private static int LDplr4dice4;
        public static int LDplr4dice4p
        {
            get { return LDplr4dice4; }
            set { LDplr4dice4 = value; }
        }
        private static int LDplr4dice2;
        public static int LDplr4dice2p
        {
            get { return LDplr4dice2; }
            set { LDplr4dice2 = value; }
        }
        private static int LDplr4dice1;
        public static int LDplr4dice1p
        {
            get { return LDplr4dice1; }
            set { LDplr4dice1 = value; }
        }
        private static int LDplr3dice5;
        public static int LDplr3dice5p
        {
            get { return LDplr3dice5; }
            set { LDplr3dice5 = value; }
        }
        private static int LDplr3dice3;
        public static int LDplr3dice3p
        {
            get { return LDplr3dice3; }
            set { LDplr3dice3 = value; }
        }
        private static int LDplr3dice4;
        public static int LDplr3dice4p
        {
            get { return LDplr3dice4; }
            set { LDplr3dice4 = value; }
        }
        private static int LDplr3dice2;
        public static int LDplr3dice2p
        {
            get { return LDplr3dice2; }
            set { LDplr3dice2 = value; }
        }
        private static int LDplr3dice1;
        public static int LDplr3dice1p
        {
            get { return LDplr3dice1; }
            set { LDplr3dice1 = value; }
        }
        private static int LDplr2dice5;
        public static int LDplr2dice5p
        {
            get { return LDplr2dice5; }
            set { LDplr2dice5 = value; }
        }
        private static int LDplr2dice3;
        public static int LDplr2dice3p
        {
            get { return LDplr2dice3; }
            set { LDplr2dice3 = value; }
        }
        private static int LDplr2dice4;
        public static int LDplr2dice4p
        {
            get { return LDplr2dice4; }
            set { LDplr2dice4 = value; }
        }
        private static int LDplr2dice2;
        public static int LDplr2dice2p
        {
            get { return LDplr2dice2; }
            set { LDplr2dice2 = value; }
        }
        private static int LDplr2dice1;
        public static int LDplr2dice1p
        {
            get { return LDplr2dice1; }
            set { LDplr2dice1 = value; }
        }
        private static int LDplr1dice5;
        public static int LDplr1dice5p
        {
            get { return LDplr1dice5; }
            set { LDplr1dice5 = value; }
        }
        private static int LDplr1dice3;
        public static int LDplr1dice3p
        {
            get { return LDplr1dice3; }
            set { LDplr1dice3 = value; }
        }
        private static int LDplr1dice4;
        public static int LDplr1dice4p
        {
            get { return LDplr1dice4; }
            set { LDplr1dice4 = value; }
        }
        private static int LDplr1dice2;
        public static int LDplr1dice2p
        {
            get { return LDplr1dice2; }
            set { LDplr1dice2 = value; }
        }
        private static int LDplr1dice1;
        public static int LDplr1dice1p
        {
            get { return LDplr1dice1; }
            set { LDplr1dice1 = value; }
        }
        private static ulong RRplrs;
        public static ulong RRplrsp
        {
            get { return RRplrs; }
            set { RRplrs = value; }
        }
        private static ulong RRplr6ID;
        public static ulong RRplr6IDp
        {
            get { return RRplr6ID; }
            set { RRplr6ID = value; }
        }
        private static ulong RRplr5ID;
        public static ulong RRplr5IDp
        {
            get { return RRplr5ID; }
            set { RRplr5ID = value; }
        }
        private static ulong RRplr4ID;
        public static ulong RRplr4IDp
        {
            get { return RRplr4ID; }
            set { RRplr4ID = value; }
        }
        private static ulong RRplr3ID;
        public static ulong RRplr3IDp
        {
            get { return RRplr3ID; }
            set { RRplr3ID = value; }
        }
        private static ulong RRplr2ID;
        public static ulong RRplr2IDp
        {
            get { return RRplr2ID; }
            set { RRplr2ID = value; }
        }
        private static ulong RRbet;
        public static ulong RRbetp
        {
            get { return RRbet; }
            set { RRbet = value; }
        }
        private static ulong RRplrstartedID;
        public static ulong RRplrstartedIDp
        {
            get { return RRplrstartedID; }
            set { RRplrstartedID = value; }
        }
        private static int LDplrs;
        public static int LDplrsp
        {
            get { return LDplrs; }
            set { LDplrs = value; }
        }
        private static ulong LDplr6ID;
        public static ulong LDplr6IDp
        {
            get { return LDplr6ID; }
            set { LDplr6ID = value; }
        }
        private static ulong LDplr5ID;
        public static ulong LDplr5IDp
        {
            get { return LDplr5ID; }
            set { LDplr5ID = value; }
        }
        private static ulong LDplr4ID;
        public static ulong LDplr4IDp
        {
            get { return LDplr4ID; }
            set { LDplr4ID = value; }
        }
        private static ulong LDplr3ID;
        public static ulong LDplr3IDp
        {
            get { return LDplr3ID; }
            set { LDplr3ID = value; }
        }
        private static ulong LDplr2ID;
        public static ulong LDplr2IDp
        {
            get { return LDplr2ID; }
            set { LDplr2ID = value; }
        }
        private static ulong LDbet;
        public static ulong LDbetp
        {
            get { return LDbet; }
            set { LDbet = value; }
        }
        private static ulong LDplrstartedID;
        public static ulong LDplrstartedIDp
        {
            get { return LDplrstartedID; }
            set { LDplrstartedID = value; }
        }
        private static ulong testinghere;
        public static ulong testingherenow
        {
            get { return testinghere; }
            set { testinghere = value; }
        }
        private static ulong prevjailed;
        public static ulong previousjailed
        {
            get { return prevjailed; }
            set { prevjailed = value; }
        }
        private static ulong medid;
        public static ulong medidp
        {
            get { return medid; }
            set { medid = value; }
        }
        private static int plr1;
        public static int plr1p
        {
            get { return plr1; }
            set { plr1 = value; }
        }
        private static int plr2;
        public static int plr2p
        {
            get { return plr2; }
            set { plr2 = value; }
        }
        private static int plr3;
        public static int plr3p
        {
            get { return plr3; }
            set { plr3 = value; }
        }
        private static int plr4;
        public static int plr4p
        {
            get { return plr4; }
            set { plr4 = value; }
        }
        private static int plr5;
        public static int plr5p
        {
            get { return plr5; }
            set { plr5 = value; }
        }
        private static int plr6;
        public static int plr6p
        {
            get { return plr6; }
            set { plr6 = value; }
        }
        private static int plr7;
        public static int plr7p
        {
            get { return plr7; }
            set { plr7 = value; }
        }
        private static int plr8;
        public static int plr8p
        {
            get { return plr8; }
            set { plr8 = value; }
        }
        private static int plr9;
        public static int plr9p
        {
            get { return plr9; }
            set { plr9 = value; }
        }
        private static int plr10;
        public static int plr10p
        {
            get { return plr10; }
            set { plr10 = value; }
        }
        private static int plr11;
        public static int plr11p
        {
            get { return plr11; }
            set { plr11 = value; }
        }
        private static int plr12;
        public static int plr12p
        {
            get { return plr12; }
            set { plr12 = value; }
        }
        private static int plr13;
        public static int plr13p
        {
            get { return plr13; }
            set { plr13 = value; }
        }
        private static int plr14;
        public static int plr14p
        {
            get { return plr14; }
            set { plr14 = value; }
        }
        private static int plr15;
        public static int plr15p
        {
            get { return plr15; }
            set { plr15 = value; }
        }
        private static int plr16;
        public static int plr16p
        {
            get { return plr16; }
            set { plr16 = value; }
        }
        private static int plrs;
        public static int plrsp
        {
            get { return plrs; }
            set { plrs = value; }
        }
        private static int jailerammo;
        public static int jailerammop
        {
            get { return jailerammo; }
            set { jailerammo = value; }
        }
        private static int gunnerammo;
        public static int gunnerammop
        {
            get { return gunnerammo; }
            set { gunnerammo = value; }
        }
        private static ulong jailid;
        public static ulong jailidp
        {
            get { return jailid; }
            set { jailid = value; }
        }
        private static int revives;
        public static int revivesp
        {
            get { return revives; }
            set { revives = value; }
        }
        private static ulong mediumtarget;
        public static ulong mediumtargetp
        {
            get { return mediumtarget; }
            set { mediumtarget = value; }
        }
        private static int holywater;
        public static int holywaterp
        {
            get { return holywater; }
            set { holywater = value; }
        }
        private static int hhfools;
        public static int hhfoolsp
        {
            get { return hhfools; }
            set { hhfools = value; }
        }
        private static int plr1v;
        public static int plr1vp
        {
            get { return plr1v; }
            set { plr1v = value; }
        }
        private static int plr2v;
        public static int plr2vp
        {
            get { return plr2v; }
            set { plr2v = value; }
        }
        private static int plr3v;
        public static int plr3vp
        {
            get { return plr3v; }
            set { plr3v = value; }
        }
        private static int plr4v;
        public static int plr4vp
        {
            get { return plr4v; }
            set { plr4v = value; }
        }
        private static int plr5v;
        public static int plr5vp
        {
            get { return plr5v; }
            set { plr5v = value; }
        }
        private static int plr6v;
        public static int plr6vp
        {
            get { return plr6v; }
            set { plr6v = value; }
        }
        private static int plr7v;
        public static int plr7vp
        {
            get { return plr7v; }
            set { plr7v = value; }
        }
        private static int plr8v;
        public static int plr8vp
        {
            get { return plr8v; }
            set { plr8v = value; }
        }
        private static int plr9v;
        public static int plr9vp
        {
            get { return plr9v; }
            set { plr9v = value; }
        }
        private static int plr10v;
        public static int plr10vp
        {
            get { return plr10v; }
            set { plr10v = value; }
        }
        private static int plr11v;
        public static int plr11vp
        {
            get { return plr11v; }
            set { plr11v = value; }
        }
        private static int plr12v;
        public static int plr12vp
        {
            get { return plr12v; }
            set { plr12v = value; }
        }
        private static int plr13v;
        public static int plr13vp
        {
            get { return plr13v; }
            set { plr13v = value; }
        }
        private static int plr14v;
        public static int plr14vp
        {
            get { return plr14v; }
            set { plr14v = value; }
        }
        private static int plr15v;
        public static int plr15vp
        {
            get { return plr15v; }
            set { plr15v = value; }
        }
        private static int plr16v;
        public static int plr16vp
        {
            get { return plr16v; }
            set { plr16v = value; }
        }
        private static int votetime;
        public static int votetimep
        {
            get { return votetime; }
            set { votetime = value; }
        }
        private static int votetarget;
        public static int votetargetp
        {
            get { return votetarget; }
            set { votetarget = value; }
        }
        private static int join;
        public static int joinp
        {
            get { return join; }
            set { join = value; }

        }
        private static int doctorprotect;
        public static int doctorprotectp
        {
            get { return doctorprotect; }
            set { doctorprotect = value; }

        }
        private static int bgprotect;
        public static int bgprotectp
        {
            get { return bgprotect; }
            set { bgprotect = value; }
        }
        private static ulong bgsuicide;
        public static ulong bgsuicidep
        {
            get { return bgsuicide; }
            set { bgsuicide = value; }
        }
        private static int bgselfprotect;
        public static int bgselfprotectp
        {
            get { return bgselfprotect; }
            set { bgselfprotect = value; }
        }
        private static int daystarted;
        public static int daystartedp
        {
            get { return daystarted; }
            set { daystarted = value; }
        }
        private static int skkill;
        public static int skillp
        {
            get { return skkill; }
            set { skkill = value; }
        }
        private static int talis1;
        public static int talis1p
        {
            get { return talis1; }
            set { talis1 = value; }
        }
        private static int talis2;
        public static int talis2p
        {
            get { return talis2; }
            set { talis2 = value; }
        }
        private static int talis3;
        public static int talis3p
        {
            get { return talis3; }
            set { talis3 = value; }
        }
        private static int talis4;
        public static int talis4p
        {
            get { return talis4; }
            set { talis4 = value; }
        }
        private static int talis5;
        public static int talis5p
        {
            get { return talis5; }
            set { talis5 = value; }
        }
        private static int talis6;
        public static int talis6p
        {
            get { return talis6; }
            set { talis6 = value; }
        }
        private static int talis7;
        public static int talis7p
        {
            get { return talis7; }
            set { talis7 = value; }
        }
        private static int talis8;
        public static int talis8p
        {
            get { return talis8; }
            set { talis8 = value; }
        }
        private static int talis9;
        public static int talis9p
        {
            get { return talis9; }
            set { talis9 = value; }
        }
        private static int talis10;
        public static int talis10p
        {
            get { return talis10; }
            set { talis10 = value; }
        }
        private static int talis11;
        public static int talis11p
        {
            get { return talis11; }
            set { talis11 = value; }
        }
        private static int talis12;
        public static int talis12p
        {
            get { return talis12; }
            set { talis12 = value; }
        }
        private static int talis13;
        public static int talis13p
        {
            get { return talis13; }
            set { talis13 = value; }
        }
        private static int talis14;
        public static int talis14p
        {
            get { return talis14; }
            set { talis14 = value; }
        }
        private static int talis15;
        public static int talis15p
        {
            get { return talis15; }
            set { talis15 = value; }
        }
        private static int talis16;
        public static int talis16p
        {
            get { return talis16; }
            set { talis16 = value; }
        }
        private static int bhold;
        public static int bholdp
        {
            get { return bhold; }
            set { bhold = value; }
        }
        private static int arsosect;
        public static int arsosectp
        {
            get { return arsosect; }
            set { arsosect = value; }
        }
        private static int clabox;
        public static int claboxp
        {
            get { return clabox; }
            set { clabox = value; }
        }
        private static string resultswin;
        public static string resultswinp
        {
            get { return resultswin; }
            set { resultswin = value; }
        }
        private static string resultslose;
        public static string resultslosep
        {
            get { return resultslose; }
            set { resultslose = value; }
        }
        private static int jwwtarget;
        public static int jwwtargetp
        {
            get { return jwwtarget; }
            set { jwwtarget = value; }
        }
        private static string townplrs;
        public static string townplrsp
        {
            get { return townplrs; }
            set { townplrs = value; }
        }
        private static int townnums;
        public static int townnumsp
        {
            get { return townnums; }
            set { townnums = value; }
        }
        private static string hhfoolplrs;
        public static string hhfoolplrsp
        {
            get { return hhfoolplrs; }
            set { hhfoolplrs = value; }
        }
        private static string hhtarget;
        public static string hhtargetp
        {
            get { return hhtarget; }
            set { hhtarget = value; }
        }
        private static string evilplrs;
        public static string evilplrsp
        {
            get { return evilplrs; }
            set { evilplrs = value; }
        }
        private static int evilnums;
        public static int evilnumsp
        {
            get { return evilnums; }
            set { evilnums = value; }
        }
        private static string wwplrs;
        public static string wwplrsp
        {
            get { return wwplrs; }
            set { wwplrs = value; }
        }
        private static int wwnums;
        public static int wwnumsp
        {
            get { return wwnums; }
            set { wwnums = value; }
        }
        private static int bhnew;
        public static int bhnewp
        {
            get { return bhnew; }
            set { bhnew = value; }
        }
        private static int mayorreveal;
        public static int mayorrevealp
        {
            get { return mayorreveal; }
            set { mayorreveal = value; }
        }
        private static int mayorrevealed;
        public static int mayorvotep
        {
            get { return mayorrevealed; }
            set { mayorrevealed = value; }
        }
        private static ulong awwid;
        public static ulong awwidp
        {
            get { return awwid; }
            set { awwid = value; }
        }
        private static ulong wwid;
        public static ulong wwidp
        {
            get { return wwid; }
            set { wwid = value; }
        }
        private static ulong jwwid;
        public static ulong jwwidp
        {
            get { return jwwid; }
            set { jwwid = value; }
        }
        private static ulong wsid;
        public static ulong wsidp
        {
            get { return wsid; }
            set { wsid = value; }
        }
        private static ulong sectid;
        public static ulong sectidp
        {
        
            get { return sectid; }
            set { sectid = value; }
        }
        private static int sectdead;
        public static int sectdeadp
        {
            get { return sectdead; }
            set { sectdead = value; }
        }
        private static int secttarget;
        public static int secttargetp
        {
            get { return secttarget; }
            set { secttarget = value; }
        }
        private static int sect1;
        public static int sect1p
        {
            get { return sect1; }
            set { sect1 = value; }
        }
        private static int sect2;
        public static int sect2p
        {
            get { return sect2; }
            set { sect2 = value; }
        }
        private static int sect3;
        public static int sect3p
        {
            get { return sect3; }
            set { sect3 = value; }
        }
        private static int sect4;
        public static int sect4p
        {
            get { return sect4; }
            set { sect4 = value; }
        }
        private static int sect5;
        public static int sect5p
        {
            get { return sect5; }
            set { sect5 = value; }
        }
        private static int sect6;
        public static int sect6p
        {
            get { return sect6; }
            set { sect6 = value; }
        }
        private static int sect7;
        public static int sect7p
        {
            get { return sect7; }
            set { sect7 = value; }
        }
        private static int sect8;
        public static int sect8p
        {
            get { return sect8; }
            set { sect8 = value; }
        }
        private static int sect9;
        public static int sect9p
        {
            get { return sect9; }
            set { sect9 = value; }
        }
        private static int sect10;
        public static int sect10p
        {
            get { return sect10; }
            set { sect10 = value; }
        }
        private static int sect11;
        public static int sect11p
        {
            get { return sect11; }
            set { sect11 = value; }
        }
      
        private static int arso2;
        public static int arso2p
        {
            get { return arso2; }
            set { arso2 = value; }
        }
        private static int arso3;
        public static int arso3p
        {
            get { return arso3; }
            set { arso3 = value; }
        }
        private static int arso4;
        public static int arso4p
        {
            get { return arso4; }
            set { arso4 = value; }
        }
        private static int arso5;
        public static int arso5p
        {
            get { return arso5; }
            set { arso5 = value; }
        }
        private static int arso6;
        public static int arso6p
        {
            get { return arso6; }
            set { arso6 = value; }
        }
        private static int arso7;
        public static int arso7p
        {
            get { return arso7; }
            set { arso7 = value; }
        }
        private static int arso8;
        public static int arso8p
        {
            get { return arso8; }
            set { arso8 = value; }
        }
        private static int arso9;
        public static int arso9p
        {
            get { return arso9; }
            set { arso9 = value; }
        }
        private static int arso10;
        public static int arso10p
        {
            get { return arso10; }
            set { arso10 = value; }
        }
        private static int arso11;
        public static int arso11p
        {
            get { return arso11; }
            set { arso11 = value; }
        }
        private static int arso12;
        public static int arso12p
        {
            get { return arso12; }
            set { arso12 = value; }
        }
        private static int arso1;
        public static int arso1p
        {
            get { return arso1; }
            set { arso1 = value; }
        }
        private static int arso14;
        public static int arso14p
        {
            get { return arso14; }
            set { arso14 = value; }
        }
        private static int arso15;
        public static int arso15p
        {
            get { return arso15; }
            set { arso15 = value; }
        }
        private static int arso16;
        public static int arso16p
        {
            get { return arso16; }
            set { arso16 = value; }
        }
        private static ulong lover1;
        public static ulong lover1p
        {
            get { return lover1; }
            set { lover1 = value; }
        }
        private static ulong lover2;
        public static ulong lover2p
        {
            get { return lover2; }
            set { lover2 = value; }
        }
    }

    }



    




    

