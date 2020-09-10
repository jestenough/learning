using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет, введите строку\n> ");
            string stroka = Console.ReadLine();
            
            Console.WriteLine(stroka);
            Console.WriteLine($"\nВаша строка: {stroka}. Всё верно?");

        }
    }
}
