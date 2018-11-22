using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Records
{
    public abstract class GameRecord
    {
        public abstract string Name { get; }

        public abstract string Record { get; }
    }
}
