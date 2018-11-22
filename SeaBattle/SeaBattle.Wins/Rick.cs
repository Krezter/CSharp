using SeaBattle.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Wins
{
    class Rick
    {
        [GameRecord]
        public class Tom : GameRecord
        {
            public override string Name => "Rick";

            public override string Record => "9:41";
        }
    }
}
