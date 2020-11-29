using System;
using System.Text.RegularExpressions;

namespace Task_2
{
    class Program
    {
        /*
        Преобразовать задание 1 так, чтобы выводились числа из текста. Найти их сумму.
        (Например: «12 сентября 2019 года» -> выводится 12 2019, сумма = 2031). 
        */
        static void Main(string[] args)
        {
            Console.Write("Введите текст:\n>>> ");
            string text = Console.ReadLine();
            
            Regex reg = new Regex(@"(\d)+") ;
            MatchCollection matches = reg.Matches(text);

            Console.WriteLine("\nВывод чисел из текста:");
            foreach (Match match in matches)
                Console.Write(match.Value + " ");
            
            int summ = 0;
            foreach(Match match in matches)
                summ += Convert.ToInt32(match.Value);

            Console.WriteLine($"\n\nСумма чисел = {summ}");

        }
    }
}
