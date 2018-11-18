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
        {//Реализовать меню с настройками
            Game Game = new Game();
            Game.Start();
            Console.ReadKey();
        }
    }
}
