using System;

namespace Task_3
{
    class Program
    {
        /*
        Описать функцию Minmax(X, Y),
        записывающую в переменную X минимальное из значений X и Y,
        а в переменную Y — максимальное из этих значений
        */

        static void Minmax(ref double x, ref double y)
        {
            if (x > y)
            {
                double temp;
                temp = x;
                x = y;
                y = temp;
            }
        }
        static void Main(string[] args)
        {
            double x,y;

            Console.Write("Введите первое число: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = Convert.ToDouble(Console.ReadLine());

            Minmax(ref x, ref y);
            Console.WriteLine($"\nМаксимальное число - {y}\nМинимальное число - {x}");
        }
    }
}
