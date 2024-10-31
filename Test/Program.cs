namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double multSeries = 1;
            int i;
            for (i = 1; i <= 1; i++)
            {
            multSeries = multSeries * ((Math.Cos(1)) + (Math.Pow((Convert.ToDouble(i) / Convert.ToDouble(8)), 3)));

            }
            Console.WriteLine( Math.Round(multSeries, 3));
            //Console.WriteLine(Math.Cos(1));
            //Console.WriteLine(Math.Pow((1/8),3));
            //Console.WriteLine(Convert.ToDouble(1) / Convert.ToDouble(8));
            //Console.WriteLine(Convert.ToDouble(2) / Convert.ToDouble(8));
            //Console.WriteLine(Convert.ToDouble(3) / Convert.ToDouble(8));
            //Console.WriteLine(Convert.ToDouble(4) / Convert.ToDouble(8));
        }
    }
}
