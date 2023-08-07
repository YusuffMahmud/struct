using MySqlConnector;
using Online_Books.Data;
using Online_Books.Repository.Interface;
using Online_Bookshop.Model.Entities;

namespace Online_Books.Repository.Implementation
{
    public class BookRepository : IBookRepository
    {
        public static DbContext _context = new DbContext();
        public BookRepository()
        {
            _context.Connection();
        }
        public string Create(Book book)
        {
           using (var con = _context.Connection())
           {
             con.Open();
             var command = new MySqlCommand($"insert into book (Id,Title,BookAuthor,price,level,IsDeleted) values ('{book.Id}','{book.BookAuthor}','{book.Price},'{book.Level}','{book.IsDeleted}')",con);
             var row = command.ExecuteNonQuery();
             if (row != -1)
             {
                return "Book created sucessfully";
             }
             else
             {
                return "Book not created";
             }
           }
        }

        public Book Get(string title)
        {
           using (var con = _context.Connection())
           {
            con.Open();
            var command = new MySqlCommand ($"select * from Book where Title = '{title}'",con);
            command.Parameters.AddWithValue("Title",title);
            var row = command.ExecuteReader();
            Book book = new Book();
            while (row.Read())
            {
                book.Id = Convert.ToString(row[0]);
                book.Title = Convert.ToString(row[1]);
                book.BookAuthor = Convert.ToString(row[2]);
                book.Price = Convert.ToDouble(row[3]);
                book.Level = Convert.ToString(row[4]);
                book.IsDeleted = Convert.ToBoolean(Convert.ToString(row[5]));
                
            }
            return book;
           }
        }

        public List<Book> GetBookByLevel(string level)
        {
           using (var con = _context.Connection())
           {
            con.Open();
            var command = new MySqlCommand ($"select * from Book where Level = '{level}'",con);
            command.Parameters.AddWithValue("Level",level);
            var row = command.ExecuteReader();
             List<Book> books = new List<Book>();
            Book book = new Book();
            while (row.Read())
            {
                book.Id = Convert.ToString(row[0]);
                book.Title = Convert.ToString(row[1]);
                book.BookAuthor = Convert.ToString(row[2]);
                book.Price = Convert.ToDouble(row[3]);
                book.Level = Convert.ToString(row[4]);
                book.IsDeleted = Convert.ToBoolean(Convert.ToString(row[5]));
                
            }
            return books;
           }
        }

        public List<Book> GetAll()
        {
            try
            {
                using (var con = _context.Connection())
                {
                    con.Open();
                    var command = new MySqlCommand($"select * from book",con);
                    var row = command.ExecuteReader();
                    List<Book> books = new List<Book>();
                    while (row.Read())
                    {
                         Book book = new Book();
                         book.Id = Convert.ToString(row[0]);
                         book.BookAuthor = Convert.ToString(row[1]);
                         book.Price = Convert.ToDouble(row[3]);
                         book.Level = Convert.ToString(row[4]);
                         book.IsDeleted = Convert.ToBoolean(row[5]);
                         books.Add(book);
                         
                    }
                    return books;
                }
            }
            catch (System.Exception)
            {
                
                return null;
            }
        }

       
       
    }
}