using System;

namespace Example_3
{
    class Program
    {
        // Квадратное ур-в

        static void KY (int a, int b, int c, out double x1, out double x2)
        {
            int D;

            D = b*b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2*a);
                x2 = (-b - Math.Sqrt(D)) / (2*a);
            }
            else if (D == 0)
            {
                x1 = -b / (2*a);
                x2 = x1;
            }
            else 
            {
                Console.WriteLine("\nКорней нет, пишу нули");
                x1 = x2 = 0;
            }
        }
        static void Main(string[] args)
        {
            int a,b,c;
            double x1, x2;
            
            Console.Write("Введите а,b,с\n> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("> ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("> ");
            c = Convert.ToInt32(Console.ReadLine());

            KY(a,b,c,out x1,out x2);

            Console.WriteLine($"Корни:{x1},{x2}");
        }
    }
}
