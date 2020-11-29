using System;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stroka = new StringBuilder("Привет, мир!");
            Console.WriteLine(stroka);
            Console.WriteLine($"Длина строки: {stroka.Length}");
            Console.WriteLine($"Емкость строки: {stroka.Capacity}");
        
            stroka.Append("Привет, все!");
            Console.WriteLine("\n" + stroka);
            Console.WriteLine($"Длина строки: {stroka.Length}");
            Console.WriteLine($"Емкость строки: {stroka.Capacity}");
        }
    }
}
