namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = 1;
            int stopValue = 8;
            double value = 0.25;
            double multSeries = 1;
            do
            {
                multSeries = multSeries * ((Math.Pow(value, startValue) + 4) * Math.Cos(value));
                startValue++;
            } while (startValue <= stopValue);
            Console.WriteLine(Math.Round(multSeries, 3));
        }
    }
}
