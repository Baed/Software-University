using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Repositories
{
    public class DefaultAnotherRepository : IAnotherRepository
    {
        public void AndMe()
        {
            Console.WriteLine("I was added leter, and the app should work");
        }
    }
}
