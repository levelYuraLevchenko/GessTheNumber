using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    static class RandomPlayer
    {
        public static string Name = "RandomPlayer";
        public static bool Win { get; set; }

        public static int DoMove()
        {
            int Rand = Game.rand.Next(Game.MinValue, Game.MaxValue+1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("RPl: " + Rand);
            Console.ForegroundColor = ConsoleColor.White;
            Game.AddEnterdNumberInArray(Rand);
            if (Rand == Game.WinValue)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Name + " WIN({0}) ", Rand);
                Console.ForegroundColor = ConsoleColor.White;
                Win = true;
            }
            return Rand;
        }
    }
}
