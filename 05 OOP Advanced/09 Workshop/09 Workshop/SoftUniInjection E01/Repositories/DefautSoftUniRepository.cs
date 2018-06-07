using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Repositories
{
    public class DefautSoftUniRepository : ISoftUniRepository
    {
        private readonly IPaymentRepository paymentRepo;

        public DefautSoftUniRepository(IPaymentRepository paymentRepo)
        {
            this.paymentRepo = paymentRepo;
        }

        public void Oop()
        {
            Console.WriteLine("softuni repo called");
            Console.WriteLine("softuni repo tries to call payments repo");
            this.paymentRepo.Pay();
        }
    }
}
