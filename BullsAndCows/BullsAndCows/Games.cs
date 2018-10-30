using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Games
    {
        private int NumSet { get; set; }

        public Games (int numset)
        {
            NumSet = numset;
        }

        public void Game1()
        {
            RandNum RandNum = new RandNum(NumSet);
            Check Check = new Check(NumSet);

            string StrR, Str = "";
            int CheckBull, CheckCow;
            StrR = RandNum.Rand();
            Console.WriteLine($"Угадываемое число: {StrR}");

            while (Str != StrR)
            {
                Str = Console.ReadLine();
                Str = Check.CheckString(Str, NumSet).ToString();
                Console.WriteLine($"Проверяемое значение: {Str}");

                CheckBull = Check.CheckBull(StrR, Str);
                CheckCow = Check.CheckCow(StrR, Str) - CheckBull;
                Console.WriteLine($"Число быков {CheckBull} и коров {CheckCow}");
            }

            Console.WriteLine("\n Победа! \n");
        }

        public void Game2()
        {
            Player Player = new Player(NumSet);
            Check Check = new Check(NumSet);

            bool flag = true;
            int k, position = 0;

            string Str = Player.SelectNum();
            Console.WriteLine($"Полученное число: {Str}");

            string StrT = "", StrR = "0000";
            while (flag)
            {
                //Console.WriteLine($"Число, которое предположил бот: {StrR}");
                if (StrR == Str) flag = false;

                for (k = 1; StrR[position] != Str[position] && k < 5; k++)
                {
                    Console.WriteLine($"One: {StrR}");
                    StrR = StrT + k.ToString();
                    Console.WriteLine($"Two: {StrR}");
                    StrR = Check.CheckString(StrR, position);
                    Console.WriteLine($"End: {StrR}");
                }
                position++;
                StrT = StrT + k.ToString();
                flag = false;
            }
            Console.WriteLine("\n Победа! \n");
        }
    }
}
