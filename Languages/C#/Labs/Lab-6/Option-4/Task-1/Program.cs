using System;
using System.Text;

namespace Task_1
{
    class Program
    {
        /*
        Реализовать статические методы для обработки строки:
            · подсчет количества слов в строке (знаки препинания считать разделителями).

            · удаление лишних пробелов в строке.

            · удаление удвоенных слов (одинаковых рядом стоящих).

            · изменения регистра всех символов на противоположный.
        */

        static int words_count(string text)
        {
            string[] words = text.Split(new char[] {' ', '.', ',', ';', ':', '?', '!', '-'}, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)  count++;
            return count;            
        }

        static void double_words(ref string[] words)
        {
            for (int i = 0; i < words.Length-1; i++)
            {
                if (words[i] == words[i+1])
                {
                    if (words[i] == words[i+1])
                    words[i+1] = "";
                }
            }
        }

        static string change_register(string text)
        {
            char[] words = text.ToCharArray();
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsUpper(words[i]))
                    words[i] = char.ToLower(words[i]);
                else
                    words[i] = char.ToUpper(words[i]);                
            }

            string text2 = new String(words);
            return text2;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите текст\n> ");
            string user_text = Console.ReadLine();

            // Подсчёт количества слов и удаление лишних пробелов
            Console.WriteLine($"\nКоличество слов в строке: {words_count(user_text)}");

            // Удаление удвоенных слов
            Console.WriteLine("Удалил удовенные слова:");
            string[] words = user_text.Split(new char[] {' ', '.', ',', ';', ':', '?', '!', '-'}, StringSplitOptions.RemoveEmptyEntries);
            double_words(ref words);
            for (int i = 0; i < words.Length; i++)  Console.Write(words[i] + " ");

            // Изменить регистр
            Console.WriteLine($"\n\nИзменил регистр: {change_register(user_text)}");

        }
    }
}
