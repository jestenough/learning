using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a\n> ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b\n> ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c\n> ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите d\n> ");
            double d = Convert.ToDouble(Console.ReadLine());


            double max_ab = a > b ? a : b;
            double min_cd = c > d ? d : c;
            double max_ac = a > c ? a : c;

            Console.WriteLine("\nОтвет:{0:0.###}",max_ab * min_cd / max_ac);

        }
    }
}
