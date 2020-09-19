using System;

namespace Task_1
{
    class Program
    {
        /* 
        Вывести числа от a до b на экран.
        Предусмотреть варианты ввода a<b и a>b.
        */

        static void Main(string[] args)
        {
            int a,b;

            Console.Write("Введите a\n> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b\n> ");
            b = Convert.ToInt32(Console.ReadLine());
        

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else if (a > b)
            {
                for (int i = a; i >= b; i--) 
                {
                    Console.Write(i + " ");
                }
            }
            else Console.WriteLine("-> Числа одинаковы");
        }
    }
}
