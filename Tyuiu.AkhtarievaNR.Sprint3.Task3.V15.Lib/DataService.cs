using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AkhtarievaNR.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            char Last = ' ';
            int minCount = 99999999;
            int currentCount = 0;

            foreach (char ch in value)
            {
                if (ch == item && Last == ch)
                {
                    currentCount += 1;
                }
                else
                {
                    if (currentCount > 0)
                    {
                        minCount = Math.Min(minCount, currentCount);
                        currentCount = 0;
                    }
                }
                Last = ch;
            }
            return minCount;
        }
    }
}
