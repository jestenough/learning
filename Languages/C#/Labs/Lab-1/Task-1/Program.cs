using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет, как тебя зовут?\n> ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, приятно познакомиться");
            
            Console.ReadKey();
        }
    }
}
