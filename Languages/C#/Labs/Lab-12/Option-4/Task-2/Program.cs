using System;

namespace Task_2
{
    /*
    Реализовать класс Матрица.
    
    Определить 2 конструктора:
        - для создания квадратной матрицы
        - прямоугольной матрицы.
    
    Используя перегрузку методов, реализовать 2 метода для заполнения матрицы 
        - случайными числами с указанием в качестве параметров пределов генерирования случайных чисел, 
        - числами с клавиатуры).

    Реализуйте метод вывода матрицы на экран.

    Продемонстрируйте работу программы на примере объекта. 
    */
    
    class Matrix
    {
        int[,] arr;
        int n;
        int m;

        public Matrix(int _n)
        {
            n = _n;
            m = _n;
            arr = new int[n, n];
        }

        public Matrix(int _n, int _m)
        {
            n = _n;
            m = _m;
            arr = new int[n, m];
        }

        public void insert_values(int x1, int x2)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    arr[i, j] = rnd.Next(x1, x2);
        }

        public void insert_values()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введите элемент {i+1}-{j+1}: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


        public void Show()
        {
            Console.WriteLine("\nВаша матрица");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
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
            Console.Write("Выберите тип матрицы\n[1] - Квадратная\n[2] - Прямоугольная\n>>> ");
            string question = Console.ReadLine();
            Console.Write("\nВыберите тип заполнения:\n[1] - Рандом\n[2] - Вручную\n>>> ");
            string question2 = Console.ReadLine();

            if (question == "1")
            {
                Console.Write("\nЗадайте размер квадратной матрицы:\n>>> ");
                int n = Convert.ToInt32(Console.ReadLine());
                Matrix example = new Matrix(n);
                if (question2 == "1")
                {
                    Console.Write("\nДиапазон значений:\nОт: ");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("До: ");
                    int x2 = Convert.ToInt32(Console.ReadLine());
                    example.insert_values(x1, x2);
                }
                else if (question == "2")
                    example.insert_values();
                example.Show();
            }

            else if (question == "2")
            {
                Matrix ex1 = new Matrix(3, 4);
                ex1.insert_values(10, 20);
                ex1.Show();
            }
        }
    }
}
