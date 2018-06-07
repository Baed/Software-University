using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsWebApp.Services
{
    public interface ICatService
    {
        IEnumerable<string> Cats { get; set; }
    }
}
