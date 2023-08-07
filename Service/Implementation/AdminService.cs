using Online_Books.Repository.Implementation;
using Online_Books.Repository.Interface;
using Online_Books.Service.Interface;
using Online_Bookshop.Model.Entities;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Service.Implementation
{
    public class AdminService : IAdminService
    {
        UserRepository _userRepository = new UserRepository();
        public static IAdminRepository _adminRepository = new AdminRepository();
        public Admin Register(string firstName, string lastName, string email, string password, string phoneNumber, Gender gender)
        {
           var admin = Check(email);
           if(admin == true)
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
               var use = _userRepository.Create(user);
               Admin admins = new Admin()
               {
                UserEmail = email,
                AdminId = use.Id,
               };
               var admi = _adminRepository.Create(admins);
               return admins;

           }
  
            
        }


        public Admin Get(string userEmail)
        {
           var admins = _adminRepository.Get(userEmail);
           if (admins != null)
           {
            return admins;
           }
           return null;
        }

        public List<Admin> GetAll()
        {
            var admins = _adminRepository.GetAll();
           
            return admins;
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