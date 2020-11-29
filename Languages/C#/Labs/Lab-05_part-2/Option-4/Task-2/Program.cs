using System;

namespace Task_2
{
    class Program
    {
        /*
        Найти максимальный и минимальный элементы матрицы, 
        вывести их значения и их позиции (строка и столбец).
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

            int min_value = Int32.MaxValue;
            int max_value = Int32.MinValue;
            int line = 0;
            int column = 0;
            int line2 = 0;
            int column2 = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {   
                    if (array[i, j] < min_value)    
                    {
                        min_value = array[i, j];
                        line = i+1;
                        column = j+1;
                    }
                    if (array[i, j] > max_value)    
                    {
                        max_value = array[i, j];
                        line2 = i+1;
                        column2 = j+1;
                    }
                }
            }

            Console.WriteLine($"\nМинимальное значение: {min_value}, находится в {line} строке, {column} столбце");
            Console.WriteLine($"Максимальное значение: {max_value}, находится в {line2} строке, {column2} столбце");
        }
    }
}
