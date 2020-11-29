using System;

namespace Task_4
{
    class Program
    {
        /*
        Реализовать перегрузку метода.
        Метод выведения на экран строки:
            - полностью
            - первые N символов
            - cимволы с Nго до Mго
        */

        static void print_text(string text)
        {
            Console.WriteLine($"\nВаша строка полностью:\n{text}");
        }

        static void print_text(string text, int N)
        {
            text = text.Substring(0, N);
            Console.WriteLine($"\nПервые {N} символов в строке:\n{text}");
        }

        static void print_text(string text, int N, int M)
        {
            string text_new = "";
            for (int i = N-1; i < M-1; i++)
                text_new += text[i];
            Console.WriteLine($"\nСимволы с {N}го до {M}го в строке:\n{text_new}");
        }

        static void Main(string[] args)
        {
            Console.Write("Введите строку\n>>> ");
            string text = Console.ReadLine();

            print_text(text);
            print_text(text, 6);
            print_text(text, 3, 6);
        }
    }
}
