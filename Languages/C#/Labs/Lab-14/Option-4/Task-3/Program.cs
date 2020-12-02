using System;

namespace Task_3
{
    class Program
    {
        /*
        Дан массив целых чисел размера N. 
        С клавиатуры вводится два числа - порядковые номера элементов массива, 
        которые необходимо суммировать (например, если ввели 3 и 5 - суммируются 3-й и 5-й элементы). 
        Вывести результат сложения. 
        Предусмотреть случаи, когда были введены не числа, и когда одно из чисел, или оба больше размера массива.
        */

        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();

                Console.Write("N: ");
                int N = Convert.ToInt32(Console.ReadLine());
                
                if (N <= 0)
                {
                    throw new Exception("Размер не может быть отрицательным или 0");
                }
                
                int[] arr = new int[N];

                for (int i = 0; i < arr.Length; i++)
                    arr[i] = rnd.Next(1,5);

                Console.Write("Введите первое число: ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int x2 = Convert.ToInt32(Console.ReadLine());
                x1 -= 1;
                x2 -= 1;
                if ((x1 > arr.Length) || (x2 > arr.Length))
                {
                    throw new Exception("Индекс не в пределах массива");
                }  

                else if (x1 < 0 || x2 < 0)
                {
                    throw new Exception("Индекс не может быть отрицательный");
                }

                Console.WriteLine("\nМассив");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");

                Console.WriteLine();

                int summa = arr[x1] + arr[x2];
                Console.WriteLine($"\nСумма чисел с индексом {x1} и {x2} = {summa}");

            }

            catch (FormatException)
            {
                Console.WriteLine("Неверный формат данных");
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Выход за пределы массива");
            }

            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


            

        }
    }
}
