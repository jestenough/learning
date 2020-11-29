using System;

namespace Task_1
{
    /*
    Определить иерархию классов (в соответствии с вариантом). 
    Описать 
        - базовый класс
        - класс наследник. 
    Реализовать в них функции для вывода содержимого полей класса
        - Show_base()
        - Show_new().
    Определить в каждом классе все необходимые свойства.
    Определить в каждом классе конструктор с параметрами. 
    Инициализировать конструктор дочернего класса конструктором базового. 
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

        public void Show_base()
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

        public void Show_new()
        {
            Console.WriteLine("Название книги: " + name);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Количество страниц: " + pages);
            Console.WriteLine("Издательство: " + pub_house);
            Console.WriteLine("Год издания: " + pub_date);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            TextBook ex = new TextBook("Тест1", "Автор1", 1337, "Издательство1", 2000);
            ex.Show_base();
            Console.WriteLine();
            ex.Show_new();
        }
    }
}
