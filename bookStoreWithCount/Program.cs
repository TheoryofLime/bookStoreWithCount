using System;

namespace bookStore
{

    class Book
    {

        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;

        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public Book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public int GetTrans()
        {
            return _transactions;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        public void SetTrans()
        {
            _transactions = _transactions + 1;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            Book newBook = new Book();
            newBook.SetId(1);
            newBook.SetTitle("The Quran");
            newBook.SetAuthor("Muhammad");

            // book 2
            Book twoBook = new Book();
            Console.WriteLine("Please insert the book ID: ");
            twoBook.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please insert the book title: ");
            twoBook.SetTitle(Console.ReadLine());
            Console.WriteLine("Please insert the book author: ");
            twoBook.SetAuthor(Console.ReadLine());

            // book 3
            Book threeBook = new Book(3, "Book3", "Author3");

            // book 4
            Console.WriteLine("Please insert the book ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the book title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please insert the book author: ");
            string author = Console.ReadLine();
            Book fourBook = new Book(id, title, author);

            newBook.SetTrans();
            twoBook.SetTrans();
            threeBook.SetTrans();
            fourBook.SetTrans();

            Console.WriteLine($"Total Books: {newBook.GetTrans()}");

            displayBooks(newBook);
            displayBooks(twoBook);
            displayBooks(threeBook);
            displayBooks(fourBook);
        }

        static void displayBooks(Book booknum)
        {
            Console.WriteLine("// Book Info //");
            Console.WriteLine(booknum.GetId());
            Console.WriteLine(booknum.GetTitle());
            Console.WriteLine(booknum.GetAuthor());
        }
    }
}