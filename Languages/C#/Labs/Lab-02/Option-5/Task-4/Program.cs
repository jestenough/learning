using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5-значное число");
            int number = Convert.ToInt32(Console.ReadLine());


            // 12345

            int number_last_num = number % 10; // 5
            int number_last = number / 10;     // 1234

            int end = number_last_num * 10000 + number_last;

            Console.WriteLine("\nЗачеркнул последнюю цифру({0}) и приписал её в начале - {1}",number_last_num,end);
            Console.ReadKey();
        }
    }
}
