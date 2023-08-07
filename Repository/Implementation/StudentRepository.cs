using MySqlConnector;
using Online_Books.Data;
using Online_Books.Model.Entities;
using Online_Books.Repository.Interface;

namespace Online_Books.Repository.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        public static DbContext _context = new DbContext();
        public StudentRepository()
        {
            _context.Connection();
        }
        public string Create(Student student)
        {
           using (var con = _context.Connection())
           {
            con.Open();
            var command = new MySqlCommand($"insert into Student (Id,UserEmail,MatricNumber,IsDeleted) values ('{student.Id}','{student.UserEmail}','{student.MatricNumber}','{student.IsDeleted}')",con);
            var row = command.ExecuteNonQuery();
            if(row != -1)
            {
                return "Student created successful";
            }
            else
            {
                return "Student not created!!!";
            }
           }
        }

        public void Delete(string MatricNumber)
        {
            using(var con = _context.Connection())
            {
                try
                {
                    con.Open();
                var command = new MySqlCommand($"Delete from student where matricNumber = {MatricNumber}",con);
                var row = command.ExecuteNonQuery();
                Student student = new Student();
                
                  
                }
            
                catch (Exception ex)
                {
                    
                   Console.WriteLine("Error" + ex.Message);
                }
            
            }
        }

        public Student Get(string MatricNumber)
        {
            using (var con = _context.Connection())
            {
                con.Open();
                var command = new MySqlCommand($"select * from student where matricNumber = {MatricNumber}",con);
                command.Parameters.AddWithValue("MatricNumber",MatricNumber);
                var row = command.ExecuteReader();
                Student student = new Student();
                while (row.Read())
                {
                    student.Id = Convert.ToString(row[0]);
                    student.UserEmail = Convert.ToString(row[1]);
                    student.MatricNumber = Convert.ToString(row[2]);
                    student.IsDeleted = Convert.ToBoolean(row[3]);
                }
                return student; 
            }
        }

        public List<Student> GetAll()
        {
            try
            {
                using (var con = _context.Connection())
                {
                    con.Open();
                    var command = new MySqlCommand($"select * from Student",con);
                    var row = command.ExecuteReader();
                    List<Student> students = new List<Student>();
                    while (row.Read())
                    {
                        Student student = new Student();
                        student.Id = Convert.ToString(row[0]);  
                        student.UserEmail = Convert.ToString(row[1]);
                        student.MatricNumber = Convert.ToString(row[2]);
                        student.IsDeleted = Convert.ToBoolean(row[3]);
                        students.Add(student);
                    }
                    return students;
                }
            }
            catch (System.Exception)
            {
                 
                return null;
            }
        }

        
    }
}