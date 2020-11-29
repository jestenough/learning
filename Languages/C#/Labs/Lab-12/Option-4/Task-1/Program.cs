using System;

namespace Task_1
{
    class Program
    {
        /*
        Написать программу, которая находит расстояние между двумя точками. 
        Координаты могут задаваться:
            - в одномерной
            - в двухмерной
        */

        static double Rast(double x1, double x2)
        {
            return Math.Abs(x1 - x2);
        }

        static double Rast(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        static void Main(string[] args)
        {
            double x1 = 5;
            double y1 = 4;
            double x2 = 3;
            double y2 = 2;

            Console.WriteLine(Rast(x1,x2));
            Console.WriteLine();
            Console.WriteLine(Rast(x1,y1,x2,y2));
        }
    }
}
