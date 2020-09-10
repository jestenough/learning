using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            double number = Convert.ToInt32(Console.ReadLine());
            double n = Math.Sqrt(number);

            if (n == (int)n) 
            {
                Console.WriteLine("Это квадрат числа");
            }
            else 
            {
                Console.WriteLine("не является квадратом");
            }
        }
    }
}
