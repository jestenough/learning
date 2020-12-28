using System;

namespace Task_1
{
    /*
    Описать интерфейс «Жилье» (метод «Цена»).

    Унаследовать от него классы 
    -   «Квартира_на_продажу» (поле «Цена_метра», «Метраж») 
    -   «Квартира_в_аренду» (поля «Срок_аренды», «Цена_за_месяц»).

    Описать класс, содержащий методы:
        - для вывода на экран информации об объекте любого из классов жилья. 
            Информация должна содержать тип жилья (аренда или продажа) и цену.
        - для поиска в массиве объектов подходящих по цене вариантов жилья. 
    */

    interface IHousing
    {
        double Price();
    }

    class Apartment_for_sale : IHousing
    {
        public double meter_price { get; }
        double square_footage { get; }

        public Apartment_for_sale(double _meter_price, double _square_footage)
        {
            meter_price = _meter_price;
            square_footage = _square_footage;
        }

        public double Price()
        {
            return meter_price * square_footage;
        }
    }

    class Apartment_for_rent : IHousing 
    {
        double term_lease { get; }
        double month_price { get; }

        public Apartment_for_rent(double _term_lease, double _month_price)
        {
            term_lease = _term_lease;
            month_price = _month_price;
        }

        public double Price()
        {
            return term_lease * month_price;
        }
    }

    class Program
    {
        static void Show <T> (T _obj) where T : IHousing
        {
            if (_obj is Apartment_for_sale)
            {
                Console.WriteLine("Тип жилья: Продажа");
                Console.WriteLine($"Цена: {_obj.Price()}\n");
            }
            else
            {
                Console.WriteLine("Тип жилья: Аренда");
                Console.WriteLine($"Цена: {_obj.Price()}\n");
            }
        }

        static void Search <T> (T [] _obj) where T : IHousing
        {
            Console.Write("Подходящая цена: ");
            int price = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < _obj.Length; i++)
            {
                if (_obj[i].Price() <= price)
                {
                    Console.WriteLine($"\nНомер жилья: {i+1}");
                    Show(_obj[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            IHousing[] arr_housing = new IHousing[3];
            for (int i = 0; i < 3; i++)
                if (rnd.Next(1, 10) % 2 == 0)
                    arr_housing[i] = new Apartment_for_rent(rnd.Next(1, 12), rnd.Next(500, 1000));
                else
                    arr_housing[i] = new Apartment_for_sale(rnd.Next(100, 500), rnd.Next(5, 30));
            
            for (int i = 0; i < 3; i++)
                Show(arr_housing[i]);

            Search(arr_housing);
        }
    }
}
