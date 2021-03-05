using System;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(Display);
            Task num_task = new Task(Numbers);
            Task name_task = new Task(Name);

            task.Start();
            num_task.Start();
            name_task.Start();


            //Task.WaitAny(task, num_task, name_task);
            Task.WaitAll(task, num_task, name_task);

            Console.WriteLine("Завершение метода Main");
        }

        static void Display()
        {
            Console.WriteLine("Начало работы метода Display");
            Console.WriteLine("Завершение работы метода Display");
        }

        static void Numbers()
        {
            for (int i = 1; i <= 3; i++)
                Console.WriteLine(i);
        }

        static void Name()
        {
            for (int i = 1; i <= 3; i++)
                Console.WriteLine("Славик/Владик/Саша");
        }
    }
}
