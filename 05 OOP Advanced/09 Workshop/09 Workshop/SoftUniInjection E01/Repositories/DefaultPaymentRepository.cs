using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Repositories
{
    public class DefaultPaymentRepository : IPaymentRepository
    {
        private readonly IAnotherRepository anotherRepo;

        public DefaultPaymentRepository(IAnotherRepository anotherRepo)
        {
            Console.WriteLine("Constrctor of payments called!");
            this.anotherRepo = anotherRepo;
        }

        public void Pay()
        {
            Console.WriteLine("Payments repo called");
            Console.WriteLine("No payments :((");
            this.anotherRepo.AndMe();
            Console.WriteLine("User repo calling also another repo");
        }
    }
}
