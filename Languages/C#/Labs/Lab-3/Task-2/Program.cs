using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет. Введите три числа\n> ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("> ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("> ");
            double number3 = Convert.ToDouble(Console.ReadLine());
    
            if (number1 > number2 && number1 > number3 && number2 > number3)
            { 
                Console.WriteLine($"\nЧисла {number1}, {number2}, {number3} - образуют убывающую последовательность");
            }
            else Console.WriteLine($"\nЧисла {number1},{number2},{number3} - НЕ образуют убывающую последовательность :( ");
        }
    }
}
