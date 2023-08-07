namespace Online_Bookshop.Model.Entities
{
    public class Payment : BaseEntity
    {
        public string MatricNumber{get;set;}
        public double Amount{get;set;}
       
        public string TransferenceNumber{get;set;} = GenerateTransferenceNumber();
        public static string GenerateTransferenceNumber()
        {
            Random random = new Random();
            return $"CLH/NO/{random.Next(999,1000).ToString()}";
        }
    }
}