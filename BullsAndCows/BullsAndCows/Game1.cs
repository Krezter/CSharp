using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Game1
    {
        private int NumSet { get; set; }
        private string Str { get; set; }
        private string StrR { get; set; }
        private int CheckBull { get; set; }
        private int CheckCow { get; set; }
        private bool flag = true;
        private string StrT;
        private int k, Try, Position;

        public Game1 (int numset)
        {
            NumSet = numset;
        }

        public void Start()
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
    }
}
