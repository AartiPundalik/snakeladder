using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeladder
{
    internal class rollsthedice
    {
        public static void getnumber()
        {
            int pos = 0;
            Console.WriteLine("single player at start position : " + pos);
            RollDice();
        }
        public static void RollDice()
        {
            Random random = new Random();
            int dice = random.Next(6);
            dice = dice + 1;
            Console.WriteLine("Dice Num : " + dice);
            Console.ReadLine();

        }
    }
}
    

