using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int x = Convert.ToInt32(Console.ReadLine());
        
            switch (x)
            {
                case 1: case 2: case 3: Console.WriteLine("I квартал"); break;
                case 4: case 5: case 6: Console.WriteLine("II квартал"); break;
                case 7: case 8: case 9: Console.WriteLine("III квартал"); break;
                case 10: case 11: case 12: Console.WriteLine("IV квартал"); break;
                default: Console.WriteLine("Такого месяца нет"); break;
            }
        }
    }
}
