using Online_Bookshop.Model.Entities;

namespace Online_Books.Repository.Interface
{
    public interface IPaymentRepository
    {
         string Create(Payment payment);
         
         Payment Get(string transferenceNumber);
         List<Payment> GetAll();

    }
}