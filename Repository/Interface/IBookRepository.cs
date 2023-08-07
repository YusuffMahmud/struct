using Online_Bookshop.Model.Entities;

namespace Online_Books.Repository.Interface
{
    public interface IBookRepository
    {
        string Create(Book book);
        Book Get(string Title);
        List<Book> GetBookByLevel(string Level);
        List<Book> GetAll();
       
    }
}