using System;
using System.Text;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст\n> ");
            string text = Console.ReadLine();
            text = text.Replace("да", "нет", true);
            Console.WriteLine("\n" + text);

            StringBuilder stringb = new StringBuilder(text);        
            stringb.Replace("нет", "да");
            //Console.WriteLine("\n" + stringb);
            string s = stringb.ToString();
            Console.WriteLine("\n" + s);
        }
    }
}
