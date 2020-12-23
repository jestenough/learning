using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task_1
{
    /*
    Описать классы «Гостиница» и «Хостел», 
    наследуемые от одного предка (выберите, абстрактный класс или интерфейс использовать).

    Определить в обоих классах необходимые поля (не обязательно), 
    свойства, конструкторы и 
    метод расчета оплаты 
        для хостела – посуточная фиксированная, 
        для гостиницы – в зависимости от класса номера).

    1) Создать массив объектов класса Гостиница. Заполнить. 
    Записать в файл посредствам сериализации. 
    Провести десериализацию, продемонстрировать десериализованный массив на экране.

    2) Создать массив объектов, содержащий объекты обоих классов. 
    Провести сериализацию объектов каждого класса в отдельные файлы. 
    Путём десериализации создать 2 новых массива: только из гостиниц и только из хостелов. 
    Продемонстрировать каждый десериализованный массив на экране. 
    */

    interface IGetSalary
    {
        string name { get; }
        byte stars { get; }
        double Salary();
        void Show();
    }

    // class Hostel : IGetSalary
    // {
    //     public string name { get; }
    //     public byte stars { get; }
    //     public double salary { get; set;}

    //     public Hostel (string _name, byte _stars)
    //     {
    //         name = _name;
    //         stars = _stars;        
    //     }
    //     public double Salary()
    //     {
    //         return 2000 / 30;
    //     }   
        
    //     public void Show()
    //     {
    //         Console.WriteLine($"Наименование: {name}\nКоличество звёзд: {stars}\nОплата: {salary}");
    //     } 
    // }

    [Serializable]
    class Hotel : IGetSalary
    {
        public string name { get; }
        public byte stars { get; }
        public double salary { get; set;}

        public Hotel(string _name, byte _stars)
        {
            name = _name;
            stars = _stars;
            salary = Salary();
        }

        public double Salary()
        {
            return 2000 * stars;
        }  

        public void Show()
        {
            Console.WriteLine($"\nНаименование: {name}\nКоличество звёзд: {stars}\nОплата: {salary} BYN");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int N = Convert.ToUInt16(Console.ReadLine());

            Hotel[] hotels = new Hotel[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("\nВведите название: ");
                string name = Console.ReadLine();
                Console.Write("Введите кол-во звезд: ");
                byte stars = Convert.ToByte(Console.ReadLine());
                hotels[i] = new Hotel(name, stars);
            }

            // foreach (Hotel i in hotels)
            //     i.Show();

            
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("hostels.dat", FileMode.Create);
            formatter.Serialize(fs, hotels);
            Console.WriteLine("Массив сериализован");
            Console.ReadKey();
            fs.Close();
            
            fs = new FileStream("hostels.dat", FileMode.Open);
            Hotel[] hotel_des = (Hotel[])formatter.Deserialize(fs);
            Console.Clear();
            foreach (Hotel hotel in hotel_des)
            {
                hotel.Show();   
            }
        }
    }
}
