using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            while (true)
            {
                Console.Write("Привет. Введите целое число x (1<=x<=8)\n> ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 1 || x > 8)
                {
                    Console.WriteLine($"Error. Неверное число, число {x} не в диапазоне между [1;8]\n");
                    continue;
                }
                else break;
            }
            switch(x)
            {
                case 1: Console.WriteLine($"\nПланета, расположенная с номером {x} от солнца - Меркурий крохотный"); break;
                case 2: Console.WriteLine($"\nПланета, расположенная с номером {x} от солнца - Венера любвеобильная"); break;
                case 3: Console.WriteLine($"\nПланета, расположенная с номером {x} от солнца - Земля наша родненькая"); break;
                case 4: Console.WriteLine($"\nПланета, расположенная с номером {x} от солнца - Марс необитаемый"); break;
                case 5: Console.WriteLine($"\nПланета, расположенная с номером {x} от солнца - Юпитер огромный"); break;
                case 6: Console.WriteLine($"\nПланета, расположенная с номером {x} от солнца - Сатурн кольцевой"); break;
                case 7: Console.WriteLine($"\nПланета, расположенная с номером {x} от солнца - Уран загадочный"); break;
                case 8: Console.WriteLine($"\nПланета, расположенная с номером {x} от солнца - Нептун голубой"); break;
            }
            
        }
        
    }
}
