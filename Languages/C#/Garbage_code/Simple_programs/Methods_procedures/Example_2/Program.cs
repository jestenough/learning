using System;

namespace Example_2
{
    class Program
    {
        // Решить линейное ур-в

        static double YR(int a, int b, int c)
        {
            return (c - b) / (a * 1.0);
        }
        static void Main(string[] args)
        {
            int a,b,c;
            a = 10;
            b = 4;
            c = 23;
        
            Console.WriteLine(YR(a,b,c));
        }
    }
}
