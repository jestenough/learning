using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(1, 10, Factorial);
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 },Factorial);

        }

        static void Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
                result *= i;

            Console.WriteLine("Выполняется задача {0}", Task.CurrentId);
            Console.WriteLine("Факториал числа {0} равен {1}", x, result);
            Thread.Sleep(3000);
        }

    }
}
