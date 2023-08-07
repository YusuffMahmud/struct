using Online_Bookshop.Model.Entities;

namespace Online_Books.Repository.Interface
{
    public interface IUserREpository
    {
        User Create(User user);
        User GetBy(string email);
        User Login(string email, string password);
        List<User> GetAll();

    }
}