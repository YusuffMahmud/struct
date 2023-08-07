using Online_Bookshop.Model.Entities;

namespace Online_Books.Model.Entities
{
    public class UserRole
    {
        public int UserId{get;set;}
        public User user{get;set;}
        public int RoleId{get;set;}
        public Role role{get;set;}
    }
}