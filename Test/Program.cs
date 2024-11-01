namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "vn98n! b,.";
            string result = "";
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    result += c;
                }
            }
            
            Console.WriteLine(result);
        }
    }
}
