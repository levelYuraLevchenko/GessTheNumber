using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    static class RandomSmartPlayer
    {
        public static string Name = "RandomSmartPlayer";
        public static int[] LocalArray = new int[0];
        public static bool Win = false;

        public static int DoMove()
        {
            int Rand = Game.rand.Next(Game.MinValue, Game.MaxValue+1);
            for (var i = 0; i < LocalArray.Length; i++)
            {
                if (Rand == LocalArray[i])
                {
                    Rand = Game.rand.Next(Game.MinValue, Game.MaxValue+1);
                    i = -1;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("RSPl: " + Rand);
            Console.ForegroundColor = ConsoleColor.White;
            AddEnterdNumberInLocalArray(Rand);
            Game.AddEnterdNumberInArray(Rand);
            if (Rand == Game.WinValue)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Name + " WIN({0}) ", Rand);
                Console.ForegroundColor = ConsoleColor.White;
                Win = true;
            }
            return Rand;
        }

        public static void AddEnterdNumberInLocalArray(int number)
        {
            int[] tmpArray = new int[LocalArray.Length + 1];
            for (var i = 0; i < LocalArray.Length; i++)
            {
                tmpArray[i] = LocalArray[i];
            }
            tmpArray[LocalArray.Length] = number;
            LocalArray = tmpArray;
        }
        
    }
}
