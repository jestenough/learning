using System;

namespace Task_1
{
    delegate void Del();

    interface IPeople
    {   string Name { get; set; }
        int Number { get; set; }
    }
    
    class People : IPeople
    {   public string Name { get; set; }
        public int Number { get; set; }
        public void Write()
        {
            Console.Write("Имя: ");
            Name = Console.ReadLine();
            Console.Write("Номер: ");
            Number = Convert.ToInt32(Console.ReadLine());
        }
        public void Read()
        {
            Console.WriteLine("\nИмя: {0}\nНомер: {1}", Name, Number);
        }
    }
    
    class Program
    {
        static Del Do;
        static void Main(string[] args)
        {
            string buf;
            People p = new People();
            while (true)
            {       
                Console.WriteLine(
                    "\nВыберите действие: \n" +
                    "c - создать пользователя\n" +
                    "p - вывести пользователя\n" +
                    "e - Обнулить данные \n");
                Console.Write(">>> ");
                buf = Console.ReadLine();
                switch (buf)
                {
                    case "c": Do = p.Write; break;
                    case "p": Do = p.Read; break;
                    case "e": Console.WriteLine("Завершение. Нажмите клавишу"); Console.ReadLine();
                    p = new People(); break;
                    default: Console.WriteLine("Вввели неверную команду: " + '\"' + buf + '\"' + '\n'); break;
                }
                if (Do != null) Do();
            }
        }
    }
}
