using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int numbers = number % 100;
            int num_1 = numbers / 10;
            int num_2 = numbers % 10;
            
            Console.WriteLine($"Сумма двух последних чисел - {num_1 + num_2}");

        }
    }
}
