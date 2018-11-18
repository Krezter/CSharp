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
            var PlayerMap = Map.NewMap();
            var BotMap = Map.NewMap();

            //Доработать эту часть
            PlayerMap = Bot.SetShips(PlayerMap);
            BotMap = Bot.SetShips(BotMap);
            Map.ViewMap(PlayerMap, BotMap);

            Map.UpdMap(PlayerMap, BotMap);

            //Console.ReadKey();
            //Console.Clear();
        }
    }
}
