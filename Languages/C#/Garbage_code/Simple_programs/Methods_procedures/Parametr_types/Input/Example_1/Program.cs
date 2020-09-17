using System;

namespace Example_1
{
    class Program
    {
        // Входные параметры метода - осущ. с копиями, изменять их нельзя, повлиять тоже

        static void Func(int a) 
        {
            a++;
        }
        static void Main(string[] args)
        {
            int a = 10;
            Func(a);
            Console.WriteLine(a); // 10
        }
    }
}
