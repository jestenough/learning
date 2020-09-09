using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число");
            int num = Convert.ToInt32(Console.ReadLine());

            int num1 = num / 10;
            int num2 = num % 10;

            Console.WriteLine("Сумма цифр его разрядов - {0}",num1+num2);
            Console.ReadKey();
        }
    }
}
