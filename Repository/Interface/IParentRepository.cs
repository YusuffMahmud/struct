using Online_Bookshop.Model.Entities;

namespace Online_Books.Repository.Interface
{
    public interface IParentRepository
    {
        string Create(Parent parent);
        List<Parent> GetAll();
        string Update(string Name,string UserEmail,string PhoneNumber,Parent parent);
    }
}