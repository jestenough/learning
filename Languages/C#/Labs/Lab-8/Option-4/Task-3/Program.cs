using System;
using System.Text.RegularExpressions;

namespace Task_3
{
    class Program
    {
        /*
        Определить, сколько в строке слов, 
        заканчивающихся на буквы «па».
        */

        static void Main(string[] args)
        {
            Console.Write("Введите текст:\n>>> ");
            string text = Console.ReadLine();
            
            Regex reg = new Regex(@"\w+па\b", RegexOptions.Multiline);
            MatchCollection matches = reg.Matches(text);

            Console.WriteLine("\nВывод слов, которые заканчиваются на 'па'");
            foreach (Match match in matches)
                Console.Write(match.Value + " ");

            Console.WriteLine($"\n\nКол-во слов заканчивающихся на 'па' = {matches.Count}");
        }
    }
}
