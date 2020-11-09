using System;

namespace Task_4_2
{
    class Program
    {
        /*
        Описать МЕТОД, принимающий в качестве аргумента одномерный массив 
        и возвращающий среднее значение элементов.
        */

        static double array_AVG(int[] example)
        {
            int summ = 0;
            for (int i = 0; i < example.Length; i++)    summ += example[i];
            return (summ * 1.0) / example.Length;
        }
        
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nМассив:");
            Random rand = new Random();
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)     
            array[i] = rand.Next(1, 20);
            foreach(double i in array)     Console.Write(i + "\t");
        
            Console.WriteLine($"\nСреднее арифметическое элементов: {array_AVG(array)}");
        }
    }
}
