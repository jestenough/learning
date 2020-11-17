using System;

namespace Task_1
{
    class Program
    {
        /*
        Создать структуру Студент (ФИО, специальность, группа, средний балл).
        Поле «Специальность» реализовать перечислением (значения ЭП, ПЗ, ЭЭ, ВР, КД), группу – целым числом.
        
        Объявить и заполнить массив из N структур. 
        Вывести ФИО студентов, имеющих средний балл выше заданного балла X.
        */

        struct Student
        {
            public string full_name;
            public enum specialty {EP, PZ, EE, VR, KD};
            public specialty value;
            public int group;
            public double AVG_marks;
            public Student(string name, specialty spec_value, int gr, double avg_m)
            {
                full_name = name;
                value = spec_value;
                group = gr;
                AVG_marks = avg_m;
            }
            public void show()
            {
                Console.WriteLine($"ФИО: {full_name}\n"); //\nГруппа: {value}{group}\nСредний балл: {AVG_marks}");
            }
        }

        static void fill_val(ref string n, ref Student.specialty spec, ref int group, ref double mark)
        {
            Console.Clear(); 
            Console.Write("Введите ФИО: ");
            n = Console.ReadLine();
            Console.Write("Выберите специальность: ЭП, ПЗ, ЭЭ, ВР, КД: ");
            string val = Console.ReadLine();
            switch (val)
            {
                case "ЭП": spec = Student.specialty.EP; break;
                case "ПЗ": spec = Student.specialty.PZ; break;
                case "ЭЭ": spec = Student.specialty.EE; break;
                case "ВР": spec = Student.specialty.VR; break;
                case "КД": spec = Student.specialty.KD; break;
                default:   Console.WriteLine("Нет такой специальности, записываю Вас в программисты!"); 
                        spec = Student.specialty.PZ; 
                        break;

            }
            Console.Write("Введите номер группы: ");
            group = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите средний балл: ");
            mark = Convert.ToDouble(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество структур:\n>>> ");
            int N = Convert.ToInt32(Console.ReadLine());

            string name = "";
            int group = 0;
            Student.specialty spec = (Student.specialty)0;
            double mark = 0.0;

            Student[] array = new Student[N];
            for (int i = 0; i < array.Length; i++)
            {
                fill_val(ref name, ref spec, ref group, ref mark);
                array[i] = new Student(name, spec, group, mark);
            }

            Console.Clear(); 
            Console.Write("Задайте балл (x): ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            foreach (Student value in array)
            {
                if (value.AVG_marks > x)    value.show();
            }

        }
    }
}
