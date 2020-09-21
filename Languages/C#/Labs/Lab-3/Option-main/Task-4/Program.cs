using System;

namespace Task_4
{
    class Program
    {
        /*
        Известны два расстояния: одно в километрах, другое в футах. 
        Какое из расстояний меньше? 
        */

        static void Main(string[] args)
        {
            double km,ft;
            
            Console.Write("Введите расстояние в км: ");
            km = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояние в футах: ");
            ft = Convert.ToDouble(Console.ReadLine());

            // 1 ft = 0.305 m
            if (ft * 0.305 / 1000 > km) Console.WriteLine("Расстояние в километрах меньше, чем расстояние в футах");
            else Console.WriteLine("Расстояние в футах меньше, чем расстояние в километрах");
        }
    }
}
