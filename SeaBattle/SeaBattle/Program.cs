using SeaBattle.Models;
using SeaBattle.Records;
using SeaBattle.Authors;
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
            Title Title = new Title();
            RecordMenu Records = new RecordMenu();

            bool flag = true;
            string Input;

            while (flag)
            {
                Console.Clear();

                Console.WriteLine("Морской бой by krezter");
                Console.WriteLine("\n 1 > Начать игру\n 2 > Настройки\n 3 > Рекорды\n 4 > Авторы\n 5 > Выход");

                Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        Game.Start();
                        break;
                    case "2":
                        Options.Menu();
                        break;
                    case "3":
                        Records.Menu();
                        break;
                    case "4":
                        Title.Menu();
                        break;
                    case "5":
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
