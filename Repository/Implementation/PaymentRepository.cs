using MySqlConnector;
using Online_Books.Data;
using Online_Books.Repository.Interface;
using Online_Bookshop.Model.Entities;

namespace Online_Books.Repository.Implementation
{
    public class PaymentRepository : IPaymentRepository
    {
        public static DbContext _context = new DbContext();
        public PaymentRepository()
        {
            _context.Connection();
        }
        public string Create(Payment payment)
        {
            using (var con = _context.Connection())
            {
                con.Open();
                var command = new MySqlCommand($"insert into Payment(Id, TransferenceNumber,MatricNumber,Amount,IsDeleted) values ('{payment.Id}','{payment.TransferenceNumber}','{payment.MatricNumber}','{payment.Amount}','{payment.IsDeleted}')",con);
                var row = command.ExecuteNonQuery();
                if(row != -1)
                {
                    return "Payment created successfully";
                }
                else
                {
                    return "Payment not successfully created";
                }
            }
        }

        public Payment Get(string transferenceNumber)
        {
        try
        {
            using (var con = _context.Connection())
            {
                con.Open();
                var command = new MySqlCommand($"select * from payment where transferenceNumber = {transferenceNumber}",con);
                command.Parameters.AddWithValue("TransferenceNumber",transferenceNumber);
                var row = command.ExecuteReader();
                Payment payment = new Payment();
                while(row.Read())
                {
                    payment.Id = Convert.ToString(row[0]);
                    payment.MatricNumber = Convert.ToString(row[1]);
                    payment.Amount = Convert.ToDouble(row[2]);
                    payment.TransferenceNumber = Convert.ToString(row[3]);
                    payment.IsDeleted = Convert.ToBoolean(row[4]);
                    
                }
                return payment;
            }
        }
        catch (System.Exception)
        {
            
            return null;
        }
        }

        public List<Payment> GetAll()
        {
            using(var con = _context.Connection())
            {
               con.Open();
               var command = new MySqlCommand($"select * from Payment",con);
               var row = command.ExecuteReader();
               List<Payment> payment = new List<Payment>();
               while (row.Read())
               {
                Payment payments = new Payment();
                payments.Id = Convert.ToString(row[0]);
                payments.TransferenceNumber = Convert.ToString(row[1]);
                payments.MatricNumber = Convert.ToString(row[2]);
                payments.Amount = Convert.ToDouble(row[3]);
                payments.IsDeleted = Convert.ToBoolean(row[4]);
                payment.Add(payments);
               }
               return payment;
            }
        }
    }
}