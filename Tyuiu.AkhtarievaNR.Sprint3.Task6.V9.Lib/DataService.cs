using System.Diagnostics.Metrics;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AkhtarievaNR.Sprint3.Task6.V9.Lib
{
    public class DataService : ISprint3Task6V9
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int countd = 0;
            
            for (x = 19; x <= 30; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        countd++;
                    }
                }

            }
           return countd;
        }
    }
}
