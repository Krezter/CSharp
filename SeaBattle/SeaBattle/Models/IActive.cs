using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    interface IActive
    {
        string[,] SetShips(string[,] Map);

        string[,] Shot(string[,] Map);
    }
}
