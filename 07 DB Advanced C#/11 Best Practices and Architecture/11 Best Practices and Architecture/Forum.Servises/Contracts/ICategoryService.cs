using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.Servises.Contracts
{
    public interface ICategoryService
    {
        Category ByName(string name);

        Category Create(string name);
    }
}
