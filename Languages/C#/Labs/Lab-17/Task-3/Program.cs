using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        /*
        Дан текстовый файл. 
        Отсортировать строки в нем по алфавиту.
        */
        
        static void Main(string[] args)
        {
            string path = "text.txt";
            StreamReader sr = new StreamReader(path);
            
            int length = File.ReadAllLines(path).Length;
            string[] array = new string[length];
            
            int j = 0;
            while (!sr.EndOfStream)
            {
                array[j] = sr.ReadLine();
                j++;
            }
            sr.Close();

            Array.Sort(array);
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < length; i++)
                sw.WriteLine(array[i]);

            sw.Close();
        }
    }
}
