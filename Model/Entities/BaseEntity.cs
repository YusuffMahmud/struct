namespace Online_Bookshop.Model.Entities
{
    public class BaseEntity
    {
        public string Id{get;set;} = Guid.NewGuid().ToString().Substring(0,7);
        public bool IsDeleted{get;set;} = false;
        
    }
}