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
                summa += i / Math.Pow(i+1,2);
            }

            Console.WriteLine("Сумма ряда, на {0} слагаемых = {1:0.###}",n,summa);

            // b) бесконечного, с точностью eps, которую вводит пользователь
            
            Console.Write("\nВведите точность EPS\n> ");
            eps = Convert.ToDouble(Console.ReadLine());
            
            if (eps > 0)
            {
                summa = 0;
                int i = 1;
                double sl =  i / Math.Pow(i+1,2);

                for (i = 1; Math.Abs(sl) > eps; i++)
                {
                    summa += sl;
                    sl = i / Math.Pow(i+1,2);
                }
            }
            else Console.WriteLine("Нужно ввести eps больше нуля!");
            
            Console.WriteLine("Сумма ряда = {0:0.###}",summa);
        }
    }
}
