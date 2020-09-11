using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());

            double a = Math.Sin(x);
            double b = Math.Cos(x);
            double c = Math.Log(Math.Abs(x));

            if (a < b && a < c)   Console.WriteLine("Минимальное значение у выражения а = {0:0.##}",a);
            else if (b < a && b < c) Console.WriteLine("Минимальное значение у выражения b = {0:0.##}",b);
            else if (c < a && c < b) Console.WriteLine("Минимальное значение у выражения c = {0:0.##}",c);
            else Console.WriteLine("Значения получились равными, забавно");
        }
    }
}
