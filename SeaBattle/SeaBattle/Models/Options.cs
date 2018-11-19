using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Options
    {//В будущем подгружать из файла
        public static bool ViewBotShot;
        public static bool ViewHit;

        public void OptionsMenu()
        {
            bool flag = true;
            string Input;

            while (flag)
            {
                Console.Clear();

                Console.WriteLine("Настройки");
                Console.WriteLine($"\n1 > Показывать выстрелы противника {ViewBotShot}");
                Console.WriteLine($"2 > Уведомлять о попаданиях {ViewHit}");
                Console.WriteLine("3 > Выход");

                Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        if(ViewBotShot) ViewBotShot = false;
                        else ViewBotShot = true;
                        break;
                    case "2":
                        if (ViewHit) ViewHit = false;
                        else ViewHit = true;
                        break;
                    case "3":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
