using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class RandNum
    {
        private int NumSet { get; set; }
        private string Str { get; set; }

        public RandNum (int numset)
        {
            NumSet = numset;
        }

        public string Rand()
        {
            var Rand = new Random();
            Str = Rand.Next(0, 9).ToString();
            while (Str.Length < NumSet)
            {
                string i = Rand.Next(0, 9).ToString();
                if (Str.IndexOf(i) == -1)
                {
                    Str += i.ToString();
                }
            }
            return Str;
        }
    }
}
