using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nМассив:");
            Random rand = new Random();
            double[] array = new double[N];
            for (int i = 0; i < array.Length; i++)     
            array[i] = rand.Next(-100, 100) / 10.0;
            foreach(double i in array)     Console.Write(i + " ");

            double max = Int32.MinValue;
            int poz = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) 
                {
                    max = array[i];
                    poz = i;
                }
            }
            Console.WriteLine("\n\nМаксимальное число: " + max);
            Console.WriteLine("Позиция максимального числа: " + poz);

        }
    }
}
