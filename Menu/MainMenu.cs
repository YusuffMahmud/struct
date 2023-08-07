using Online_Books.Service.Implementation;
using Online_Books.Service.Interface;
using Online_Bookshop.Model.Entities;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Menu
{
    public class MainMenu
    {
        public void Main()
        {
            IUserService _userService = new UserService();
            IStudentService _studentService = new StudentService();



            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------Welcome to Scholastic Book shop----------------------");
            Console.ResetColor();
            Console.WriteLine("Enter 1 to Sign in\n Enter 2 Log in ");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                SignUpAsStudent();
                Main();
            }
            else if (option == 2)
            {
                LogIn();
                Main();
            }
            else
            {
                Console.WriteLine("Invalid email or password");
                Main();
            }
        }
        public void SignUpMenu()
        {
           
            Console.WriteLine("Enter 1 to sign in as a student\n Enter 2 to sign in as a parent");
            int Signup = int.Parse(Console.ReadLine());
            if (Signup == 1)
            {
                SignUpAsStudent();
            }
            else if(Signup == 2)
            {
                
            }
        }
        public void SignUpAsStudent()
        {
            IStudentService _studentService = new StudentService();

            
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your Email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your Password");
            string password = Console.ReadLine();

           Console.WriteLine("Enter 1 for male and 2 for female");
           Gender gender = (Gender) int.Parse(Console.ReadLine());

           var student = _studentService.Create(firstName,lastName,email,password,(Gender)gender);
           if (student == null)
           {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Student not created");
               Console.Beep();
               Console.ResetColor();
           }
           else
           {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congratulation {firstName} {lastName} you have sucessfully registered as a student");
            Console.ResetColor();
           }

        }
        public User LogIn()
        {
            IUserService _userService = new UserService();


            Console.WriteLine("-----------------------------------LOGIN MENU------------------------------------------");
            Console.WriteLine("Enter your Email : ");
            var email = Console.ReadLine();

            Console.WriteLine("Enter your Password : ");
            var password = Console.ReadLine();
            
            var user = _userService.Login(email,password);
            if (user == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Invalid email or password");
                Console.ResetColor();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
            }
            return user;
           
        }

        public void LogInAsSuperAdmin()
        {
            IUserService _userService = new UserService();
            Console.WriteLine("Enter your email");
            var email = Console.ReadLine();

            Console.WriteLine("Enter your password");
            var password = Console.ReadLine();

            var user = _userService.Login(email,password);

            if (user == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Invalid email or password");
                Console.ResetColor();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
            }
        }
            public void LogInAsAnAdmin()
        {
            IUserService _userService = new UserService();
            Console.WriteLine("Enter your email");
            var email = Console.ReadLine();

            Console.WriteLine("Enter your password");
            var password = Console.ReadLine();

            var user = _userService.Login(email,password);

            if (user == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Invalid email or password");
                Console.ResetColor();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
            }
        }
         public void LogInAsAStudent()
        {
            IUserService _userService = new UserService();
            Console.WriteLine("Enter your email");
            var email = Console.ReadLine();

            Console.WriteLine("Enter your password");
            var password = Console.ReadLine();

            var user = _userService.Login(email,password);

            if (user == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Invalid email or password");
                Console.ResetColor();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
            }
        }

         public void LogInAsAParent()
        {
            IUserService _userService = new UserService();
            Console.WriteLine("Enter your email");
            var email = Console.ReadLine();

            Console.WriteLine("Enter your password");
            var password = Console.ReadLine();

            var user = _userService.Login(email,password);

            if (user == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Invalid email or password");
                Console.ResetColor();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
            }
        }
           

           
         
    }
}