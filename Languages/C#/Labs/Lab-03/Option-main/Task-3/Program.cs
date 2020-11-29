using System;

namespace Task_3
{
    class Program
    {
        /*
        Разработать программу для вычисления значения выражения. 
        При реализации использовать только условную операцию (?:):
        
        max(a,b,c)
        ----------
        min(b,c)
        
        */
        static void Main(string[] args)
        {
            Console.Write("Привет. Введите три числа\n> ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("> ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("> ");
            double c = Convert.ToDouble(Console.ReadLine());
        
            double max_abc = a > b ? (a > c ? a : c) : (b > c ? b : c);
            double min_bc = b < c ? b : c;

            Console.WriteLine($"\nОтвет: {max_abc/min_bc}");
        }
    }
}
