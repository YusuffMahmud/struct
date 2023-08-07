using MySqlConnector;
using Online_Books.Data;
using Online_Books.Repository.Interface;
using Online_Bookshop.Model.Entities;

namespace Online_Books.Repository.Implementation
{
    public class AdminRepository : IAdminRepository
    {
        public static DbContext _context = new DbContext();
        public AdminRepository()
        {
            _context.Connection();
        }
        public string Create(Admin admin)
        {
            using (var con = _context.Connection())
            {
                con.Open();
                var command = new MySqlCommand($"insert into Admin (Id, UserEmail,AdminTagNumber,IsDeleted) values ('{admin.Id}','{admin.UserEmail}','{admin.AdminTagNumber}','{admin.IsDeleted}') " , con);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    return "Admin Created succesful!!";
                }
                else
                {
                    return "Admin not created";
                }
            }
        }

        public Admin Get(string email)
        {
            using (var con = _context.Connection())
            {
                con.Open();
                var command = new MySqlCommand($"select * from Admin where email = '{email}'",con);
                command.Parameters.AddWithValue("Email",email);
                var row = command.ExecuteReader();
                Admin admin = new Admin();
                while (row.Read())
                {
                    admin.Id = Convert.ToString(row[0]);
                    admin.UserEmail = Convert.ToString(row[1]);
                    admin.AdminTagNumber = Convert.ToString(row[2]);
                    admin.IsDeleted = Convert.ToBoolean(row[3]);
            
                }
                return admin;
            }
        }

        public Admin Get(int id)
        {
           try
           {
             using (var con = _context.Connection())
             {
                con.Open();
                var command = new MySqlCommand($"select * from admin where Id = {id}",con);
                command.Parameters.AddWithValue("id",id);
                var row = command.ExecuteReader();
                Admin admin = new Admin();
                while (row.Read())
                {
                    admin.Id = Convert.ToString(row[0]);
                    admin.AdminId= Convert.ToString(row[1]);
                    admin.UserEmail = Convert.ToString(row[2]);
                    admin.AdminTagNumber = Convert.ToString(row[3]);
                    admin.IsDeleted = Convert.ToBoolean(row[4]);
                }
                return admin;
             }
           }
           catch (System.Exception)
           {
            
               return null;
           }
        }

        public List<Admin> GetAll()
        {
            using (var con = _context.Connection())
            {
                con.Open();
                var command = new MySqlCommand($"select * from Admin",con);
                var row  = command.ExecuteReader();
                List<Admin> admins = new List<Admin>();
                while (row.Read())
                {
                   Admin admin = new Admin();
                   admin.Id = Convert.ToString(row[0]);
                   admin.UserEmail = Convert.ToString(row[1]);
                   admin.AdminTagNumber = Convert.ToString(row[2]);
                   admin.IsDeleted = Convert.ToBoolean(row[3]);


                   admins.Add(admin);
                }
                return admins;
                
            }
        }

       
    }
}