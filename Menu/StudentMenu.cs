using Online_Books.Service.Implementation;
using Online_Books.Service.Interface;

namespace Online_Books.Menu
{
    public class StudentMenu
    {
        IStudentService _studentService = new StudentService();

        public void StudentMain()
        {
            Console.WriteLine("Press 1 to make payment\nPress 2 to view all books\n press 3 to log out");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                MakePayment();
                StudentMenu studentMenu = new StudentMenu();
                studentMenu.StudentMain();
            }
            else if (opt == 2)
            {
                IBookService _bookService = new BookService();

                Console.WriteLine("Enter your class : ");
                string level = Console.ReadLine();

                var book = _bookService.GetBookByLevel(level);
                if (book == null)
                {
                    Console.WriteLine("No book found for your class");
                }
                foreach (var item in book)
                {
                    Console.WriteLine($"Title : {item.Title}  \nLevel : {item.Level} \nPrice {item.Price} /n");
                }
                StudentMenu studentMenu = new StudentMenu();
                studentMenu.StudentMain();
            }
            else if (opt == 3)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public void MakePayment()
        {
            IBookService _bookService = new BookService();


            Console.WriteLine("Enter the title of the book :");
            string title = Console.ReadLine();

            Console.WriteLine("Enter your matric number");
            string matricNumber = Console.ReadLine();

            Console.WriteLine("Enter the Amount");
            double amount =double.Parse(Console.ReadLine()) ;

            Console.WriteLine("Enter your class");
            string level = Console.ReadLine();

            var textBook = _bookService.GetBookByLevel(level);
            if (textBook == null)
            {
                Console.WriteLine("No book found for your class");
            }
            var book = _bookService.Get(title);
            if (book == null && book.Level == level)
            {
                Console.WriteLine("Book not found");
                StudentMenu studentMenu = new StudentMenu();
                studentMenu.StudentMain();
            }
            if (book != null && book.Level == level)
            {
                IPaymentService _paymentService = new PaymentService();
                var pay = _paymentService.MakePayment(matricNumber,amount,title);
                if (pay == null)
                {
                    Console.WriteLine("Check your input and try again");
                    StudentMenu studentMenu = new StudentMenu();
                    studentMenu.StudentMain();
                }
                else
                {
                    Console.WriteLine("Transaction sucessful!!");
                    System.Console.WriteLine("--------------------------------------------Receipts--------------------------------------");
                    Console.WriteLine($"DATE : {DateTime.Now} \nAMOUNT : {amount} \nBOOK TITLE : {title}");
                    System.Console.WriteLine("CONGRATULATION!!!!! You have sucessfully purchased the book");
                    StudentMenu studentMenu = new StudentMenu();
                    studentMenu.StudentMain();
                }
            }

        }

        public void GETALLBOOKAVAILABLEFORDEPARTMENT()
        {
            IBookService _bookService = new BookService();
            var viewAll = _bookService.GetAll();
            if (GETALLBOOKAVAILABLEFORDEPARTMENT == null)
            {
                Console.WriteLine("Book not found");
                foreach (var item in viewAll)
                {
                    Console.WriteLine($"title : {item.Title} \n book author {item.BookAuthor} \n price {item.Price} \n level {item.Level}");

                }
            }
        }
    }
}