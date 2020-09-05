using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение ребра: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double V = Math.Pow(x,3);
            double S = 6 * Math.Pow(x,2);
            
            Console.WriteLine($"\nОбъем поверхности куба = {V}\nПлощадь поверхности куба = {S}");
        }
    }
}
