using System;

namespace hello_man
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переставить в трехзначном числе разряды
            
            Console.Write("Введите число > ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int s1_number = number / 100;
            int s2_number = number / 10 % 10;
            int s3_number = number % 10;

            int new_number = (s3_number * 100) + (s2_number * 10) + s1_number;

            Console.WriteLine($"\nСотен:{s1_number} Десятков:{s2_number} Единиц:{s3_number}");
            Console.WriteLine("Готовый ответ:" + new_number);
        }
    }
}
