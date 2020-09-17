using System;

namespace Example_1
{
    class Program
    {
        static void Function(ref int a)
        {
            a++;
        }
        static void Main(string[] args)
        {
            int a = 10;
            Function(ref a);
            Console.WriteLine(a); // 11
        }
    }
}
