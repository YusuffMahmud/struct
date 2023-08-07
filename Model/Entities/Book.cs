using Online_Books.Model;

namespace Online_Bookshop.Model.Entities
{
    public class Book : BaseEntity
    {
        public string Title{get;set;}
        public string BookAuthor{get;set;}
        public double Price{get;set;}
        public string Level{get;set;}
        public List<CourseBook> courseBooks{get;set;}
        
        

    }
}