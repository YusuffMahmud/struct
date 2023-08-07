using Online_Bookshop.Model.Entities;

namespace Online_Books.Service.Interface
{
    public interface IUserService
    {
        User Get(string email);
        List<User> GetAll();
        bool Delete(string email);
        public User Login(string email, string password);
    }
}