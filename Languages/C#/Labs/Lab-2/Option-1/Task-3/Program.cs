using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год вашего рождения!");
            int year = Convert.ToInt32(Console.ReadLine());

            int age = DateTime.Now.Year - year;
            Console.WriteLine("Вам - {0} лет",age);
            Console.ReadKey();
        }
    }
}
