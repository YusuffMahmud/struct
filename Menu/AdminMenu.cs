using Online_Books.Service.Implementation;
using Online_Books.Service.Interface;

namespace Online_Books.Menu
{
    public class AdminMenu
    {
        public void AdminMain()
        {
            Console.WriteLine($"Press 1 to add book\n Press 2 to view all student\nPress 3 to delete a student\nPress 4 to Log out ");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                AddBook();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.AdminMain();
            }
            else if(option == 2)
            {
                GetAll();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.AdminMain();
            }
            else if (option == 3)
            {
                Delete();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.AdminMain();
            }
            else if (option == 4)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
            }
            else
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Beep();
              Console.WriteLine("Wrong input");
              Console.ResetColor();
              AdminMenu adminMenu = new AdminMenu();
              adminMenu.AdminMain();
            }
        }
        public void AddBook()
        {
            IBookService _bookService = new BookService();


            Console.WriteLine("Enter the title of the book :");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the price of the book :");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the book author of the book :");
            string bookAuthor = Console.ReadLine();

            Console.WriteLine("Enter the level of the book");
            string level = Console.ReadLine();

            var addbook = _bookService.Add(title,price,bookAuthor,level);
            if (addbook == null)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unsucessful!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have sucessfully add a book");
                Console.ResetColor();

            }

        }
        public void GetAll()
        {
            IStudentService _studentService = new StudentService();
            var viewAll = _studentService.GetAll();
            if (viewAll == null)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Stident not found");
                Console.ResetColor();

            }
            foreach (var item in viewAll)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"User email : {item.UserEmail} \n Matric number : {item.MatricNumber}");
                Console.ResetColor();
            }
        }

        public void Delete()
        {
            IStudentService _studentService = new StudentService();

            Console.WriteLine("Enterthe student matric number: ");
            var num = Console.ReadLine();

            var matric = _studentService.Delete(num);
            if (matric == false)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student not found");
                Console.ResetColor();
            }
            Console.WriteLine("Student sucessfully removed");
        }
    }
}