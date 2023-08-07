using MySqlConnector;

namespace Online_Books.Data
{
    public class DbContext
    {
        public string connectionString  = "Server = localhost; user = root; database =onlineBooks ; password = Kolawole123!; Allow User Variables = true";
        public MySqlConnection Connection()
        {
            return new MySqlConnection(connectionString);
        }
        public void CreateUserTable()
        {
            try
            {
                 using var con = Connection();
                con.Open();
                var command = new MySqlCommand("Create table if not exists User(Id varchar(20) primary key, FirstName varchar(20), LastName varchar(20), Email varchar(20),Password varchar(20), PhoneNumber varchar(20),Gender tinyint,IsDeleted varchar(20))", con);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                 {
                   Console.WriteLine("User table created sucessful");
                 }
                else
                 {
                   Console.WriteLine("User table not sucessful created");
                 }
                  con.Close();
            }
            catch (System.Exception e)
            {
                
                Console.WriteLine(e.Message);
            }
           
        }

        public void CreateStudentTable()
        {
            try
            {
                using (var con = Connection())
            {
                con.Open();
                var command = new MySqlCommand("Create table if not exists Student(Id varchar(12),UserEmail varchar(20),MatricNumber varchar(20),IsDeleted varchar(20))",con);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    Console.WriteLine("Student table created sucessful");
                }
                else
                {
                    Console.WriteLine("Student table not sucessful created");
                }
            }
            }
            catch (System.Exception e)
            {
                
                Console.WriteLine(e.Message);
            }
           
        }
    
        public void CreateBookTable()
        {
            using (var con = Connection())
            {
                con.Open();
                var command = new MySqlCommand("Create table if not exists Book(Id varchar(10),title varchar(20),BookAuthor varchar(20),price decimal,level varchar(20),IsDeleted varchar(20))",con);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    Console.WriteLine("Book table created sucessful");
                }
                else
                {
                    Console.WriteLine("Book table not sucessful created");
                }
            }
        }
        public void CreateAdminTable()
        {
             using (var con = Connection())
             {
                con.Open();
                var command = new MySqlCommand("Create table if not exists Admin(Id varchar(10),UserEmail varchar(20),AdminTagNumber varchar(20),IsDeleted varchar(20))",con);
                var row = command.ExecuteNonQuery();
                if (row != -1)
                {
                    Console.WriteLine("Admin created sucessful");
                }
                else
                {
                    Console.WriteLine("Admin table not sucessful created");
                }
                
                
                
             }
        }
        public void CreateParentTable()
        {
            using (var con = Connection())
            {
                con.Open();
                var command = new MySqlCommand("Create table if not exists Parent(Id varchar(10),Name varchar(20), UserEmail varchar(20), PhoneNumber varchar(20),IsDeleted varchar(20))",con);
                var row =  command.ExecuteNonQuery();
                if (row != -1)
                {
                  Console.WriteLine("Parent table created sucessful");
                }
                else
                {
                    Console.WriteLine("Parent table not sucessful created");
                }
            }
        }
    }
}