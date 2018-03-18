using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Category
    {
        public Category()
        {
        }

        public Category(string name)
        {
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
