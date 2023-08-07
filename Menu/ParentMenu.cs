using Online_Books.Service.Implementation;
using Online_Books.Service.Interface;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Menu
{
    public class ParentMenu
    {
        public void ParentAdmin()
        {
            IBookService _bookService = new BookService();

            Console.WriteLine("Press 1 to buy book for ur children\n Press 2 to view all book in the store \n Press 3 to log out");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                {
                    IPaymentService _paymentService = new PaymentService();
                    Console.WriteLine("Enter the name of the book you want to buy for your child");
                    string title = Console.ReadLine();

                    Console.WriteLine("Enter your child matric number ");
                    string matric = Console.ReadLine();

                    Console.WriteLine("Enter the amount of the book");
                    double amount = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the quantity of the book you want to buy");
                    int quantity = int.Parse(Console.ReadLine());

                    var book = _bookService.Get(title);
                    if (book == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep();
                        Console.WriteLine("Book not found");
                        Console.ResetColor();
                    }
                    var pay = _paymentService.MakePayment(matric,amount,title,quantity = 1);
                    if (pay == null)
                    {
                        Console.WriteLine("Check your input and try again");
                    }
                    else
                    {
                        Console.WriteLine("Transaction sucessful");
                    }
                    ParentMenu parentMenu = new ParentMenu();
                    parentMenu.ParentAdmin();

                }
                break;
                
                case 2:
                {
                    GetAll();
                    ParentMenu parentMenu = new ParentMenu();
                    parentMenu.ParentAdmin();
                }
                break;

                case 3:
               {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
               }
               break;
            }
        }
            
            public void GetAll()
            {
                IBookService _bookService = new BookService();

                var viewAll = _bookService.GetAll();
                if (GetAll == null)
                {
                    Console.WriteLine("Book not found");
                }
                foreach (var item in viewAll )
                {
                    Console.WriteLine($"title : {item.Title} /n price {item.Price}");

                }
            }

            public void ParentRegister()
            {
                IParentService _parentService = new ParentService();
                IStudentService _studentService = new StudentService();
                Console.WriteLine("Enter your first name");
                string firstName = Console.ReadLine();


                Console.WriteLine("Enter your last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter your email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                Console.WriteLine("Enter your phoneNumber");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Enter 1 for male and 2 for female");
                Gender gender = (Gender) int.Parse(Console.ReadLine());

               Console.WriteLine("How many student do you have");
               int count = int.Parse(Console.ReadLine());

               List<string> studentMatricNumber  = new();
               for (int i = 0; i < count; i++)
               {
                 start:
                 Console.WriteLine("Enter your child matric number ");
                 string matricNumber = Console.ReadLine();
                 var student = _studentService.Get(matricNumber);

                 if (student == null)
                 {
                    Console.WriteLine("Matric number doesnt exist");
                    Console.WriteLine("Press 1 to enter another matric number\nPress 2 to go back to the main menu");
                    var response = int.Parse(Console.ReadLine());
                    if (response == 1)
                    {
                        
                    }
                    else if (response == 2)
                    {
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Main();
                    }
                 goto start;
                 }
                 studentMatricNumber.Add(matricNumber);
               }

               var parentReg = _parentService.Create(firstName,lastName,email,phoneNumber,password,studentMatricNumber,(Gender)gender);
               Console.WriteLine($"Congratulation {firstName}{lastName} you have sucessfully registered as a parent");

               MainMenu mainMenu1 = new MainMenu();
               mainMenu1.Main();
            }
               
            
    }
}