using SeaBattle.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Wins
{
    [GameRecord]
    public class Jack : GameRecord
    {
        public override string Name => "Jack";

        public override string Record => "6:01";
    }
}
