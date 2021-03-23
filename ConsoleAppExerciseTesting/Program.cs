using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExerciseTesting
{
    class Program
    {
        public static List<Player> Playerlist()
        {
            List<Player> plist = new List<Player>
            {
                new Player{PlayerId=2,PlayerName="Dhoni",PlayerTeam="India"},
                new Player{PlayerId=3,PlayerName="kohali",PlayerTeam="India"},
                new Player{PlayerName="raina",PlayerTeam="India"}
               
            };

            return plist;
        }
        static void Main(string[] args)
        {
        }
    }
}