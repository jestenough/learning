using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());

            double e = (Math.Pow(10,7) - x * Math.Pow(y,3)) / (Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)));
            Console.WriteLine("Результат: {0:00.###}",e);
            Console.ReadKey();
        }
    }
}
