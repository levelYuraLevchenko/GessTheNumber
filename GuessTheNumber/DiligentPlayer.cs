using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public static class DiligentPlayer
    {
        public static string Name = "DiligentPlayer";
        public static int Rand = Game.MinValue;
        public static bool Win = false;

        public static int DoMove()
        {
            Rand++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("DPl: "+ Rand);
            Console.ForegroundColor = ConsoleColor.White;
            Game.AddEnterdNumberInArray(Rand);
            if (Rand == Game.WinValue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Name + " WIN({0}) ", Rand);
                Console.ForegroundColor = ConsoleColor.White;
                Win = true;
            }
            return Rand;

        }
    }
}
