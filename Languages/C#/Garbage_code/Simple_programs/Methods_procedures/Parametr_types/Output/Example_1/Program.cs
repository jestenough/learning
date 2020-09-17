using System;

namespace Example_1
{
    class Program
    {
        static void PS(int a, int b, out int P, out int S)
        {
            P = (a + b) * 2;
            S = a * b;
        }
        static void Main(string[] args)
        {
            int s1,s2,p,s;
            s1 = 10;
            s2 = 15;

            PS(s1,s2,out p, out s);
            Console.WriteLine($"Периметр = {p}, площадь = {s}");
        }
    }
}
