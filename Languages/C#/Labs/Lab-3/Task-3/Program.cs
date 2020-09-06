using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет. Введите три числа\n> ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("> ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("> ");
            double c = Convert.ToDouble(Console.ReadLine());
        
            double min_ab = a > b ? b : a;
            double min_ac = a > c ? c : a;

            Console.WriteLine($"\nОтвет: {min_ab*min_ac}");
        }
    }
}
