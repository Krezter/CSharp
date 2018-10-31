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
        private string Str { get; set; }
        private string StrR { get; set; }
        private int CheckBull { get; set; }
        private int CheckCow { get; set; }
        private bool flag = true;
        private string StrT;
        private int k, Try, Position;

        public Games (int numset)
        {
            NumSet = numset;
        }

        public void Game1()
        {
            RandNum RandNum = new RandNum(NumSet);
            Check Check = new Check(NumSet);

            Str = "";
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

            Str = Player.SelectNum();
            Console.WriteLine($"Полученное число: {Str}");

            StrT = "";
            StrR = "0000";
            Try = 1;
            Position = 0;

            while (flag)
            {// По хорошему тут скрипт должен проверять на количество быков, вместо позиций
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
