using SeaBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    class Program
    {
        static void Main()
        {
            Game Game = new Game();
            Options Options = new Options();

            bool flag = true;
            string Input;

            while (flag)
            {
                Console.Clear();

                Console.WriteLine("Морской бой by krezter");
                Console.WriteLine("\n 1 > Начать игру\n 2 > Настройки\n 3 > Выход");

                Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        Game.Start();
                        break;
                    case "2":
                        Options.OptionsMenu();
                        break;
                    case "3":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода!");
                        break;
                }
            }
        }
    }
}
