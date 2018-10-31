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
        private string i;

        public RandNum (int numset)
        {
            NumSet = numset;
        }

        public string Rand()
        {
            Random Rand = new Random();
            Str = Rand.Next(0, 9).ToString();
            while (Str.Length < NumSet)
            {
                i = Rand.Next(0, 9).ToString();
                if (Str.IndexOf(i) == -1)
                {
                    Str += i.ToString();
                }
            }
            return Str;
        }
    }
}
