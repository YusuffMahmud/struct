using Online_Bookshop.Model.Entities;

namespace Online_Books.Repository.Interface
{
    public interface IAdminRepository
    {
        string Create (Admin admin);
        Admin Get(string email);
        Admin Get(int id);
        List<Admin> GetAll();
        
    }
}