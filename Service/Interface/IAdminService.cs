using Online_Bookshop.Model.Entities;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Service.Interface
{
    public interface IAdminService
    {
         Admin Register(string firstName, string lastName, string email, string password, string phoneNumber, Gender gender);
        Admin Get(string userEmail);
        List<Admin> GetAll(); 
       
    }
}