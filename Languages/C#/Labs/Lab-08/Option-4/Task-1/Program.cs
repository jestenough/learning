using System;
using System.Text.RegularExpressions;

namespace Task_1
{
    class Program
    {
        /*
        При помощи регулярных выражений вывести все цифры (по 1), содержащиеся в тексте.
        (Например: «12 сентября 2019 года» -> выводится 1 2 2 0 1 9)
        */
        
        static void Main(string[] args)
        {
            Console.Write("Введите текст:\n>>> ");
            string text = Console.ReadLine();
            
            Regex reg = new Regex(@"\d") ;
            MatchCollection matches = reg.Matches(text);

            Console.WriteLine("\nВывод всех цифр (по 1):");
            foreach (Match match in matches)
                Console.Write(match.Value + " ");
        }
    }
}
