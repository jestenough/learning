using System;

namespace Task_4
{
    class Program
    {
        /*
        Конвертер валют. 
        BYN -> USD
        и
        BYN -> EUR
        */
        
        static void converter(double byn, out double usd, out double eur)
        {
            usd = byn * 0.3883;
            eur = byn * 0.3293;
        }
        static void Main(string[] args)
        {
            double BYN, USD, EUR;
            Console.Write("BYN = ");
            BYN = Convert.ToDouble(Console.ReadLine());

            converter(BYN,out USD, out EUR);
            USD = Math.Round(USD,3);
            EUR = Math.Round(EUR,3);

            Console.WriteLine($"USD = {USD}\nEUR = {EUR}");
        
        }
    }
}
