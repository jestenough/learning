using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВывод в строку и столбец:");
            int[] array = new int[N];
            for(int i = 0; i < array.Length; i++)     array[i] = rand.Next(0,100);
            foreach(int i in array)     Console.Write(i + " ");
            Console.WriteLine();
            for(int i = 1; i < array.Length; i++)    Console.WriteLine(array[i]);

            // Копия и сортировка
            Console.WriteLine("\nСоздал отсортированную копию массива:");
            int[] array_copy = new int[N];
            Array.Copy(array, 0, array_copy, 0, N);
            Array.Sort(array_copy);
            foreach(int i in array_copy)   Console.Write(i + " ");

            // Порядок элементов
            Console.WriteLine("\nИзменил порядок элементов на противоположный:");
            Array.Reverse(array_copy);
            foreach(int i in array_copy)   Console.Write(i + " ");


        }
    }
}
