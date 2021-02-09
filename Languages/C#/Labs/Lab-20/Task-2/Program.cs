using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        /*
        Используя коллекцию List<T>, создайте 2 коллекции.
        В первую занесите целочисленный массив размера N, во вторую – строковый массив такого же размера.
        Найдите и выведите максимальное число из коллекции чисел и самую длинную строку из коллекции строк.
        */
        static void Main(string[] args)
        {
            int[] mass = new int[4] {1, 2, 3, 4};
            string[] mass_2 = new string[4] {"1", "222222222", "333", "4444"};

            List<int> number_1 = new List<int>();
            number_1.AddRange(mass);
            List<string> number_2 = new List<string>();
            number_2.AddRange(mass_2);


            int max = Int32.MinValue;
            foreach (int i in number_1)
                if (i > max)
                    max = i;



            int max2 = Int32.MinValue;
            
            foreach (string i in number_2)
                if (i.Length > max2)
                    max2 = i.Length;

            Console.WriteLine(max);
            foreach (string i in number_2)
                if (i.Length == max2)
                    Console.WriteLine(i);


        }
    }
}
