using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет. Введите три числа");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
        
            
            double ac = a > c ? a : c;
            double bc = b > c ? b : c;

            Console.WriteLine($"\nОтвет: {ac/bc}");
        }
    }
}
