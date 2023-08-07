// See https://aka.ms/new-console-template for more information

using Online_Books.Data;
using Online_Books.Menu;

DbContext db = new DbContext();
db.CreateUserTable();
db.CreateStudentTable();
db.CreateAdminTable();
db.CreateBookTable();
db.CreateParentTable();

MainMenu mainMenu = new MainMenu();
mainMenu.Main();