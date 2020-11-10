using System;

namespace Task_4
{
    class Program
    {
        /*
        Определить ступенчатый массив на n строк. 
        длину каждой строки определить случайным образом (больше 0!).

        Описать МЕТОД, принимающий в качестве аргумента одномерный массив 
        и возвращающий среднее значение элементов.
        
        С помощью описанного метода вывести номера строк, у 
        которых AVG > 0 и сами значения AVG этих строк
        */
        static double array_AVG(int[] example)
        {
            int summ = 0;
            for (int i = 0; i < example.Length; i++)    summ += example[i];
            return (summ * 1.0) / example.Length;
        }

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
                    array[i][j] = rand.Next(-5, 5); 
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
            Console.WriteLine();
            double x = 0;
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine($"Среднее значение: {array_AVG(array[i])}");
                x = array_AVG(array[i]);
                if (x > 0) Console.WriteLine($"AVG строки №{i+1} = {x}");
                else  Console.WriteLine($"Среднее значение: {x}");

            }
        }
    }
}
