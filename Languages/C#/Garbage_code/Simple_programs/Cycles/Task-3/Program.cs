using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вычислить, есть ли в записи числа нули

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int nill = 0;

            while(number != 0)
            {
                if (number % 10 == 0)
                {
                    nill++;
                    break;
                }
                number /= 10;
            }

            if (nill > 0) Console.WriteLine("В числе есть ноль");
            else Console.WriteLine("В числе нет нуля");
        }
    }
}
