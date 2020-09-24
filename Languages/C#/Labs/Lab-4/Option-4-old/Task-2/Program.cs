using System;

namespace Task_2
{
    class Program
    {
        /*
        Дополнить программу пункта 1 методом, возвращающим корни уравнения, 
        если они есть, через выходные параметры. 
        Считать, что если у уравнения 1 корень – это 2 равных корня уравнения. 
        */
        
        static int quantity(int a, int b, int c)
        {
            int D;

            D = b*b - 4 * a * c;
            
            if (D > 0) return 2;
            else if (D == 0) return 1;
            else return 0;
        }

        static void root(int a, int b, int c, out double x1, out double x2)
        {
            int D;

            D = b*b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2*a);
                x2 = (-b + Math.Sqrt(D)) / (2*a);
            }
            else
            {
                x1 = -b / (2*a);
                x2 = x1;
            }
        }
        static int Main(string[] args)
        {
            int a,b,c;
            double x1,x2;

            Console.Write("Введите а,b,с\n> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("> ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("> ");
            c = Convert.ToInt32(Console.ReadLine());

            if (quantity(a,b,c) == 0)
            {
                Console.WriteLine("\nТак как дискриминант меньше нуля, то корней нет");
                return 0;
            }
            else
            {
                root(a,b,c,out x1,out x2);
                Console.WriteLine("\nКорни квадратного уравнения\nx1 = {0:0.###}\nx2 = {1:0.###}",x1,x2);
            }

            return 0;
        }
    }
}
