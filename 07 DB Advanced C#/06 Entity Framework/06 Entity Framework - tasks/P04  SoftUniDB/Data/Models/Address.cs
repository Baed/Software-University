using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace E01_SoftUniDB.Data.Models
{
    public class Address
    {
        public Address()
        {

        }

        //[Key] using System.ComponentModel.DataAnnotations;
        public int AddressId { get; set; }

        public string AddressText { get; set; }

        public int? TownId { get; set; }

        public Town Town { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>(); // new convention 
    }
}
