using StudentInformationSystem.BuisnessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.BuisnessLayer.Services
{
    public class PaymentService : IPaymentService
    {
        IPaymentRepository _paymentRepository;
        public PaymentService(PaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public decimal GetPaymentAmount()
        {
            return _paymentRepository.GetPaymentAmount();
        }

        public DateTime GetPaymentDate()
        {
            return _paymentRepository.GetPaymentDate();
        }

        public void GetStudent()
        {
            
        }
    }
}
