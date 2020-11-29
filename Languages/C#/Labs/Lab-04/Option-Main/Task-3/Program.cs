using System;

namespace Task_3
{
    class Program
    {
        /*
        Описать функцию CubeV(a), 
        вычисляющую по стороне a куба его объем 
        V = a3. 
        */

        static double CubeV(double a)
        {
            return Math.Pow(a,3);
        }
        static void Main(string[] args)
        {
            double a;
            
            Console.WriteLine("Введите значение стороны куба");
            Console.Write("> ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nОбъем куба = {0:0.###}",CubeV(a));
        }
    }
}
