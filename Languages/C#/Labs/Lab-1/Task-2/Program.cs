using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма:{x1+x2}, разность:{x1-x2}, произведение:{x1*x2}, частное:{(double)x1/x2}");
            Console.ReadKey();
        }
    }
}
