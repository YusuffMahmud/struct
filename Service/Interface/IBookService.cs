using Online_Bookshop.Model.Entities;

namespace Online_Books.Service.Interface
{
    public interface IBookService
    {
         Book Get(string title);
         bool Delete(Book book);
         Book Add(string title, double price, string bookAuthor,string level);
         List<Book> GetAll();
        List<Book> GetBookByLevel(string level);
     
    }
}