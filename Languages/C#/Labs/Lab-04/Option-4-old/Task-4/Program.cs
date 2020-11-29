using System;

namespace Task_4
{
    class Program
    {
        /*
        Описать метод TriangleP(a, h), 
        находящий периметр и площадь равнобедренного треугольника 
        по его основанию (a)
        и высоте (h), проведенной к основанию (a и h — вещественные). 
        */

        static void TrianglePS(double a, double h, out double P, out double S)
        {
            P = a + 2 * Math.Sqrt(Math.Pow(a/2.0,2) + Math.Pow(h,2));
            S = 0.5 * a * h;
        }
        static void Main(string[] args)
        {
            double b,h;
            double P,S;            

            Console.Write("Введите основание: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту: ");
            h = Convert.ToDouble(Console.ReadLine());

            TrianglePS(b,h,out P, out S);
            Console.WriteLine("\nПериметр = {0:0.###}, площадь = {1:0.###}",P,S);
        }
    }
}
