using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Game
    {
        private Map Map = new Map();
        private Bot Bot = new Bot();

        public void Start()
        {
            var temp = Map.NewMap();
            var temp2 = Map.NewMap();

            //Доработать эту часть
            temp = Bot.SetShips(temp);
            temp2 = Bot.SetShips(temp2);
            Map.ViewMap(temp, temp2);

            Map.UpdMap(temp, temp2);

            //Console.ReadKey();
            //Console.Clear();
        }
    }
}
