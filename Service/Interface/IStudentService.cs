using Online_Books.Model.Entities;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Service.Interface
{
    public interface IStudentService
    {
       Student Get(string matricNumber);
        List<Student> GetAll();
        bool Delete(string matricNumber);
        Student Create(string firstName, string lastName, string email,string password,Gender gender);
    }
}