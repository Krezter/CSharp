using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Check
    {
        public bool CheckCell(string[,] Map, int x, int y)
        {//Доработать
         //            if (x >= 0 && x < 10 && y >= 0 && y < 10)

            try
            {
                if (Map[x, y]== "~")
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        public bool CheckRegion(string[,] Map, int x, int y)
        {//Исправить
            if (CheckCell(Map, x+1, y+1) && CheckCell(Map, x-1, y+1)
                && CheckCell(Map, x-1, y-1) && CheckCell(Map, x+1, y-1)
                && CheckCell(Map, x, y+1) && CheckCell(Map, x, y-1)
                && CheckCell(Map, x+1, y) && CheckCell(Map, x-1, y)
                && CheckCell(Map, x, y))
            {
                return true;
            }
            return false;
        }

        public string[,] CheckShot(string[,] Map, int x, int y)
        {
            if (Map[x, y] == "#")
            {
                Map[x, y] = "X";
                Console.WriteLine("Попадание!");
            }
            else
            {
                Map[x, y] = "O";
                Console.WriteLine("Мимо!");
            }

            Console.ReadKey();

            return Map;
        }
    }
}
