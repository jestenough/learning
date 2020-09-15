using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выяснить, сколько цифр в числе

            int count = 0,number; 
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());

            while(number != 0)
            {
                number /= 10;
                count++;
            } 
            Console.WriteLine($"Количество цифр в числе - {count}");
        }
    }
}
