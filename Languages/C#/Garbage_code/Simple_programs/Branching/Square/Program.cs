using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            // ax**2 + bx + c = 0

            double D,x1,x2;

            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            
            D = b*b - 4 * a * c;
            
            if (D > 0) 
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("\nДискриминант больше нуля");
                Console.WriteLine("Корни: x1 = {0:0.##}, x2 = {1:0.##}",x1,x2);
            }
            else if (D == 0)
            {
                x1 = -(b / (2 * a));
                Console.WriteLine("\nДискриминант равен 0\n Корень - {0:0.##}",x1);

            }
            else if (D < 0)
            {
                Console.WriteLine("\nКорней нет. Забываем о комплексных числах");
            }

        }
    }
}
