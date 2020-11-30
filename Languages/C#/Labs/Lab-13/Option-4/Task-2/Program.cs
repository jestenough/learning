using System;

namespace Task_2
{
    /*
    Описать интерфейс IGetSalary, содержащий свойства «ФИО», «оклад» и метод «вычислить зарплату».
    Описать 2 класса: 
        - рабочий
        - инженер. 
    Унаследовать их от интерфейса.
    
    Зарплату рабочего рассчитывать оклад+10% оклада  (премия). 
    Зарплату инженера рассчитывать оклад*коэффициент+50% оклада  (премия).
    В основной программе описать статический метод, формирующий расчетный лист (строку) 
    для любого объекта, имеющего зарплату (Иванов И. И., к выдаче 567,58 руб.). 
    Вывести данные для объекта каждого реализованного класса.
    */

    interface IGetSalary
    {
        string full_name { get; }
        float oklad { get; }
        double Salary();
    }

    class Employee : IGetSalary
    {
        public string full_name { get; }
        public float oklad { get; }
        public double salary { get; set;}
        public Employee(string _full_name, float _oklad)
        {
            full_name = _full_name;
            oklad = _oklad;        
        }
        public double Salary()
        {
            return oklad + 0.1 * oklad;
        }    
    }

    class Engineer : IGetSalary
    {
        public string full_name { get; }
        public float oklad { get; }
        public Engineer(string _full_name, float _oklad)
        {
            full_name = _full_name;
            oklad = _oklad;        
        }
        public double Salary()
        {
            Random rnd = new Random();
            int koef = rnd.Next(1,10);
            return oklad * koef + 0.5 * oklad;
        }  
    }

    class Program
    {
        static void Show(IGetSalary test)
        {
            Console.WriteLine($"{test.full_name}, к выдаче {test.Salary()}");
        }

        static void Main(string[] args)
        {
            Employee ex = new Employee("Дмитриев В.С.", 2000);
            Engineer ex1 = new Engineer("Гончаров. В.О.", 2000);
            
            Show(ex);
            Show(ex1);
        }
    }
}
