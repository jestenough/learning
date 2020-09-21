using System;

namespace Task_1
{
    class Program
    {
        /*
        Дано число. 
        Определить, положительное оно, отрицательное или равно 0. 
        */
        
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)       Console.WriteLine($"Ваше число {number} - положительное");
            else if (number == 0) Console.WriteLine($"Ваше число {number} = 0");
            else                  Console.WriteLine($"Ваше число {number} - отрицательное");
        }
    }
}