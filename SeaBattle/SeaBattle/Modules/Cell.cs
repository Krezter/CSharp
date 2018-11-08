using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Modules
{
    abstract class Cell
    {
        protected byte X { get; set; }
        protected byte Y { get; set; }

        protected abstract byte Status();
    }
}
