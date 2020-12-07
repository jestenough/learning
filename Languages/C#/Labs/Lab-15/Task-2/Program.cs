using System;

namespace Task_2
{
    /*
    Определить класс массив вещественных чисел. В нем определить конструктор с параметрами и методы для нахождения: 
    • максимального элемента;
    • минимального элемента;
    • суммы элементов массива;
    • среднего арифметического элементов массива.
    Организовать выбор вызываемой функции через делегат, по аналогии с примером из п.1. 
    */

    delegate void Del();

    class Matrix
    {
        double[] arr;
        int n;

        public Matrix(int _n)
        {
            n = _n;
            arr = new double[n];
        }

        public void insert_values()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(1, 5) / 10.0;
        }
        public void Show()
        {
            Console.WriteLine("\nВаш массив");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public void Find_max()
        {
            double max = Double.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine($"\nМаксимальный элемент: {max}");
        }

        public void Find_min()
        {
            double min = Double.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine($"Минимальный элемент: {min}");
        }

        public void Summ()
        {
            double summ = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                summ += arr[i];
            }
            Console.WriteLine($"Сумма элементов: {summ}");
        }

        public void Avg_value()
        {           
            double summ = 0; 
            for (int i = 0; i < arr.Length; i++)
                summ += arr[i];
            double avg = summ / arr.Length;
            Console.WriteLine($"Среднее арифметическое: {avg}");
        }
    }
    class Program
    {
        static Del Do;
        static void Main(string[] args)
        {
            string buf;
            int n = 5;
            Matrix example = new Matrix(n);
            example.insert_values();
            while (true)
            {       
                Console.WriteLine(
                    "\nВыберите действие: \n" +
                    "show - вывод массива \n" +
                    "max - максимальный элемент\n" +
                    "min - минимальный элемент\n" +
                    "summ - сумма элементов\n" +
                    "avg - среднее элементов\n");
                Console.Write(">>> ");
                buf = Console.ReadLine();
                switch (buf)
                {
                    case "show": Do = example.Show; break;
                    case "max": Do = example.Find_max; break;
                    case "min": Do = example.Find_min; break;
                    case "summ": Do = example.Summ; break;
                    case "avg": Do = example.Avg_value; break;
                    default: Console.WriteLine("Вввели неверную команду: " + '\"' + buf + '\"' + '\n'); break;
                }
                if (Do != null) Do();
            }
        }
    }
}
