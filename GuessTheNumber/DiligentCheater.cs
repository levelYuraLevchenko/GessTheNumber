using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    static class DiligentCheater
    {
        public static string Name = "DiligentCheater";
        public static int[] LocalArray = new int[0];
        public static int Rand = Game.MinValue;
        public static bool Win = false;

        public static int DoMove()
        {
            Rand++;
            for (var i = 0; i < Game.EnteredNumber.Length; i++)
            {
                if (Rand == Game.EnteredNumber[i])
                {
                    Rand++;
                    i = -1;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DCh: " + Rand);
            Console.ForegroundColor = ConsoleColor.White;
            Game.AddEnterdNumberInArray(Rand);
            if (Rand == Game.WinValue)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Name + " WIN({0}) ", Rand);
                Console.ForegroundColor = ConsoleColor.White;
                Win = true;
            }
            return Rand;
        }
    }
}
