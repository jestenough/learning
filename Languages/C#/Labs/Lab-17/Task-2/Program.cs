using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        /*
        Даны имена двух файлов вещественных чисел. 
        Известно, что первый из них существует и является непустым, 
        а второй в текущем каталоге отсутствует. 
        Создать отсутствующий файл и записать в него начальный и конечный элементы существующего файла (в указанном порядке).
        */

        static void Main(string[] args)
        {
            string name1 = "File_1";
            string name2 = "File_2";
            string path = $@"/home/rteff/GitHub/Learning/Languages/C#/Labs/Lab-17/Task-2/{name1}.txt";
            string path2 = $@"/home/rteff/GitHub/Learning/Languages/C#/Labs/Lab-17/Task-2/{name2}.txt";

            StreamReader sr = new StreamReader(path);
            int length = File.ReadAllLines(path).Length;
            double[] array = new double[length];
            int i = 0;
            while (!sr.EndOfStream)
            {
                array[i] = Convert.ToDouble(sr.ReadLine());
                i++;
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(path2);
            sw.WriteLine(array[0]);
            sw.WriteLine(array[length-1]);
            sw.Close();

        }
    }
}
