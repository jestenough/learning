using System;
using System.Collections;

namespace Task_1
{
    class Program
    {
        /*
        Используя коллекцию ArrayList, создайте коллекцию, в которую занесите свои фамилию, имя, группу, возраст (как отдельные элементы).
        Выведите информацию на экран в столбец.
        Измените значения элементов коллекции (например, имя), удалите отчество из коллекции. Продемонстрируйте результат.
        */
        static void Main(string[] args)
        {

            ArrayList student_info = new ArrayList();

            Console.Write("Фамилия: ");
            object surname = Console.ReadLine();
            Console.Write("Имя: ");
            object name = Console.ReadLine();
            Console.Write("Отчество: ");
            object otchestvo = Console.ReadLine();
            Console.Write("Группа: ");
            object group = Console.ReadLine();
            Console.Write("Возраст: ");
            object age = Convert.ToInt32(Console.ReadLine());

            student_info.Add(surname);
            student_info.Add(name);
            student_info.Add(otchestvo);
            student_info.Add(group);
            student_info.Add(age);

            int index = student_info.IndexOf(name);
            student_info[index] = "Ерис";
            student_info.Remove(otchestvo);

            Console.WriteLine();

            foreach (object item in student_info)
                Console.WriteLine(item);





        }
    }
}
