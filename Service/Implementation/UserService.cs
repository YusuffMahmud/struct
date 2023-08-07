using Online_Books.Repository.Implementation;
using Online_Books.Repository.Interface;
using Online_Books.Service.Interface;
using Online_Bookshop.Model.Entities;

namespace Online_Books.Service.Implementation
{
    public class UserService : IUserService
    {
        IUserREpository _userRepository = new UserRepository();
        public bool Delete(string email)
        {
            var find = _userRepository.GetBy(email);
            if (find == null)
            {
                Console.WriteLine("not  found");
                return true;
            }
            return false;
            
        }

        public User Get(string email)
        {
           var search = _userRepository.GetBy(email);
           if (search != null)
           {
             return  search;
           }
           return null;
        }

        public List<User> GetAll()
        {
           var users = _userRepository.GetAll();
           return users;
        }

        public User Login(string email, string password)
        {
            var login = _userRepository.Login(email,password);
            if (login != null)
            {
                return login;
            }
            return null;
        }

    }
}