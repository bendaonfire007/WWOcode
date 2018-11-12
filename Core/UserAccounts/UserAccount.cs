using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
using ConsoleApp1.Core.UserAccounts;



namespace ConsoleApp1.Core.UserAccounts

{

    public class UserAccount

    {
        public uint godzilla { get; set; }
        public uint phoenix { get; set; }
        public uint cerberus { get; set; }
        public uint lion { get; set; }
        public uint tiger { get; set; }
        public uint eagle { get; set; }
        public uint dogs { get; set; }
        public uint cats { get; set; }
        public uint mouse { get; set; }
        public uint seeds { get; set; }
        public uint sleep { get; set; }
        public uint happiness { get; set; }
        public uint water { get; set; }
        public uint food { get; set; }
        public ulong xp { get; set; }
        public ulong animal { get; set; }
        public ulong ID { get; set; }
        public uint LevelNumber

        {

            get

            {

                return (uint)Math.Sqrt(xp / 1000);

            }

        }
        public ulong roses { get; set; }

        public ulong points { get; set; }
         
    
      
    }

}