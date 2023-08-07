using Online_Books.Model.Entities;

namespace Online_Books.Repository.Interface
{
    public interface IStudentRepository
    {
        string Create(Student student);
        Student Get(string MatricNumber);
        void Delete (string MatricNumber);
        List<Student> GetAll();
        
    }
}