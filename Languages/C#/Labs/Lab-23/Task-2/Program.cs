using System;
using System.Threading;

namespace Task_2
{
    class Program
    {
        public static void Count()
        {
            for (int i = 1; i <= 10000; i++)
                Thread.Sleep(5000);
        }

        static void Main(string[] args)
        {
            Thread new_th = new Thread(Count);

            new_th.Name = "Второй поток";
            Console.WriteLine($"Статус {new_th.Name}: {new_th.ThreadState}");
            new_th.Start();

            for (int i = 0; i < 5; i++)
                Console.WriteLine($"Статус {new_th.Name}: {new_th.ThreadState}");


        }
    }
}
