using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Выводить вопрос "ещё?", пока user не введёт "нет"

            string question = " ";
            
        //  while (!(question == "нет"))
            while (question != "нет")
            {
                Console.WriteLine("Ещё?");
                question = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
