using Tyuiu.AkhtarievaNR.Sprint3.Task6.V9.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint3.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Ахтариева Н. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание: 6                                                              *");
            Console.WriteLine("* Вариант: 9                                                              *");
            Console.WriteLine("* Выполнила: Ахтариева Наиля Руслановна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [19, 30] количество всех делителей                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
                        
            int startValue = 19;
            int stopValue = 15;
                        
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopValue);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма делителей отрезка = " + ds.GetSumTheDivisors(startValue, startValue));

            Console.ReadKey();
        }
    }
}
