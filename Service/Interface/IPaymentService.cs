using Online_Bookshop.Model.Entities;

namespace Online_Books.Service.Interface
{
    public interface IPaymentService
    {
        Payment MakePayment(string matricNumber, double amount, string title, int quantity = 1);
        Payment Get(string id);
        Payment GetTransference(string transferenceNumber);
        List<Payment> GetAll();
       
    }
}