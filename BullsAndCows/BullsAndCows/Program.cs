using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Player = new Player(4);
            bool Flag = true;
            while (Flag){
                Flag = Player.SelectGame(); //Тупой код, поменять
            }
        }
    }
}
