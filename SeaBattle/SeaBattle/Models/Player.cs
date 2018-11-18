using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Player : IActive
    {//На будущее
        private Ship Ship { get; set; }
        private Check Check = new Check();

        public static int Hit;

        public string[,] SetShips(string[,] Cells)
        {
            for (int num = 4; num > 0; num--)
            {
                for (int s = 0; s < 5 - num; s++)
                {
                    Console.WriteLine($"Введите координаты {s + 1} корабля длиной {num}: ");

                    for (int l = 0; l < num; l++)
                    {
                        //Ship.NewShip(Cells);
                    }
                }
            }

            return Cells;
        }

        public string[,] Shot(string[,] Map)
        {//Исправить
            int x = 0, y = 0;
            bool flag = true;

            while (flag)
            {
                try
                {
                    Console.WriteLine("\nВыстрел по координатам:");
                    Console.Write("X: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Y: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    if (x > 0 && y > 0 && x < 11 && y < 11 && Map[x, y] != "X"
                        && Map[x, y] != "O") flag = false;
                }
                catch
                {
                    Console.WriteLine("Ошибка! Неверный ввод");
                }
            }

            Map = Check.CheckShot(Map, x, y);
            if (Map[x, y] == "X") Hit++;//Заменить

            return Map;
        }
    }
}
