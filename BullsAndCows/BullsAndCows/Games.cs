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
            int k, Try = 1, Position = 0;

            string Str = Player.SelectNum();
            Console.WriteLine($"Полученное число: {Str}");

            string StrT = "", StrR = "0000";
            while (flag)
            {
                for (k = 0; StrR[Position] != Str[Position]; k++)
                {
                    Try++;
                    StrR = StrT + k.ToString();
                    StrR = Check.CheckString(StrR, NumSet);
                    Console.WriteLine($"Число, которое предположил бот: {StrR}");
                }

                StrT = StrT + (k-1).ToString();
                Position++;

                if (StrR == Str) flag = false;
            }
            Console.WriteLine("\n Победа! \n");
            Console.WriteLine($"Потребовалось {Try} попыток \n");
        }
    }
}
