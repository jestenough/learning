using System;

namespace Task_1
{
    class Program
    {
        /*
        Описать класс Работник (поля – фио, должность, оклад).

        Реализовать свойства для каждого поля: 
            - Фио – только для чтения, 
            - Оклад и должность – для чтения и записи. Контролировать значения оклада на неотрицательность
     
        Конструктор с параметрами
        
        Методы:
            - Вывода данных на экран, 
            - Вычисления зарплаты (если работник – менеджер, то премия - 30% от оклада, 
                                    в ином случае – 20% от оклада).

        Заполнить в основной программе список работников на N объектов.

        Вывести список в алфавитном порядке.

        Вывести список сотрудников с зарплатой выше X рублей. 
        */

        class Worker : IComparable <Worker>
        {
            string _full_name;
            string _post;
            int _salary;
            double _premium;

            public Worker(string full_name, string post, int salary)
            {
                _full_name = full_name;
                _post = post;
                this.salary = salary;
                _premium = Premium_calc();
            }
            
            public string full_name
            {
                get { return _full_name; }
            }

            public string post
            {
                get { return _post; }
                set 
                { 
                    _post = value; 
                }
            }

            public int salary
            {
                get { return _salary; }
                set 
                {
                    while (value == 0)
                    {
                        Console.WriteLine("Ошибка!\nРАБота за бесплатно, повторите ввод:");
                        Console.Write("Введите оклад: ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    if (value < 0)
                        _salary = Math.Abs(value);                     
                   else
                        _salary = value;
                    
                }
            }

            public double premium
            {
                get { return _premium; }
                set { _premium = value; }
            }

            public void Show()
            {
                Console.WriteLine($"\nФИО: {_full_name}\nДолжность: {_post}\nЗарплата: {_salary}\nПремия: {_premium}");
            }

            public double Premium_calc()
            {
                if (_post == "Менеджер")    
                    return _premium = _salary * 30 / 100;
                else
                    return _premium = _salary * 20 / 100;
            }

            public int CompareTo(Worker x)
            {
                if (x == null)
                    return -1;
                return _full_name.ToLower().CompareTo(x.full_name.ToLower());
            }
        }

        static void fill_data(ref string name, ref string post, ref int salary)
        {
            Console.Write("Введите ФИО: ");
            name = Console.ReadLine();
            Console.Write("Введите должность: ");
            post = Console.ReadLine();
            Console.Write("Введите оклад: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            string name = "Неизвестно";
            string post = "Неизвестно";
            int salary = 0;

            Console.Write("Количество работников:\n>>> ");
            int N  = Convert.ToInt32(Console.ReadLine());

            Worker[] workers = new Worker[N];
            for (int i = 0; i < N; i++)
            {
                Console.Clear();
                Console.WriteLine($"Заполнение работника №{i+1}");
                fill_data(ref name, ref post, ref salary);
                workers[i] = new Worker(name, post, salary);
            }

            Console.Clear();
            Console.WriteLine("Посмотреть список в алфавитном порядке");
            Console.ReadKey();


            Console.WriteLine("\nСписок сотрудников в алфавитном порядке:");
            Console.WriteLine("----------------------------------------");


            Array.Sort(workers);
            //Array.Sort(workers, (x, y) => String.Compare(x.full_name, y.full_name));
            
            foreach (Worker employee in workers)
                employee.Show();

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Задать зарплату");
            Console.ReadKey();

            Console.Write("\nЗадайте зарплату:\n>>> ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nСписок сотрудников с зарплатой > [{x}]");
            Console.WriteLine("----------------------------------------");
            foreach (Worker employee in workers)
            {
                if (employee.salary > x)
                    employee.Show();
            }
        }
    }
}
