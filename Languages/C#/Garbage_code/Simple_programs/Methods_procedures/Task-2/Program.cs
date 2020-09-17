using System;

namespace Task_2
{
    class Program
    {
        // Метод, определяющий, является ли билет счастливым (сумма первых 3х и вторых 3х цифр должна быть одинаковая)
        static bool Ticket(int x)
        {
            int n1, n2, n3, n4, n5, n6;
            
            n1 = x / 1000000;
            n2 = x / 100000 % 10;
            n3 = x / 10000 % 10;

            n4 = x % 1000 / 100;
            n5 = x % 100 / 10;
            n6 = x % 10; 

            if (n1+n2+n3 == n4+n5+n6) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int ticket, num = 0;
            int ticket_temp;

            Console.Write("Введите номер вашего билета, помните, там 7 цифр\n> ");
            ticket = Convert.ToInt32(Console.ReadLine());
            ticket_temp = ticket;

            while (ticket_temp != 0)
            {
                ticket_temp /= 10;
                num++;
            }


            if (num == 7)
            {
                if (Ticket(ticket)) Console.WriteLine("У Вас счастливый билет!");
                else Console.WriteLine("У Вас несчастливый билет!");
            }
            else
            {
                Console.WriteLine("\nError. Не семизначное число");
                Environment.Exit(0);
            }
        }
    }
}
