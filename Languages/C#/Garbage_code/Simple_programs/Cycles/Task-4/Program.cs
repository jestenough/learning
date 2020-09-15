using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число\n> ");
            double number = Convert.ToInt32(Console.ReadLine());
            double n = Math.Sqrt(number);

            if (n == (int)n) Console.WriteLine($"Число {number} - квадрат числа");
            else Console.WriteLine($"Число {number} - не является квадратом числа");
        }
    }
}
