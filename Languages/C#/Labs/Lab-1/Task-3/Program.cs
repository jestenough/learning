using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двухзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма чисел:{(number/10) + (number%10)}");

        }
    }
}
