

using MySqlConnector;
using Online_Books.Data;
using Online_Books.Repository.Interface;
using Online_Bookshop.Model.Entities;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Repository.Implementation
{
    public class UserRepository : IUserREpository
    {
       public static DbContext _context = new DbContext();
       public UserRepository()
       {
         _context.Connection();
       }
       public User Create(User user)
       {
         using (var con = _context.Connection())
         {
           con.Open();
            var command = new MySqlCommand($"insert into User (Id, FirstName,LastName,Email,Password,PhoneNumber,Gender,IsDeleted) values ('{user.Id}','{user.FirstName}','{user.LastName}','{user.Email}','{user.Password}','{user.PhoneNumber}',{Convert.ToInt32(user.Gender)},{user.IsDeleted})",  con);
            var row = command.ExecuteNonQuery();
            User users  = new User();
           
          }
          return user;
        }
        public User Login(string email,string password)
        {
          using (var con = _context.Connection())
          {
            con.Open();
  
            var command = new MySqlCommand($"select * from user where Email = '{email}' and Password = '{password}';",con);
            command.Parameters.AddWithValue("@Email",email);
            command.Parameters.AddWithValue("Password",password);
            var row = command.ExecuteReader();
            User user = new User();
            while (row.Read())
            {
              user.Id = Convert.ToString(row[0]);
              user.FirstName = Convert.ToString(row[1]);
              user.LastName = Convert.ToString(row[2]);
              user.Email = Convert.ToString(row[3]);
              user.Password = Convert.ToString(row[4]);
              user.PhoneNumber = Convert.ToString(row[5]);
              user.Gender = (Gender)Enum.Parse(typeof(Gender), row[6].ToString());
              

            }
            return user;
          }
        }

        public List<User> GetAll()
        {
          try
          {
            using (var con = _context.Connection())
            {
              con.Open();
              var command = new MySqlCommand($"select * from user");
              var row = command.ExecuteReader();
              List<User> users = new List<User>();
              while(row.Read())
              {
                User user = new User();
 
 
                user.Id = Convert.ToString(row[0]);
                user.FirstName = Convert.ToString(row[1]);
                user.Email = Convert.ToString(row[2]);
                user.Password = Convert.ToString(row[3]);
                user.PhoneNumber = Convert.ToString(row[4]);
                user.IsDeleted = Convert.ToBoolean(Convert.ToString(row[6]));
                users.Add(user);
              }
              return users;                                                                                                                                                                                                                                                                                                     
            }
          }
          catch (System.Exception)
          {
            return null;
          }
        }

        

        public User GetBy(string email)
        {
           using (var con = _context.Connection())
            {
                con.Open();
                var commandText = new MySqlCommand($"select * from user where Email = @email;", con);
                commandText.Parameters.AddWithValue("@email", email);
                var row = commandText.ExecuteReader();
                User user = new User();
                while (row.Read())
                {
                    user.Id = Convert.ToString(row[0]);
                    user.FirstName = Convert.ToString(row[1]);
                    user.LastName = Convert.ToString(row[2]);
                    user.Email = Convert.ToString(row[3]);
                    user.Password = Convert.ToString(row[4]);
                    user.PhoneNumber = Convert.ToString(row[5]);
                    user.Gender = (Gender)Enum.Parse(typeof(Gender), row[6].ToString());
                    user.IsDeleted = Convert.ToBoolean(row[7]);
                }
                return user;

            }
        }

       
    }

}








