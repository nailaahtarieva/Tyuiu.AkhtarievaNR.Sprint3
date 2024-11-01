using Tyuiu.AkhtarievaNR.Sprint3.Task3.V15.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint3.Task3.V15
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
            Console.WriteLine("* Задание: 3                                                              *");
            Console.WriteLine("* Вариант: 15                                                             *");
            Console.WriteLine("* Выполнила: Ахтариева Наиля Руслановна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая используя цикл foreach, которая вычисляет   *");
            Console.WriteLine("* минимальное кол-во букв m, находящихся на соседних позициях в строке    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "lrmmse mg sermmmrt";
            char chr = 'm';

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + chr);
          
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Ответ = " + ds.GetMinCharCount(value, chr));

            Console.ReadKey();
        }
    }
}
