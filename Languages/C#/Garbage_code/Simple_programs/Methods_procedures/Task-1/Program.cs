using System;

namespace Task_1
{
    // Метод, определяющий количество цифр в числе
    class Program
    {
        // Написать метод, который определяет кол-во цифр в числе
        static int numbers(int x)
        {
            int num = 0;
            while (x != 0)
            {
                x /= 10;
                num++;
            }
            return num;
        }
        static void Main(string[] args)
        {
            int number;

            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Количество цифр в числе: {numbers(number)}");
        }
    }
}
