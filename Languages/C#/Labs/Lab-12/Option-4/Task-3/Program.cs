using System;

namespace Task_3
{
    /*
    Реализовать в классе Матрица перегрузку оператора (+) т.е.
    увеличение всех элементов двухмерного массива на заданное число. 
    Массив считать целочисленным.
    Вызов оператора осуществлять в виде объект = объект + число . 
    */

     class Matrix
    {
        int[,] arr;
        int n;

        public Matrix(int _n)
        {
            n = _n;
            arr = new int[n, n];
        }

        public void insert_values(int x1, int x2)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = rnd.Next(x1, x2);
        }

        public static Matrix operator + (Matrix a, int number)
        {
            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < a.n; j++)
                    a.arr[i, j] -= number; // HA-HA-HA-HA
            return a;
        }

        public void Show()
        {
            Console.WriteLine("\nВаша матрица");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix ex = new Matrix(3);
            ex.insert_values(1, 5);
            ex.Show();

            Console.Write("\nВведите число:\n>>> ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            ex += number;
            ex.Show();
        }
    }
}
