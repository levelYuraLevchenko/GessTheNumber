﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public static class Game
    {
        public static int[] EnteredNumber = new int[0];
        public static int MinValue { get; set; }
        public static int MaxValue { get; set; }
        public static int WinValue { get; set; }
        public static Random rand = new Random();

        public static void SetValue()
        {
            MinValue = int.Parse(Console.ReadLine());
            MaxValue = int.Parse(Console.ReadLine());
            WinValue = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("| " + DiligentPlayer.Name+" 1st |");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("| " + RandomPlayer.Name + " 2nd |");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("| " + RandomSmartPlayer.Name + " 3rd |");
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("| " + DiligentCheater.Name + " 4th |");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("| " + RandomCheater.Name + " 5th |");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Range: from {0} to {1}, winValue = {2}", MinValue, MaxValue, WinValue);
            Console.WriteLine();
        }

        public static void AddEnterdNumberInArray(int number)
        {
            int[] tmpArray = new int[EnteredNumber.Length + 1];
            for (var i = 0; i < EnteredNumber.Length; i++)
            {
                tmpArray[i] = EnteredNumber[i];
            }
            tmpArray[EnteredNumber.Length] = number;
            EnteredNumber = tmpArray;
        }
    }
}
