using System;

namespace man_buying_beer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет, какого ты года рождения?\n> ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("А какой месяц рождения?\n> ");
            int mounth = Convert.ToInt32(Console.ReadLine());
            Console.Write("А какой день?\n> ");
            int day = Convert.ToInt32(Console.ReadLine());


            if (DateTime.Now.Year - year > 18) Console.WriteLine("Отлично, Вам есть 18");  
            else if ((DateTime.Now.Year - year == 18) && (DateTime.Now.Month > mounth)) Console.WriteLine("Отлично, Вам есть 18");  
            else if (DateTime.Now.Year - year == 18 && DateTime.Now.Month == mounth && DateTime.Now.Day > day) Console.WriteLine("Отлично, Вам есть 18");  
            else Console.WriteLine("Не продам, Вам нет 18-ти");
  


        }
    }
}
