using System;

namespace Test_1
{
    class Program
        {
        enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }

        static void MathOp(double x, double y, Operation op)
        {
            double result = 0.0;
    
            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
    
            Console.WriteLine("Результат операции равен {0}", result);
        }
 
        static void Main(string[] args)
        {
            // Тип операции задаем с помощью константы Operation.Add, которая равна 1
            MathOp(10, 5, Operation.Add);
            // Тип операции задаем с помощью константы Operation.Multiply, которая равна 3
            MathOp(11, 5, Operation.Multiply);
                
            Console.ReadLine();
        }  
    }
}
