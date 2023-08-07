using MySqlConnector;
using Online_Books.Data;
using Online_Books.Repository.Interface;
using Online_Bookshop.Model.Entities;

namespace Online_Books.Repository.Implementation
{
    public class ParentRepository : IParentRepository
    {
        public static DbContext _context = new DbContext();
        public ParentRepository()
        {
            _context.Connection();
        }
        public string Create(Parent parent)
        {
            using (var con = _context.Connection())
            {
                var command = new MySqlCommand($"insert into Parent (Id,Name UserEmail,PhoneNumber,IsDeleted)values ('{parent.Id}','{parent.Name}','{parent.UserEmail}','{parent.PhoneNumber}','{parent.IsDeleted}')",con);
                var roww = command.ExecuteNonQuery();
                if(roww != -1)
                {
                    return "Parent created successfully ";
                }
                else
                {
                    return "Parent not created sucessfully";
                }
            }
        }

        public List<Parent> GetAll()
        {
             try
               {
                    using (var con = _context.Connection())
                    {
                         con.Open();
                         var command = new MySqlCommand($"select * from Parent", con);
                         var row = command.ExecuteReader();
                         List<Parent> parents = new List<Parent>();
                         while (row.Read())
                         {

                              Parent parent = new Parent();

                              parent.Id = Convert.ToString(row[0]);
                              parent.Name = Convert.ToString(row[1]);
                              parent.UserEmail = Convert.ToString(row[2]);
                              parent.PhoneNumber = Convert.ToString(row[3]);
                              parent.IsDeleted = Convert.ToBoolean(Convert.ToString(row[4]));
                              

                              parents.Add(parent);

                         }
                         return parents;
                    }
               }
               catch (System.Exception)
               {

                    return null;
               }
        }

        public string Update(string Name,string UserEmail,string PhoneNumber,Parent parent)
        {
           using (var con = _context.Connection())
           {
             con.Open();
             var commandText = new MySqlCommand($"Update Parent set Name = @Name where UserEmail = @UserEmail AND PhoneNumber = @phoneNumber",con);
             commandText.Parameters.AddWithValue("@Name",parent.Name);
             commandText.Parameters.AddWithValue("@UserEmail",parent.UserEmail);
             commandText.Parameters.AddWithValue("@PhoneNumber",parent.PhoneNumber);
             var row = commandText.ExecuteNonQuery();
             if (row != -1)
             {
                return "Update Successful!!!";
             }
             else
             {
                return "Update not successful";
             }
           }
        }

        
    }
}