using System;

namespace Task_2
{
    class Program
    {
        /*
        Создать структуру Служащий (ФИО, стаж).
        определеить в ней конструктор с параметрами,
        метод для вывода данных об объекте.
        Продемонстрировать работу конструктора на примере 1 структурыю
        Создать массив из N структур и выполнить и вывести всез служащих,
        имеющих стаж больше заданного.
        */

        struct worker
        {
            public string full_name;
            public double expirience;
            public worker(string name, double exp)
            {
                full_name = name;
                expirience = exp;
            }
            public void display_full_name()
            {
                Console.WriteLine($"ФИО: {full_name}"); //\nСтаж РАБоты: {expirience}");
            }
        }

        static void fill_val(ref string n, ref double exp)
        {
            Console.Write("Введите ФИО: ");
            n = Console.ReadLine();
            Console.Write("Введите стаж: ");
            exp = Convert.ToDouble(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество структур:\n>>> ");
            int N = Convert.ToInt32(Console.ReadLine());

            string name = "";
            double exp = 0;

            worker[] array = new worker[N];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Заполнение структуры №{i+1}");
                fill_val(ref name, ref exp);
                array[i] = new worker(name, exp);
            }

            Console.Clear(); 
            Console.Write("Задайте cтаж: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            Console.Clear();
            Console.WriteLine($"Фамилии служащих, которые имуют стаж больше {x}");
            Console.WriteLine("------------------------------------------------");
            foreach (worker value in array)
            {
                if (value.expirience > x)    value.display_full_name();
            }
            
        }
    }
}
