using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Ship
    {
        private Check Check = new Check();

        public string[,] NewShip(string[,] Map, int x, int y, int n)
        {//Доработать, меньше условий

            bool flag = false;
            //Не оптимизированно
            switch (n)
            {
                case 4:
                    if (x < y)
                    {
                        if (x < 6 && Check.CheckRegion(Map, x + 3, y))
                        {
                            Map[x + 1, y] = "#";
                            Map[x + 2, y] = "#";
                            Map[x + 3, y] = "#";
                            flag = true;
                        }
                        else if (Check.CheckRegion(Map, x - 3, y))
                        {
                            Map[x - 1, y] = "#";
                            Map[x - 2, y] = "#";
                            Map[x - 3, y] = "#";
                            flag = true;
                        }
                    }
                    else
                    {
                        if (y < 6 && Check.CheckRegion(Map, x, y + 3))
                        {
                            Map[x, y + 1] = "#";
                            Map[x, y + 2] = "#";
                            Map[x, y + 3] = "#";
                            flag = true;
                        }
                        else if (Check.CheckRegion(Map, x, y - 3))
                        {
                            Map[x, y - 1] = "#";
                            Map[x, y - 2] = "#";
                            Map[x, y - 3] = "#";
                            flag = true;
                        }
                    }
                    break;
                case 3:
                    if (Check.CheckRegion(Map, x + 1, y))
                    {
                        if (Check.CheckRegion(Map, x - 1, y))
                        {
                            Map[x + 1, y] = "#";
                            Map[x - 1, y] = "#";
                            flag = true;
                        }
                        else if (Check.CheckRegion(Map, x+2, y))
                        {
                            Map[x + 1, y] = "#";
                            Map[x+2, y] = "#";
                            flag = true;
                        }
                    }
                    else if(Check.CheckRegion(Map, x, y + 1))
                    {
                        if (Check.CheckRegion(Map, x, y - 1))
                        {
                            Map[x, y + 1] = "#";
                            Map[x, y - 1] = "#";
                            flag = true;
                        }
                        else if (Check.CheckRegion(Map, x, y+2))
                        {
                            Map[x, y + 1] = "#";
                            Map[x, y + 2] = "#";
                            flag = true;
                        }
                    }
                    break;
                case 2:
                    if(x > y)
                    {
                        if (Check.CheckRegion(Map, x + 1, y))
                        {
                            Map[x + 1, y] = "#";
                            flag = true;
                        }
                        else if (Check.CheckRegion(Map, x - 1, y))
                        {
                            Map[x - 1, y] = "#";
                            flag = true;
                        }
                    }
                    else if (Check.CheckRegion(Map, x, y + 1))
                    {
                        Map[x, y + 1] = "#";
                        flag = true;
                    }
                    else if (Check.CheckRegion(Map, x, y - 1))
                    {
                        Map[x, y - 1] = "#";
                        flag = true;
                    }
                    break;
                case 1:
                    flag = true;
                    break;
            }

            if(flag) Map[x, y] = "#";

            return Map;
        }

        public string[,] NewRandShip(string[,] Map, int n)
        {
            int x, y;
            Random Rand = new Random();

            do
            {
                do
                {
                    x = Rand.Next(1, 11);
                    y = Rand.Next(1, 11);
                } while (!Check.CheckRegion(Map, x, y));

                NewShip(Map, x, y, n);
            } while (Map[x, y] != "#");

            return Map;
        }
    }
}
