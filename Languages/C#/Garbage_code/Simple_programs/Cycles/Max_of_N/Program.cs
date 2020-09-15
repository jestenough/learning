using System;

namespace Max_of_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int max = Int32.MinValue;
            int num;

            for (int i = 0; i < N; i++)
            {
                Console.Write("> ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > max)  max = num;
            }
            Console.WriteLine($"Максимальное число:{max}");
        }
    }
}
