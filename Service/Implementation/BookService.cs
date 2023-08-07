using Online_Books.Repository.Implementation;
using Online_Books.Service.Interface;
using Online_Bookshop.Model.Entities;


namespace Online_Books.Service.Implementation
{
    public class BookService : IBookService
    {
        BookRepository _bookRepository = new BookRepository();
        public Book Add(string title, double price, string bookAuthor, string level)
        {
            var bookExist = checkBook(title);
            if (bookExist == false)
            {
                Console.WriteLine("Book not exists");
                return null;
            }
            else
            {
                var book = new Book()
                {
                    Title = title,
                    BookAuthor = bookAuthor,
                    Price = price,
                    Level = level,
                };
                var booked = _bookRepository.Create(book);
                return book;
            }
        }

        public bool Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public Book Get(string title)
        {
           var book = _bookRepository.Get(title);
           if (book != null)
           {
            return book;
           }
           return null;
        }

        public List<Book> GetAll()
        {
          var book = _bookRepository.GetAll();
         if (book.Count == 0)
         {
            return book;
         }
         return null;
        }

        public List<Book> GetBookByLevel(string level)
        {
           var textbook = _bookRepository.GetBookByLevel(level);
           if (textbook != null)
           {
             return textbook;
           }
           return null;
        }
        public bool checkBook(string title)
        {
            var check = _bookRepository.Get(title);
            if (check.Title == title)
            {
                return true;
            }
            return false;
        }
    }
}