using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите три числа\n> ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("> ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("> ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            if (x1 < x2 && x1 < x3)
            {
                Console.WriteLine("Первое число {0} - является минимальным из чисел {0},{1},{2}",x1,x2,x3);
            }
            else
            {
                Console.WriteLine("Первое число {0} - НЕ является минимальным из чисел {0},{1},{2}",x1,x2,x3);
            }


        }
    }
}
