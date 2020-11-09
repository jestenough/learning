using System;

namespace Task_4
{
    class Program
    {
        /*
        Определить ступенчатый массив на n строк. 
        длину каждой строки определить случайным образом (больше 0!).
        */


        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[rand.Next(2,10)];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(1, 100); 
                }
            }

            Console.WriteLine("\nСтупенчатый массив:");
        
            foreach(int[] row in array)
            {
                foreach(int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
