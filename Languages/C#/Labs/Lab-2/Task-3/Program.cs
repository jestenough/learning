using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение ребра куба: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double V = Math.Pow(x,3);   
            double S = 6 * Math.Pow(x,2);
            
            Console.WriteLine("\nОбъем поверхности куба = {0:0.##}\nПлощадь поверхности куба = {1:0.##}",V,S);
        }
    }
}
