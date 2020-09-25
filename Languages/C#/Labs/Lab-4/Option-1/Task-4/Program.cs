using System;

namespace Task_4
{
    class Program
    {
        /*
        Описать метод SumRange(A, B), находящий сумму и произведение 
        всех целых чисел от A до B включительно (A и B — целые). 
        Если A > B, то результатами станут нули
        */
        static void SumRange(int A, int B, out int Summ, out int Mult,out bool flag)
        {
            flag = false;
            if (A > B)
            {
                Summ = 0;
                Mult = 0;
                flag = true;
            }
            else
            {
                Summ = 0;
                Mult = 1;
                for(int i = A; i <= B; i++)
                {
                    Summ = Summ + i;
                    Mult = Mult * i;
                }
            }
        }
        static void Main(string[] args)
        {
            int A,B;
            int Summ,Mult;
            bool flag;

            Console.Write("Введите A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            B = Convert.ToInt32(Console.ReadLine());
        
            SumRange(A,B,out Summ, out Mult, out flag);
            if (flag)   Console.WriteLine($"\nA > B\nРезультаты суммы - {Summ}, произведения = {Mult}");
            else    Console.WriteLine($"\nСумма чисел [{A};{B}] = {Summ}\nПроизведение чисел [{A};{B}] = {Mult}");
        }
    }
}
