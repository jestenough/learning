using System;

namespace Task_2
{
    class Program
    {
        /*
        Реализовать программу, позволяющую задать пароль из 5 символов (только из 5!), 
        после чего – заполнить массив с клавиатуры. 
        Организовать вывод массива на экран после проверки корректности ввода пароля. 
        Использовать возможности обработки исключений языка C#.
        */
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[3];
                Console.Write("Задайте пароль из 5-ти символов\n>>> ");
                string pass = Console.ReadLine();

                if (pass.Length != 5)
                {    
                    throw new Exception("Длина пароля не 5 символов");
                }
                else
                {
                    Console.WriteLine("\nВведите массив:");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(">>> ");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nПодтвердите пароль:\n>>> ");
                string pass_check = Console.ReadLine();

                if (pass == pass_check)
                {
                    Console.WriteLine("\nВывод массива:");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                else
                {
                    throw new Exception("Пароли не совпадают");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
