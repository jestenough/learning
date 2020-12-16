using System;
using System.IO;

namespace Task_1
{
    /*
    Ввести с клавиатуры последовательность из 10 чисел и записать ее в файл. 
    Реализовать считывание из файла записанных чисел и вычисление их среднего арифметического. 
    Допишите среднее значение в конец файла.
    */
    
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/home/rteff/GitHub/Learning/Languages/C#/Labs/Lab-17/Task-1/numbers.txt";
            int[] array = new int[10];
            StreamWriter sw = new StreamWriter(path, false);
            Console.WriteLine("Введите 10 чисел:");
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"№{i+1}: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    sw.WriteLine(array[i]);
                }
                Console.WriteLine("Текст записан в файл");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            sw.Close();

            StreamReader sr = new StreamReader(path);
            int j = 0;
            int summ = 0;
            while (!sr.EndOfStream)
            {
                array[j] = Convert.ToInt32(sr.ReadLine());
                summ += array[j];
                j++;
            }
            double avg = summ / 10.0;
            
            sr.Close();
            
            StreamWriter sw1 = new StreamWriter(path, true);
            sw1.Write(avg);
            sw1.Close();
            
 
        }
    }
}
