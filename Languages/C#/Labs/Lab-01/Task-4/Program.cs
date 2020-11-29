using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nЧастное:{(double)x1/x2}");
        }
    }
}
