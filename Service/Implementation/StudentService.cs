using Online_Books.Model.Entities;
using Online_Bookshop.Model.Entities;
using Online_Books.Repository.Implementation;
using Online_Books.Service.Interface;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Service.Implementation
{
    public class StudentService : IStudentService
    {
        UserRepository _userRepository = new UserRepository();
        StudentRepository _studentRepository = new StudentRepository();
        public Student Create(string firstName, string lastName, string email, string password, Gender gender)
        {
          var user  = new User()
          {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                Gender = gender,
          };
          var use = _userRepository.Create(user);
          Student student = new Student()
          {
            UserEmail = email,
            
          };
          var studen = _studentRepository.Create(student);
          return student;

        }

        public bool Delete(string matricNumber)
        {
            throw new NotImplementedException();
        }

        public Student Get(string matricNumber)
        {
            var student = _studentRepository.Get(matricNumber);
            if (student != null)
            {
                return student;
            }
            return null;
        }

        public List<Student> GetAll()
        {
           var student = _studentRepository.GetAll();
           if (student != null)
           {
             return student;
           }
           return null;
        }
         public bool Check(string MatricNumber)
        {
            var b = _studentRepository.Get(MatricNumber);
            if (b.MatricNumber == MatricNumber)
            {
                return true;
            }
            return false;

        }
    }
}