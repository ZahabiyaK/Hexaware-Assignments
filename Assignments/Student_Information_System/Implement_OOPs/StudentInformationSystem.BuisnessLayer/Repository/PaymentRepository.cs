using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BuisnessLayer.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        Payment p = new Payment();
        public PaymentRepository(int payment_id,decimal amount,string date) {
            p.PaymentID = payment_id;
            p.Amount = amount;
            p.PaymentDate = Convert.ToDateTime(date);
        }
        public decimal GetPaymentAmount()
        {
            return p.Amount;
        }

        public DateTime GetPaymentDate()
        {
            return p.PaymentDate;
        }

        public void GetStudent()
        {
            
        }
    }
}
