using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Repositories
{
    public class Useless : IUselessRepository
    {
        public void UselessMe()
        {
            Console.WriteLine("");
        }
    }
}
