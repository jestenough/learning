using System;

namespace Chet_1_Nechet_0_HAHA
{
    class Program
    {
        static void Main(string[] args)
        {
            // НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ ЦИКЛЫ ИЛИ УСЛОВНЫЕ ОПЕРАТОРЫ (РАЗНОГО РОДА)
            
            // Вводится число. узнать, если оно чётное - вывести 1, а если нечетное - 0

            
            // Способ 1
            Console.Write("> ");
            int number = Convert.ToInt32(Console.ReadLine());
            number++;
            number = number % 2;


            // Способ 2
            Console.Write("> ");
            number = Convert.ToInt32(Console.ReadLine());
            number %= 2 - 1;
            number = Math.Abs(number);


            // Способ 3
            // Через bool и функцию

            //Console.WriteLine(number);
        }
    }
}
