using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = Convert.ToInt32(Console.ReadLine());

            int a1 = a*a;    // (a^2)                             // 1
            int a2 = a1*a1;     // (a^4)                          // 2
            int a3 = a2*a2;    // (a^8)                           // 3
            int a_28 = a3*a3*a3*a2;    // 8+8+8+4=28 (a^28)       // 4
            
            Console.WriteLine("a^28 = {0}",a_28);
        }
    }
}
