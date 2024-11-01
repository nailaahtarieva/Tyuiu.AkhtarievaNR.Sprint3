﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AkhtarievaNR.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x==0)
                {
                    break;
                }
                else
                {
                    res = res * ((Math.Cos(x) / x) + 3);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
