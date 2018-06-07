using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Repositories
{
    public class DefaultUserRepository : IUserRepository
    {
        private readonly IPaymentRepository paymentsRepo;
        private readonly ISoftUniRepository softUniRepo;

        public DefaultUserRepository(IPaymentRepository paymentsRepo, ISoftUniRepository softUniRepo)
        {
            this.paymentsRepo = paymentsRepo;
            this.softUniRepo = softUniRepo;
        }

        public void Print()
        {
            Console.WriteLine("User repo called");
            Console.WriteLine("User repo calling payment repo");
            this.paymentsRepo.Pay();
            Console.WriteLine("User repo calling also softuni repo");
            this.softUniRepo.Oop();
        }
    }
}
