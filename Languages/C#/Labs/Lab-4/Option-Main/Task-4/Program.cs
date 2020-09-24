using System;

namespace Task_4
{
    class Program
    {
        /*
        Описать метод DigitCount(K), 
        находящий количество цифр целого положительного числа K. 
        */

        static int DigitCount(int K)
        {
            int count = 0;
            if (K == 0) return ++count;
            for (int i = K; i != 0; i/=10) count++;
            return count;
        }
        static void Main(string[] args)
        {
            int K;            

            Console.Write("Введите число\n> ");
            K = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nКол-во цифр в числе - {DigitCount(K)}");
        }
    }
}
