using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Player
    {//На будущее
        private Ship Ship { get; set; }
        private Check Check = new Check();

        public Cell[,] NewShip(Cell[,] Cells)
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

        public Cell[,] Shot(Cell[,] Map)
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

                    if (x > 0 && y > 0 && x < 11 && y < 11) flag = false;
                }
                catch
                {
                    Console.WriteLine("Ошибка! Неверный ввод");
                }
            }

            if (Check.CheckShot(Map, x, y))
            {
                Map[x, y].Status = "X";
                Console.WriteLine("Попадание!");
                Console.ReadKey();
            }
            else
            {
                Map[x, y].Status = "O";
                Console.WriteLine("Мимо!");
                Console.ReadKey();
            }

            return Map;
        }
    }
}
