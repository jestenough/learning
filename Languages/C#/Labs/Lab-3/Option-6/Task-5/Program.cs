using System;

namespace Task_5
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Введите цифру от [0;9]");
            byte number = Convert.ToByte(Console.ReadLine());

            switch(number)
            {
                case 0: Console.WriteLine("\nНазвание вашей цифры - НОЛЬ"); break;
                case 1: Console.WriteLine("\nНазвание вашей цифры - ОДИН"); break;
                case 2: Console.WriteLine("\nНазвание вашей цифры - ДВА"); break;
                case 3: Console.WriteLine("\nНазвание вашей цифры - ТРИ"); break; 
                case 4: Console.WriteLine("\nНазвание вашей цифры - ЧЕТЫРЕ"); break;
                case 5: Console.WriteLine("\nНазвание вашей цифры - ПЯТЬ"); break;
                case 6: Console.WriteLine("\nНазвание вашей цифры - ШЕСТЬ"); break;
                case 7: Console.WriteLine("\nНазвание вашей цифры - СЕМЬ"); break;
                case 8: Console.WriteLine("\nНазвание вашей цифры - ВОСЕМЬ"); break;
                case 9: Console.WriteLine("\nНазвание вашей цифры - ДЕВЯТЬ"); break;
                default: Console.WriteLine("Error. Число не входит в указанный диапазон [0;9]"); break;
            }
            return 0;
        }
    }
}
