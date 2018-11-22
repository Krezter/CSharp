using SeaBattle.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Wins
{
    [GameRecord]
    public class Tom : GameRecord
    {
        public override string Name => "Tom";

        public override string Record => "7:23";
    }
}
