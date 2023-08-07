namespace Online_Bookshop.Model.Entities
{
    public class Admin: BaseEntity
    {
        public string UserEmail{get;set;}
        public string AdminTagNumber{get;set;} = GenerateAdminTagNumber();
         public string AdminId{get;set;} = Guid.NewGuid().ToString().Substring(0,7);
        public static string GenerateAdminTagNumber()
         {
            Random random = new Random();
            return $"CLH/NO/{random.Next(999,1000).ToString()}";
         }
    }

}