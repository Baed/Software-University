using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsWebApp.Services
{
    public class CatService : ICatService
    {
        public CatService()
        {
            this.Cats = new[] {"Gosho", "Pesho"};
        }

        public IEnumerable<string> Cats { get; set; }
    }
}
