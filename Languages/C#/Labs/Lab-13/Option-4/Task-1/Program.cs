using System;

namespace Task_1
{
    /*
    Определить абстрактный класс Фигура и 2 класса-наследника: 
        - Квадрат
        - Окружность
    Реализовать функции подсчета площади фигуры 
        - для квадрата
        - окружности. 
    В базовом классе метод подсчёта площади определить как абстрактный.
    
    Создать массив Фигур. 
    Заполнить его случайным образом Квадратами и Окружностями. 
    Определить суммы площадей Квадратов и Окружностей (по отдельности). 
    */

    abstract class Figure
    {
        public abstract float Square();
    }
    class Kvadrat : Figure
    {
        float side;
        public Kvadrat(float _side)
        {
            side = _side;
        }
        public override float Square()
        {
            return side * side;
        }
    }
    class Circle : Figure
    {
        float rad;

        public Circle(float _rad)
        {
            rad = _rad;
        }

        public override float Square()
        {
            return (float)Math.PI * rad * rad;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Figure[] arr = new Figure[3];
            
            float kvadrat_summ = 0;
            float circle_summ = 0;
            
            for (int i = 0; i < 3; i++)
            {
                int value = rand.Next(0, 50);
                if (value <= 25)  
                {
                    arr[i] = new Kvadrat(5);
                    kvadrat_summ = arr[i].Square() + kvadrat_summ;
                }
                else if (value > 25)
                {
                    arr[i] = new Circle(5);
                    circle_summ = arr[i].Square() + circle_summ;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine(arr[i].Square());
            }

            Console.WriteLine($"\nСумма площадей Квадратов  = {kvadrat_summ}");
            Console.WriteLine($"Сумма площадей Окружностей = {circle_summ}");
        }
    }
}
