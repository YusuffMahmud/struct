using Online_Bookshop.Model.Entities;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Service.Interface
{
    public interface IParentService
    {
        List<Parent> GetAll();
         bool Delete(string email);
         Parent Create(string firstName,string lastName,string email,string phoneNumber,string password,List<string >studentMatricNumber,Gender gender);
    }
}