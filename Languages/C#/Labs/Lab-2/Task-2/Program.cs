using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double d1 = 1 + x + y + x * y;
            double d2 = Math.Pow(x,2) + (Math.Pow(y,3));
            double d3 = d1 / d2;
            double d = d3 * (2.0 / 3.0);
            Console.WriteLine(d);
        }
    }
}
