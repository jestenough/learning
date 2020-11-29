using System;

namespace Task_2
{

    /*
    Скопировать классы в другой проект. 
    Переопределить функции Show_base() и Show_new() как функцию Show(), 
    являющуюся перегружаемой в классе-наследнике. 
    Определить в наследнике данный метод модификатором new. 
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
    class Program
    {
        static void Main(string[] args)
        {
            Book ex = new Book("Тест1", "Автор1", 170);
            ex.Show();

            Console.WriteLine();

            TextBook ex2 = new TextBook("Тест1", "Автор1", 1337, "Издательство1", 2012);
            ex2.Show();

            Console.WriteLine();

            Book ex3 = new TextBook("Тест2", "Автор2", 1489, "Издательство2", 1945);
            ex3.Show();
        }
    }
}
