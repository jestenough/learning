using System;

namespace Task_2
{
    class Program
    {
        
        /*
        Дано целое число. 
        Проверить: является ли данное число положительным пятизначным числом. 
        */

        static void Main(string[] args)
        {
            int number;
            
            Console.Write("Введите число\n> ");
            number = Convert.ToInt32(Console.ReadLine());
            
            if (number > 9999 && number < 100000) Console.WriteLine($"Число {number} является положительным пятизначным числом");
            else Console.WriteLine($"Число {number} НЕ является положительным пятизначным числом");
        }
    }
}