using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Bot : IActive
    {
        Ship Ship = new Ship();
        Check Check = new Check();

        //static int Hit;

        public Cell[,] SetShips(Cell[,] Map)
        {
            for (int n = 4; n > 0; n--)
            {
                for (int k = 0; k < 5 - n; k++)
                {
                    Ship.NewRandShip(Map, n);
                }
            }
            
            return Map;
        }

        public Cell[,] Shot(Cell[,] Map)
        {
            int x, y;
            Random Rand = new Random();

            do
            {
                x = Rand.Next(1, 11);
                y = Rand.Next(1, 11);
            } while (Map[x, y].Status == "X" || Map[x, y].Status == "O");

            Console.WriteLine($"\nБот выстрелил по координатам ({x}, {y})");

            Map = Check.CheckShot(Map, x, y);

            return Map;
        }
    }
}
