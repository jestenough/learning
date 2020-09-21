using System;

namespace Task_5
{
    class Program
    {
        /*
        Введите номер месяца в году и выведите его название. 
        */

        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца в году: ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch(month)
            {
                case 1: Console.Write("> Январь\n"); break;
                case 2: Console.Write("> Февраль\n"); break;
                case 3: Console.Write("> Март\n"); break;
                case 4: Console.Write("> Апрель\n"); break;
                case 5: Console.Write("> Май\n"); break;
                case 6: Console.Write("> Июнь\n"); break;
                case 7: Console.Write("> Июль\n"); break;
                case 8: Console.Write("> Август\n"); break;
                case 9: Console.Write("> Сентябрь\n"); break;
                case 10: Console.Write("> Октябрь\n"); break;
                case 11: Console.Write("> Ноябрь\n"); break;
                case 12: Console.Write("> Декабрь\n"); break;
                default: Console.Write("> Месяца с таким номером нет\n"); break;
            }

        }
    }
}
