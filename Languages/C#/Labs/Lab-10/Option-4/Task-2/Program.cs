using System;

namespace Task_2
{
    class Program
    {
        /*
        Задать массив объектов. Выбрать объекты, подходящие по заданному критерию.

        Фотоаппарат Марка = x 
        */

        class Camera
        {

            string _marka = "Неизвестно";
            string _model_name = "Неизвестно";
            double _price;

            public Camera(string marka, string model_name, double cost)
            {
                _marka = marka;
                _model_name = model_name;
                Price = cost;
            }


            public string Marka
            {
                get { return _marka; }
            }
            public string Model_name
            {
                get { return _model_name; }
            }

            public double Price
            {
                get { return _price; }
                set 
                {
                    if (value <= 0)
                    {
                        _price = 1337;
                        Console.WriteLine("\nНегодяй");
                    }
                    else
                    {
                        _price = value;
                    }
                }
            }

            public void Show()
            {
                Console.WriteLine($"\nМарка фотика: {_marka}\nМодель: {_model_name}\nЦена: {_price}");
            }        
        }

        static void Main(string[] args)
        {   
            Console.Write("Количество объектов:\n>>> ");
            int N  = Convert.ToInt32(Console.ReadLine());

            Camera[] array = new Camera[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("\nВведите марку фотика\n>>> ");
                string m = Console.ReadLine();
                Console.Write("Введите модель фотика\n>>> ");
                string mod = Console.ReadLine();
                Console.Write("Введите цену фотика\n>>> ");
                int cost = Convert.ToInt32(Console.ReadLine());
                array[i] = new Camera(m, mod, cost);
            }

            Console.Write("\nЗадайте x\n>>> ");
            string x = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"\nОбъекты, у которых марка {x}");
            Console.WriteLine("--------------------------------");
            foreach (Camera value in array)
            {
                if (value.Marka == x)
                    value.Show();
            }
            
            
            
        }
    }
}
