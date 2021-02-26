using System;
using System.Threading;

namespace Task_3
{
    class for_potok
    {
        int x {get; set;}
        public object locker = new object();


        public for_potok (int x_)
        {
            x = x_;
        }

        public void Show_x1()
        {
            lock(locker)
            {
                Console.WriteLine(x);
                x++;
            }
        }

        public void Square_x2()
        {
            lock (locker)
            {
                Console.WriteLine($"Квадрат: {x*x}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for_potok obje = new for_potok(2);

            Thread f1 = new Thread(obje.Show_x1);
            Thread f2 = new Thread(obje.Square_x2);

            f1.Start();
            f2.Start();

            // for (int i = 0; i < 3; i++)
            // {
            //     obje.Show_x1();
            //     obje.Square_x2();
            // }

            for (int i = 0; i < 10; i++)
            {
                obje.Show_x1();
                obje.Square_x2();
            }
        }
    }
}
