using System;

namespace Task_1
{
    class Program
    {
        static int MyDel(int x, int y)
        {       
            return x / y;       
        }

        static void Main()
        { 
            try 
            {
                Console.Write("Введите x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                int y = int.Parse(Console.ReadLine());
                int result = MyDel(x, y);
                Console.WriteLine("Результат: "+result);
            }
            catch (DivideByZeroException)
            {   Console.WriteLine("Деление на 0!"); }
            catch (FormatException)
            {   Console.WriteLine("Это НЕ число!"); }
        }
    }
}

