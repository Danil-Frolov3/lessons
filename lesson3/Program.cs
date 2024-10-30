
using System.Xml.Linq;

namespace lesson3
{
    class Program
    {
        class Book
        {
            private string _title;

            private string _author;

            private int _pages;

            public string Title
            {
                get { return _title; }
            }

            public Book(string Title, string Auther, int Pages)
            {
                _title = Title;
                _author = Auther;
                _pages = Pages;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Название - {_title}\nАвтор - {_author}\nКол-во страниц - {_pages}\n");
            }
        }
        class Library
        {
            List<Book> books = new List<Book>();
            
            public void AddBook(Book book)
            {
                books.Add(book);
            }

            public void ShowBooks()
            {
                for (int i = 0; i < books.Count; i++) 
                {
                    Console.WriteLine($"{i+1})");
                    books[i].GetInfo();
                }
            }

            public void FindBook(string title)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Title == title)
                    {
                        books[i].GetInfo();
                    }
                }
            }

        }


    static void Main(string[] args)
        {
            Book book1 = new Book("1984", "Джордж Оруэлл", 328);
            Book book2 = new Book("«Война и мир", "Лев Толстой,", 1225);
            Book book3 = new Book("Мастер и Маргарита", "Михаил Булгаков", 384);

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.ShowBooks();

            library.FindBook("1984");

        }





    }





}
