using System;

namespace Task_3
{
    class Program
    {
        /*
        Решить задачу, применив оператор повтора FOR.
        Найти сумму ряда
            a) конечного, на n слагаемых
            b) бесконечного, с точностью eps, которую вводит пользователь. 
        */
        static void Main(string[] args)
        {
            int n;
            double x, summa = 0,eps;

            // a) конечного, на n слагаемых
            Console.Write("Введите количество слагаемых\n> ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x\n> ");
            x = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                summa += Math.Pow((-1),i) * (x / Math.Pow(i,3));
            }

            Console.WriteLine($"Сумма ряда, на {n} слагаемых = {summa}");

            // b) бесконечного, с точностью eps, которую вводит пользователь
            
            /*
            Console.Write("\nВведите точность EPS\n> ");
            eps = Convert.ToDouble(Console.ReadLine());
            
            summa = 0;

            for (int i = 1; x >= eps; i++)
            {
                x = Math.Pow((-1),i) * (x / Math.Pow(i,3));
                summa += x;
            }

            Console.WriteLine($"Сумма ряда = {summa}");
            */
        }
    }
}
