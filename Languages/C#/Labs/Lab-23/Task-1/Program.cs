using System;
using System.Threading;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;

            Console.WriteLine($"Имя потока: {t.Name}");
            Console.WriteLine($"Приоритет потока: {t.Priority}");
            Console.WriteLine($"Статус потока: {t.ThreadState}");

            t.Name = "Метод СЛавика";

            Console.WriteLine($"Имя потока: {t.Name}");
            Console.WriteLine($"Приоритет потока: {t.Priority}");
            Console.WriteLine($"Статус потока: {t.ThreadState}");

        }
    }
}
