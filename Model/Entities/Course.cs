using Online_Books.Model;

namespace Online_Bookshop.Model.Entities
{
    public class Course : BaseEntity
    {
        public string Title{get;set;}
        public int price{get;set;}
        public List<CourseBook> courseBooks{get;set;}
    }
}