namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;  
            int c = 5;
            int d = 9;
            int i = 1;
            while(i<5)
            {
                b++;
                b += a;
                c = b - a;
                d = (c + a) + i;
                i++;
            }
            Console.WriteLine(d);
        }
    }
}
