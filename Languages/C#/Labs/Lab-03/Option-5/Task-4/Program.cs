using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x < 0 && y < 0)
            {
                x = Math.Abs(x);
                y = Math.Abs(y);
                Console.WriteLine("Оба числа отрицательны, значения заменены их модулями: {0},{1}",x,y);
            }
            else if (x < 0 || y < 0)
            {
                x = x+0.5;
                y = y+0.5;
                Console.WriteLine("Одно из чисел отрицательно, оба значения увеличены на 0.5: {0},{1}",x,y);
            }       
            else if ((x > 0 && y > 0) && (x < 0.5 || x > 2.0) && (y < 0.5 || y > 2.0)) 
            {
                x = x / 10;
                y = y / 10;
                Console.WriteLine("Оба значения не отрицательны и не принадлежат отрезку [0.5;2.0]: {0},{1}",x,y);
            }
            else Console.WriteLine("Числа без изменения:{0},{1}",x,y);
       }
    }
}
