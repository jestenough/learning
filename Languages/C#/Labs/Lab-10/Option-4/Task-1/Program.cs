using System;

namespace Task_1
{
    class Program
    {
        /*
        Описать класс согласно варианту задания.
        -   Реализовать в классе конструктор по умолчанию (без параметров) и конструктор с параметрами. 
        -   Продемонстрировать работу конструкторов.
        -   Добавить в класс свойства, соответствующие каждому полю. 
        -   Продемонстрировать работу свойств. 
        -   Реализовать метод Show(), выводящий всю информацию об объекте. 

        Фотоаппарат 
        */

        class Camera
        {
            string _marka = "Неизвестно";
            string _model_name = "Неизвестно";
            double _price;

            public Camera()
            {

            }

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
            Console.Write("Введите марку фотика\n>>> ");
            string m = Console.ReadLine();
            Console.Write("Введите модель фотика\n>>> ");
            string mod = Console.ReadLine();
            Console.Write("Цена фотика\n>>> ");
            double price = Convert.ToInt32(Console.ReadLine());

            Camera example1 = new Camera();
            example1.Show();

            Camera example = new Camera(m, mod, price);
            example.Show();
            
            example.Price = -1700;
            Console.WriteLine($"Марка фотика: {example.Marka}\nМодель: {example.Model_name}\nЦена: {example.Price}");

            example.Price = 1000;
            Console.WriteLine($"\nМарка фотика: {example.Marka}\nМодель: {example.Model_name}\nЦена: {example.Price}");
            
        }
    }
}
