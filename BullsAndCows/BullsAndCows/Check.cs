using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Check
    {
        private int NumSet { get; set; }
        private int Bull { get; set; }
        private int Cow { get; set; }
        private int Num;
        private bool IsNum;

        public Check (int numset)
        {
            NumSet = numset;
        }

        public string CheckString(string str, int length)
        {
            Num = 0;

            if (str.Length < length)
            {
                while (str.Length < length)
                {
                    str += Num.ToString();
                }
            }

            if (str.Length > length)
            {
                str = str.Remove(length, str.Length - length);
            }
            
            return str;
        }

        public int CheckNum(string str, int length)
        {
            str = CheckString(str, length);
            IsNum = int.TryParse(str, out Num);
            if (!IsNum) Num = 0;//Доделать
            return Num;
        }

        public int CheckBull(string str1, string str2)
        {
            Bull = 0;
            for (int i = 0; i < NumSet; i++)
            {
                if (str1[i] == str2[i]) Bull++;
            }

            return Bull;
        }

        public int CheckCow(string str1, string str2)
        {
            Cow = 0;
            for (int i = 0; i < NumSet; i++)
            {
                if (str1.IndexOf(str2[i]) != -1) Cow++;
            }

            return Cow;
        }
    }
}
