using System;

namespace Task_1
{
    class Program
    {
        /*
        Реализовать статический метод, определяющий количество корней квадратного уравнения, 
        задающегося своими коэффициентами. 
        Продемонстрировать его работу в основной программе. 
        */

        static int quantity(int a, int b, int c)
        {
            int D;

            D = b*b - 4 * a * c;
            
            if (D > 0) return 2;
            else if (D == 0) return 1;
            else return 0;
        }
        static void Main(string[] args)
        {
            int a,b,c;
            
            Console.Write("Введите а,b,с\n> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("> ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("> ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nКоличество корней квадратного уравнения: {quantity(a,b,c)}");

        }
    }
}
