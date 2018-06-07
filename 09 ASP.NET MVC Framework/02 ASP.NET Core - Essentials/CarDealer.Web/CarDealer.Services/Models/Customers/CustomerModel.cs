using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Services.Models.Customers
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthTime { get; set; }

        public bool IsYoungDriver { get; set; }
    }
}
