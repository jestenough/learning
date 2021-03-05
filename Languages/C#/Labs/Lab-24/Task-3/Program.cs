using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() {rnd.Next(1, 50), rnd.Next(1,50), rnd.Next(1,50)}, prime_number);
        }

        static void prime_number(int n)
        {
            bool prost = true;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                Console.WriteLine($"Число {n} простое");
            }
            else
            {
                Console.WriteLine($"Число {n} НЕ ПРОСТОЕ");
            }
        }
    }
}
