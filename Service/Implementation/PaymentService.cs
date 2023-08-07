using Online_Books.Repository.Implementation;
using Online_Books.Service.Interface;
using Online_Bookshop.Model.Entities;

namespace Online_Books.Service.Implementation
{
    public class PaymentService : IPaymentService
    {
        public List<Payment> payments = new List<Payment>();

        public Payment Get(string  id)
        {
           PaymentRepository _paymentRepository = new PaymentRepository();

           var Payment = _paymentRepository.Get(id);
           if (Payment.Id == id)
           {
             return Payment;
           }
           return null;
        }


        public List<Payment> GetAll()
        {
            PaymentRepository _paymentRepository = new PaymentRepository();
             var payment = _paymentRepository.GetAll();
           
            return payment;
        }

        public Payment GetTransference(string transferenceNumber)
        {
           PaymentRepository _paymentRepository = new PaymentRepository();
           var payment = _paymentRepository.Get(transferenceNumber);
           if (payment.TransferenceNumber == transferenceNumber)
           {
            return payment;
           }
           return null;
        }

        public Payment MakePayment(string matricNumber, double amount, string title, int quantity = 1)
        {
            StudentRepository _studentRepository = new StudentRepository();
            BookRepository _bookRepository = new BookRepository();
           var matnum = _studentRepository.Get(matricNumber);
           if (matnum == null)
           {
             Console.WriteLine("Student not found");
             return null;
           }
           var booktitle = _bookRepository.Get(title);

           if (booktitle.Price == amount)
           {
              if (quantity == 1)
              {
                 PaymentRepository _paymentRepository = new PaymentRepository();
                 var payment = new Payment
                 {
                    MatricNumber = matricNumber,
                    Amount = amount,   
                 };
                 _paymentRepository.Create(payment);
                 Console.WriteLine("Payment sucessfull!!!");
                 return payment;
              }
           }
           return null;
        }
        public string GetTransNum()
        {
            var rand = new Random();
            return "CLH/ACC" + rand.Next(1111,9999).ToString();
        }
        
    }

}