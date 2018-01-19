using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    static class RandomCheater
    {
        public static string Name = "RandomCheater";
        public static bool Win = false;

        public static int DoMove()
        {
            int Rand = Game.rand.Next(Game.MinValue, Game.MaxValue + 1);
            for (var i = 0; i < Game.EnteredNumber.Length; i++)
            {
                if (Rand == Game.EnteredNumber[i])
                {
                    Rand = Game.rand.Next(Game.MinValue, Game.MaxValue + 1);
                    i = -1;
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("RCh: " + Rand);
            Console.ForegroundColor = ConsoleColor.White;
            Game.AddEnterdNumberInArray(Rand);
            if (Rand == Game.WinValue)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Name + " WIN({0}) ", Rand);
                Console.ForegroundColor = ConsoleColor.White;
                Win = true;
            }
            return Rand;
        }
    }
}
