using Online_Books.Service.Implementation;
using Online_Books.Service.Interface;
using Online_Bookshop.Model.Enum;

namespace Online_Books.Menu
{
    public class SuperAdminMenu
    {
         public void SuperAdmin()
         {
            IAdminService _adminService = new AdminService();
            Console.WriteLine("--------------------------Super Admin-------------------------------");
            Console.WriteLine("Enter 1 to register Admin/n Enter 2 to view all Admin/nEnter 3 to Delete an admin/nEnter 4 to log out");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                {
                Console.WriteLine("Enter your First Name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter your Last Name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter your Email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter your Password");
                string password = Console.ReadLine();

                Console.WriteLine("Enter your PhoneNumber");
                string  phoneNumber = Console.ReadLine();
                
                Console.WriteLine("Enter 1 for male and 2 for female");
                Gender gender = (Gender)int.Parse(Console.ReadLine());
                
                var admin = _adminService.Register(firstName,lastName,email,password,phoneNumber,(Gender)gender);
                if (admin== null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.WriteLine("Registration Unsuccesful!!!");
                    Console.ResetColor();
                    SuperAdmin();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Are you sure you want to register {firstName}{lastName} as an admin");
                Console.ResetColor();
                string res = Console.ReadLine();
                if (res.ToUpper() == "YES")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Beep();
                    Console.WriteLine($"You have successful registered {firstName}{lastName} as an admin into your application");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.WriteLine($"{firstName}{lastName}not added as an admin");
                    Console.ResetColor();

                }
                SuperAdminMenu superAdminMenu = new SuperAdminMenu();
                superAdminMenu.SuperAdmin();
                }
                break;

                case 2:
                {
                    var viewAdmin = _adminService.GetAll();
                    if (viewAdmin == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep();
                        Console.WriteLine("No Admin found");
                        Console.ResetColor();
                    }
                    foreach (var item in viewAdmin)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"TagNumber : {item.AdminTagNumber} \nId : {item.Id}/nEmail :{item.UserEmail}");
                        Console.ResetColor();
                    }
                    SuperAdminMenu superAdminMenu = new SuperAdminMenu();
                    superAdminMenu.SuperAdmin();
                }
                break;

                case 3:
                {

                }
                break;

                case 4:
                {
                  MainMenu mainMenu = new MainMenu();
                  mainMenu.Main();
                }
                break;
               
            }
            

         }
    }
}