using System;

namespace Task_3
{
    class Program
    {
        static void new_Price(ref double price)
        {
            if (price > 50 && price < 100) 
            {
                price = price - price * 0.05;
                Console.WriteLine("\nВам предоставляется скидка в размере 5%");
            }
            else if (price > 100) 
            {
                price = price - price * 0.10;
                Console.WriteLine("\nВам предоставляется скидка в размере 10%");
            }
            else Console.WriteLine("\nСтоимость товара не соответствует скидочным требованиям. Скидки не будет");
        }
        static void Main(string[] args)
        {
            double price;
            
            Console.Write("Введите сумму покупки\n> ");
            price = Convert.ToDouble(Console.ReadLine());

            new_Price(ref price);
            Console.WriteLine($"Итого, стоимость товара составляет: {price} рублей");
        }
    }
}
