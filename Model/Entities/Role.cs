namespace Online_Bookshop.Model.Entities
{
    public class Role : BaseEntity
    {
        public string Name{get;set;}
        public string Description{get;set;}
        public List<User> user{get;set;}
    }
}