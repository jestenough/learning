using System;

namespace Task_2
{
    class Program
    {
        /*
        Дано целое число N (> 1), а также первый член A и знаменатель D геометрической прогрессии. 
        Сформировать и вывести массив размера N, содержащий N первых членов данной прогрессии:
        A, A*D, A*D*D, A*D*D*D, ... 
        */

        static int Main(string[] args)
        {
            Console.Write("N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N <= 1) return 0;
            Console.Write("A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("D: ");
            int D = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[N];
            int D_pow = 1;

            for (int i = 0; i < N; ++i)
            {
                D_pow *= D;
                array[i] = A * D_pow;
                Console.Write(array[i] + " ");
            }

            return 0;
        }
    }
}
