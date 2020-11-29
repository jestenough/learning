using System;

namespace Task_3
{
    /*
    Добавить в иерархию третий класс. 
    Определить его конструктор, свойства, метод Show(). 
    Продемонстрировать работу с объектом
    */
    
    class Book
    {
        protected string name;
        protected string author;
        protected int pages;

        public Book(string _name, string _author, int _pages)
        {
            name = _name;
            author = _author;
            pages = _pages;
        }

        public string Name
        {
            get { return name; }
        }

        public string Author
        {
            get { return author; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public virtual void Show()
        {
            Console.WriteLine("Название книги: " + name);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Количество страниц: " + pages);
        }
    }

    class TextBook : Book
    {
        protected string pub_house;
        protected int pub_date;

        public TextBook(string _name, string _author, int _pages, string _pub_house, int _pub_date)
            : base(_name, _author, _pages)
        {
            pub_house = _pub_house;
            pub_date = _pub_date;
        }

        public string Pub_house
        {
            get { return pub_house; }
        }

        public int Pub_date
        {
            get { return pub_date; }
        }

        public override void Show()
        {
            Console.WriteLine("Название книги: " + name);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Количество страниц: " + pages);
            Console.WriteLine("Издательство: " + pub_house);
            Console.WriteLine("Год издания: " + pub_date);
        }
    }

    class TextBook_for_student : TextBook
    {
        protected string pasxalka;

        public TextBook_for_student(string _name, string _author, int _pages, string _pub_house, int _pub_date, string _pasxalka)
            : base(_name, _author, _pages, _pub_house, _pub_date)
        {
            pasxalka = _pasxalka;
        }

        public override void Show()
        {
            Console.WriteLine("Название книги: " + name);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Количество страниц: " + pages);
            Console.WriteLine("Издательство: " + pub_house);
            Console.WriteLine("Год издания: " + pub_date);
            Console.WriteLine("Пасхалка: " + pasxalka);
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book ex = new Book("Тест1", "Автор1", 169);
            ex.Show();

            Console.WriteLine();

            TextBook ex2 = new TextBook("Тест2", "Автор2", 1337, "Издательство1", 2012);
            ex2.Show();

            Console.WriteLine();

            Book ex3 = new TextBook("Тест3", "Автор3", 1489, "Издательство2", 1945);
            ex3.Show();

            Console.WriteLine();

            Book ex4 = new TextBook_for_student("Тест4", "Автор4", 1231, "Издательство3", 2132, "Пасхалка");
            ex4.Show();
        }
    }
}
