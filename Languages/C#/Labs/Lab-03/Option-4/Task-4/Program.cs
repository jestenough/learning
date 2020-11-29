using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            while (true)
            {
                Console.Write("Привет. Введите целое число x (1<=x<=356)\n> ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 1 || x > 356)
                {
                    Console.WriteLine($"Error. Неверное число, число {x} не в диапазоне между 1 и 356\n");
                    continue;
                }
                else break;
            }

            //day = x % 7;
            //if (day >= 1 && day <= 5) Console.WriteLine($"\nДень года с номером {x} является БУДНИМ днём");
            //else if (day == 0 || day == 6) Console.WriteLine($"\nДень года с номером {x} является ВЫХОДНЫМ днём");
            switch(x % 7)
            {
            // case 0: case 6:  Console.WriteLine($"\nДень года с номером {x} является ВЫХОДНЫМ днём"; break;
            // case 1: case: 2: case 3: case 4: case 5: Console.WriteLine($"\nДень года с номером {x} является БУДНИМ днём"); break;
                case 0: Console.WriteLine($"\nДень года с номером {x} является Воскресеньем, т.е. ВЫХОДНЫМ днём"); break;
                case 1: Console.WriteLine($"\nДень года с номером {x} является Понедельником, т.е. БУДНИМ днём"); break;
                case 2: Console.WriteLine($"\nДень года с номером {x} является Вторником, т.е. БУДНИМ днём"); break;
                case 3: Console.WriteLine($"\nДень года с номером {x} является Средой, т.е. БУДНИМ днём"); break;
                case 4: Console.WriteLine($"\nДень года с номером {x} является Четвергом, т.е. БУДНИМ днём"); break;
                case 5: Console.WriteLine($"\nДень года с номером {x} является Пятницей, т.е. БУДНИМ днём"); break;
                case 6: Console.WriteLine($"\nДень года с номером {x} является Субботой, т.е. ВЫХОДНЫМ днём"); break;
            }
        }
    }
}
