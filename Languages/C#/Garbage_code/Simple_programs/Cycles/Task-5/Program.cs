using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывести все числа [a;b] + в обратном порядке + четные

            int a,b;

            while(true)
            {
                Console.Write("Введите число a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число b: ");
                b = Convert.ToInt32(Console.ReadLine());

                if (a >= b)
                {
                    Console.Clear();
                    continue;
                }
                else break;
            }
            
            Console.Write($"\nЧисла от {a} до {b}\n> ");
            for (int i = a; i <= b; i++) Console.Write(i + " ");
            
            Console.Write($"\n\nЧисла от {a} до {b} в обратном порядке\n> ");
            for (int i = b; i >= a; i--) Console.Write(i + " ");
            
            Console.Write($"\n\nТолько четные числа от {a} до {b}\n> ");
            for (int i = a; i <= b; i++) if (i % 2 == 0) Console.Write(i + " ");
        }
    }
}
