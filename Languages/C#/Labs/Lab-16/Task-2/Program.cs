using System;
using System.Text.RegularExpressions;

namespace Task_2
{
    /*
    Реализовать с использованием классов и механизма событий:  
    Метод считывает вводимую пользователем строку. Если в строке находятся числа, 
    вывести сообщение «ОБНАРУЖЕНЫ ЧИСЛА!» (один метод) и найти сумму чисел (не цифр!) в строке (другой метод). 
    Ввод строк организовать циклом (решите сами, каким образом прерывать цикл). 
    Сообщение и подсчет суммы реализовать двумя методами, а не одним (подписать их на событие).
    */

    class Stroka
    {
        public delegate void MethodContainer();
        public event MethodContainer numbers_founded;
        
        string text;

        public Stroka (string _text)
        {
            text = _text;
        }

        public void find_numbers()
        {
            Regex reg = new Regex(@"(\d)+") ;
            MatchCollection matches = reg.Matches(text);

            int count = matches.Count;
            if (count != 0)
                numbers_founded();           
        }

        public void Message()
        {
            Console.WriteLine("ОБНАРУЖЕНЫ ЧИСЛА!");
        }

        public void summ_numbers()
        {
            int summ = 0;
            Regex reg = new Regex(@"(\d)+") ;
            MatchCollection matches = reg.Matches(text);
            foreach(Match match in matches)
                summ += Convert.ToInt32(match.Value);
            Console.WriteLine($"Сумма чисел = {summ}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string stroka;

            while (true)
            {
                Console.Write(">>> ");
                stroka = Console.ReadLine();
                if (stroka == "славик") break;
                else
                {   
                    Stroka text = new Stroka(stroka);
                    text.numbers_founded += text.Message;
                    text.numbers_founded += text.summ_numbers;
                    text.find_numbers();
                    Console.ReadKey();
                }
            }
        }
        
    }
}
