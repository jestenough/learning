using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;

            double P = 2 * pi * r;
            double S = pi * Math.Pow(r,2);
            
            Console.WriteLine("\nДлина круга = {0:0.###}, Площадь круга = {1:0.###}",P,S);
            Console.ReadKey();
        }
    }
}
