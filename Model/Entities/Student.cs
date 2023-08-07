using Online_Bookshop.Model.Entities;

namespace Online_Books.Model.Entities
{
    public class Student :BaseEntity
    {
        public string UserEmail{get;set;}
        public string MatricNumber{get;set;} = StudentMatricNumber();
        public List<Book> Books{get;set;}
        public List<Payment>Payments{get;set;}
         private static string StudentMatricNumber()
        {
            var rand = new Random();
            return "STU/NO" + rand.Next(1000, 9999).ToString();
        }
    }
}