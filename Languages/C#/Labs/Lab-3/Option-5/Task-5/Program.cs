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
                case 1: Console.WriteLine("Месяц: Январь. I квартал"); break;
                case 2: Console.WriteLine("Месяц: Февраль. I квартал"); break;
                case 3: Console.WriteLine("Месяц: Март. I квартал"); break;
                case 4: Console.WriteLine("Месяц: Апрель. II квартал"); break;
                case 5: Console.WriteLine("Месяц: Май. II квартал"); break;
                case 6: Console.WriteLine("Месяц: Июнь. II квартал"); break;
                case 7: Console.WriteLine("Месяц: Июль. III квартал"); break;
                case 8: Console.WriteLine("Месяц: Август. III квартал"); break;
                case 9: Console.WriteLine("Месяц: Сентябрь. III квартал"); break;
                case 10: Console.WriteLine("Месяц: Октябрь. IV квартал"); break;
                case 11: Console.WriteLine("Месяц: Ноябрь. IV квартал"); break;
                case 12: Console.WriteLine("Месяц: Декабрь. IV квартал"); break;
            }
        }
    }
}
