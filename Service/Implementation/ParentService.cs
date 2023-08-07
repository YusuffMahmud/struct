using Online_Books.Repository.Implementation;
using Online_Books.Repository.Interface;
using Online_Books.Service.Interface;
using Online_Bookshop.Model.Entities;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Service.Implementation
{
    public class ParentService : IParentService
    {
        UserRepository _userRepository = new UserRepository();
        public static IParentRepository _parentRepository = new ParentRepository();

        public Parent Create(string firstName, string lastName, string email, string phoneNumber, string password, List<string> studentMatricNumber, Gender gender)
        {
           var parent = Check(email);
           if(parent == true)
           {
             Console.WriteLine("Email already exists");
             return null;
           }
           else
           {
            var user = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                PhoneNumber = phoneNumber,
                Gender = gender,
            };
            var usee = _userRepository.Create(user);
            Parent parent1 = new Parent()
            {
                Name = firstName,
                UserEmail = email,
                PhoneNumber = phoneNumber,
            };
            var admi = _parentRepository.Create(parent1);
            return parent1;

           }
     
        }

        public bool Delete(string email)
        {
            throw new NotImplementedException();
        }

        public List<Parent> GetAll()
        {
             var parents = _parentRepository.GetAll();
           
            return parents;
        }
         public bool Check(string email)
        {
            var b = _userRepository.GetBy(email);
            if (b.Email == email)
            {
                return true;
            }
            return false;

        }
    }
}