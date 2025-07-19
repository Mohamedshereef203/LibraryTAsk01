namespace LibraryTAsk01
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISPN;
        public bool Avilabilty;

        public Book(string title, string author, string iSPN, bool avilabilty = true)
        {
            this.Title = title;
            this.Author = author;
            this.ISPN = iSPN;
            this.Avilabilty = avilabilty;
        }
    }


    public class Library
    {
        public List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"THis Book {book} Have Been Added");
        }

        public List<Book> GetBooks()
        {
            if (Books.Count == 0)
            {
                return new List<Book>();
            }
            return Books;
        }

        public bool BorrowBook(string Title)
        {
            foreach (Book book in Books)
            {
                if (book.Title == Title)
                {
                    book.Avilabilty = false;
                    return true;
                }
            }
            return false;
        }

        public bool ReturnBook(string Title)
        {
            foreach (Book book in Books)
            {
                if (book.Title == Title)
                {
                    book.Avilabilty = true;
                    return true;
                }
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", true));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", true));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935", true));

            Console.WriteLine("=============================");

            Console.WriteLine("The LIst of the Books that have been added\n\n");

            foreach (Book book in library.GetBooks())
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Auther: {book.Author}");
                Console.WriteLine($"ISPN: {book.ISPN}");
                Console.WriteLine($"Avilabilty: {book.Avilabilty}");

                Console.WriteLine("=============================");
            }
            if (library.BorrowBook("1984"))
            {
                Console.WriteLine("You Have Borrowed The Book -1984-");
            }
            else
            {
                Console.WriteLine("The Book -1984- Is Not Available For Borrowing");
            }

            if (library.ReturnBook("1984"))
            {
                Console.WriteLine("The Book (-1984-) have Been returned");
            }
            else
            {
                Console.WriteLine("(-1984- Not Available right now)");
            }



        }

    }
}



