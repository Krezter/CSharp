using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Map
    {
        private Cell[,] Cells { get; set; }
        private Bot Bot = new Bot();
        private Player Player = new Player();

        /// <summary>
        /// Создание новой карты
        /// </summary>
        /// <returns></returns>
        public Cell[,] NewMap()
        {
            Cells = new Cell[12, 12];
            
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    Cells[x, y] = new Cell("~");
                }
            }

            return Cells;
        }

        /// <summary>
        /// Вывод на консоль одной карты
        /// </summary>
        /// <param name="Map1">Просматриваемая карта</param>
        public void ViewMap(Cell[,] Map)
        {//Исправить
            int x, y;

            Console.Clear();

            Console.Write(" * ");
            for (x = 1; x < 11; x++)
                Console.Write(x + " ");
            Console.WriteLine();
            for (x = 1; x < 11; x++)
            {
                Console.Write("{0,2}", x);
                for (y = 1; y < 11; y++)
                {
                    Map[y, x].View();
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод на консоль обеих карт
        /// </summary>
        /// <param name="Map1">Карта игрока</param>
        /// <param name="Map2">Карта бота</param>
        public void ViewMap(Cell[,] Map1, Cell[,] Map2)
        {//Тоже исправить
            int x, y;

            Console.Clear();

            Console.Write(" * ");
            for (x = 1; x < 11; x++)
                Console.Write(x + " ");
            Console.Write("          * ");
            for (x = 1; x < 11; x++)
                Console.Write(x + " ");
            Console.WriteLine();
            for (x = 1; x < 11; x++)
            {
                Console.Write("{0,2}", x);
                for (y = 1; y < 11; y++)
                {
                    Map1[y, x].View();
                }
                Console.Write("           ");
                Console.Write("{0,2}", x);
                for (y = 1; y < 11; y++)
                {
                    Map2[y, x].View();
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Изменение карты
        /// </summary>
        /// <param name="Cells">Изменяемая карта</param>
        /// <returns></returns>
        public Cell[,] UpdMap(Cell[,] Map1, Cell[,] Map2)
        {
            for (int i = 0; i < 30; i++)
            {
                Player.Shot(Map2);
                ViewMap(Map1, Map2);
                Bot.Shot(Map1);
                ViewMap(Map1, Map2);
            }

            return Cells;
        }
    }
}
