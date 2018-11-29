using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Map
    {
        private Bot Bot = new Bot();
        private Player Player = new Player();
        private string[,] Cells { get; set; }
        private int Num = 20;

        /// <summary>
        /// Создание новой карты
        /// </summary>
        /// <returns></returns>
        public string[,] NewMap()
        {
            Cells = new string[12, 12];
            
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    Cells[x, y] = "~";
                }
            }

            return Cells;
        }

        /// <summary>
        /// Вывод на консоль одной карты
        /// </summary>
        /// <param name="Map1">Просматриваемая карта</param>
        public void ViewMap(string[,] Map)
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
                    Console.Write($" {Map[y, x]}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод на консоль обеих карт
        /// </summary>
        /// <param name="Map1">Карта игрока</param>
        /// <param name="Map2">Карта бота</param>
        public void ViewMap(string[,] Map1, string[,] Map2)
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
                    Console.Write($" {Map1[y, x]}");
                }
                Console.Write("           ");
                Console.Write("{0,2}", x);
                for (y = 1; y < 11; y++)
                {
                    if (!Options.ShowShip && (Map2[y, x] == "#")) Console.Write(" ~");
                    else Console.Write($" {Map2[y, x]}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Изменение карты
        /// </summary>
        /// <param name="Cells">Изменяемая карта</param>
        /// <returns></returns>
        public string[,] UpdMap(string[,] Map1, string[,] Map2)
        {
            OnShot BotShot = Bot.Shot;//Доделать
            OnShot PlayerShot = Player.Shot;//Тоже
            Player.Hit = Bot.Hit = 0;

            while(Player.Hit < Num && Bot.Hit < Num)
            {
                PlayerShot(Map2);
                ViewMap(Map1, Map2);

                if (Player.Hit != Num)
                {
                    BotShot(Map1);
                    ViewMap(Map1, Map2);
                }
            }

            Console.Clear();

            if (Player.Hit == Num)
            {
                Console.WriteLine("\n Победа!");
                RecordDB Record = new RecordDB();
                Record.UpdList("99:99");
            }
            else
            {
                Console.WriteLine("\n Проигрыш...");
            }

            return Cells;
        }
    }
}
