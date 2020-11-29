using System;

namespace Task_2
{
    class Program
    {
        /*
        Вводятся числа до тех пор, пока не введен 0. Найти:
        - среднее арифметическое введенных чисел,
        - минимальное значение,
        - количество положительных и отрицательных значений среди введённых.
        Завершающий 0 не учитывать
        */
        static void Main(string[] args)
        {
            int number = 1; // введенное число
            int min = Int32.MaxValue; // минимальное число
            int x = 0; // кол-во итераций
            int summ = 0; // сумма чисел для среднего ариф
            int positive = 0,negative = 0; // положительнеые и отрицательные значения

            Console.WriteLine("Вводите числа, если решите прекратить, то введите 0");
            while (true)
            {
                Console.Write("> ");
                number = Convert.ToInt32(Console.ReadLine());
  
                if (number == 0) break;
                else if (number > 0) positive+=1;
                else negative+=1; 

                if (number < min) min = number;

                summ += number;
                x += 1;
            }

            if (x == 0)    Console.WriteLine("Вы ничего не ввели");
            else
            {
                Console.WriteLine("Среднее арифметическое введенных чисел: {0:0.00}",summ/(double)x);
                Console.WriteLine($"Минимальное значение из введенных чисел: {min}");
                Console.WriteLine($"Количество положительных значений: {positive}, количество отрицательных: {negative}");
            } 
        }
    }
}
