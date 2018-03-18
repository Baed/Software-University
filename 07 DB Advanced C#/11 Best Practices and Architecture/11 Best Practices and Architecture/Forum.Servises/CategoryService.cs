using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Forum.Servises.Contracts;

namespace Forum.Servises
{
    public class CategoryService : ICategoryService
    {
        private readonly ForumDbContex _context;

        public CategoryService(ForumDbContex context)
        {
            _context = context;
        }

        public Category ByName(string name)
        {
            var category = _context.Categories
                .SingleOrDefault(c => c.Name == name);

            return category;
        }

        public Category Create(string name)
        {
            var category = new Category
            {
                Name = name
            };

            _context.Categories.Add(category);

            _context.SaveChanges();

            return category;
        }
    }
}
