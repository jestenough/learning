using System;

namespace Task_2
{
    class Program
    {
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
