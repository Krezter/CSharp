using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Check
    {
        public bool CheckCell(Cell[,] Map, int x, int y)
        {//Доработать
         //            if (x >= 0 && x < 10 && y >= 0 && y < 10)

            try
            {
                if (Map[x, y].Status == "~")
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

        public bool CheckRegion(Cell[,] Map, int x, int y)
        {//Очень не оптимизированно, знаю
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

        public bool CheckShot(Cell[,] Map, int x, int y)
        {
            try
            {
                if (Map[x, y].Status == "#")
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
    }
}
