using System;

namespace Task_1
{
    class Program
    {
        /*
        Разработать программу, выполняющую следующие действия: создать матрицу размерности m x n. 
        Заполнить случайными числами. Вывести в виде таблицы.
        Вычислить количество отрицательных элементов матрицы. 
        */

        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите количество элементов в столбце: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество элементов в строке: ");
            int n = Convert.ToInt32(Console.ReadLine());            
            int count = 0;
        
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

            foreach (int i in array)    if (i < 0)  count++;
            Console.WriteLine($"\nЧисло отрицательных элементов матрицы: {count}");
        }
    }
}
