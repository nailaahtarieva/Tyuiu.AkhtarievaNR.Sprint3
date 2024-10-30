namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double multSeries = 1;
            int i;
            for (i = 1; i <= 14; i++)
            {
                multSeries = multSeries * (Math.Cos(1) + Math.Pow((i / 8), 3));

            }
            Console.WriteLine( Math.Round(multSeries, 3));
        }
    }
}
