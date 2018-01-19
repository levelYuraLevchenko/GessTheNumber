using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.SetValue();
            while(true)
            {
                DiligentPlayer.DoMove();
                RandomPlayer.DoMove();
                RandomSmartPlayer.DoMove();
                DiligentCheater.DoMove();
                RandomCheater.DoMove();
                if (DiligentPlayer.Win == true || RandomPlayer.Win == true || RandomSmartPlayer.Win == true || DiligentCheater.Win == true || RandomCheater.Win == true)
                {
                    break;
                }
            }
        }
    }
}
