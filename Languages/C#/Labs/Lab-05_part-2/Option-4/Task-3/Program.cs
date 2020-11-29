using System;

namespace Task_3
{
    class Program
    {
        /*
        Определить сумму элементов каждой строки матрицы.
        */
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите количество элементов в столбце: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество элементов в строке: ");
            int n = Convert.ToInt32(Console.ReadLine());            
        
            Console.WriteLine("\nМатрица:");

            int[,] array = new int [m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(-100,100);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int summ;

            for (int i = 0; i < m; i++)
            {
                summ = 0;
                for (int j = 0; j < n; j++)     summ += array[i, j];
                Console.WriteLine($"Сумма элементов {i+1} строки: {summ}");
            }
        }
    }
}
