using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Player
    {
        private int NumSet { get; set; }
        private string Str { get; set; }
        private int Num { get; set; }

        public Player (int numset)
        {
            NumSet = numset;
        }

        public bool SelectGame()
        {
            Check Check = new Check(NumSet);
            Games Game = new Games(NumSet);
            Console.WriteLine("Режим игры:");
            Console.WriteLine("1 => Угадывать число самому");
            Console.WriteLine("2 => Задать угадываемое число");
            Console.WriteLine("3 => Выход");
            Str = Console.ReadLine();
            Num = Check.CheckNum(Str, 1);
            switch (Num)
            {
                case 1:
                    Game.Game1();
                    break;
                case 2:
                    Game.Game2();
                    break;
                case 3:
                    return false;
                default:
                    Console.WriteLine("Такого режима нет");
                    break;
            }
            return true;
        }

        public string SelectNum() //Наговнокодил тута
        {
            Check Check = new Check(NumSet);
            Num = 0;
            Str = "";
            while (Str.Length != NumSet)
            {
                Console.WriteLine($"Введите {NumSet} числа");

                Str = Console.ReadLine();
                Num = Check.CheckNum(Str, NumSet);
                Str = Num.ToString();

                if (Str.Length != NumSet)
                    Console.WriteLine("Ошибка!");
            }
            return Str;
        }
    }
}
