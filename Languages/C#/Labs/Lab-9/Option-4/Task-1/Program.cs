using System;
using System.Text.RegularExpressions;

namespace Task_1
{
    class Program
    {
        /*
        Описать метод, вычисляющий и возвращающий в основную программу
        кол-во вхождений указанной подстроки в строку. С помощью перечисления
        передавать в этот параметр: учитывать или не учитывать регистр символов.
        Продемонстрировать работу обоих вариантов метода
        */

        enum register {consider, ignore}

        static int count_input(string text, string pod, register reg)
        {
            if (reg == register.consider)
            {
                Regex regexx = new Regex($@"\w*{pod}\b");
                MatchCollection matches = regexx.Matches(text);
                return matches.Count;
            }
            else if (reg == register.ignore)
            {
                Regex regexx = new Regex($@"\w*{pod}\b", RegexOptions.IgnoreCase);
                MatchCollection matches = regexx.Matches(text);
                return matches.Count;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите текст:\n>>> ");
            string text = Console.ReadLine();

            Console.Write("Введите подстроку:\n>>> ");
            string podstroka = Console.ReadLine();

            Console.Write("\nУчитывать регистр? [(Д)а/(Н)ет]: ");
            string question = Console.ReadLine();
            
            register regestr = register.ignore;
            
            if (question == "Д" || question == "Да")
                regestr = register.consider;
            else if  (question == "Н" || question == "Нет")
                regestr = register.ignore;
            else
                Console.WriteLine("Error");

            Console.WriteLine($"Количество вхождений: {count_input(text, podstroka, regestr)}");

        }
    }
}
