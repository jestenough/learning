using System;

namespace Task_3
{
    class Program
    {
        /*
        Создать класс и реализовать в нем методы вычисления 
            - факториала числа N 
            - нахождения N-го числа Фибоначчи. 
        Методы реализовать как статические. 
        Продемонстрировать работу методов.
        */

        class Factorial
        {
            int _fact;

            public Factorial(int n)
            {
                Fact = n;
            }

            public int Fact
            {
                set
                {
                    if (value <= 0)
                    {
                        _fact = 1;
                    }
                    else
                    {
                        _fact = value;
                    }
                }
            }

            public int fact()
            {
                Console.WriteLine($"\nФакториал числа {_fact}:");
                int factorial = 1;
                for(int i = 1; i <= _fact; i++) 
                {
                    factorial *= i;
                    if (i == _fact) 
                    {
                        Console.Write($"{i}");
                    }
                    else 
                    {
                        Console.Write($"{i} * ");
                    }
                }                
                return factorial;
            } 
        }


        static void Main(string[] args)
        {
            Console.Write("Введите число для факториала:\n>>> ");
            int n = Convert.ToInt32(Console.ReadLine());

            Factorial example = new Factorial(n);

            Console.Write($" = {example.fact()}"); 
        }
    }
}
