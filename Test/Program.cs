﻿namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0;
            int x;

            for (x = 2; x <= 6; x++)
            {
                for(int d = 1; d <= x; d++)
                {
                    if (x % d ==0)
                    {
                        if (d < 3) 
                        {
                            count1++;
                        }
                    }
                }

            }
            Console.WriteLine(count1);
        }
    }
}
