using Online_Bookshop.Model.Enum;

namespace Online_Bookshop.Model.Entities
{
    public class User : BaseEntity
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}
        public string PhoneNumber{get;set;}
        public Gender Gender{get;set;}
        public List<Role>Role {get;set;}
        public Admin admin{get;set;}
    }
}