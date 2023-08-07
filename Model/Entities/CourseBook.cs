using Online_Bookshop.Model.Entities;

namespace Online_Books.Model
{
    public class CourseBook
    {
        public int BookId{get;set;}
        public Book book{get;set;}
        public int CourseId{get;set;}
        public Course course{get;set;}
    }
}