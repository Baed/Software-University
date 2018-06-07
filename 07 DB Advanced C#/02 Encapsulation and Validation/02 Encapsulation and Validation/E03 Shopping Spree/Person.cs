using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Shopping_Spree
{
    public class Person
    {
        private string _name;
        private decimal _price;
        private ICollection<Product> _bag;

        public Person(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
            this._bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                _name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }

                _price = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
        {
            get => this._bag as IReadOnlyCollection<Product>;
        }

        public void BuyProduct(Product product)
        {

            if (product.Price <= this.Price)
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");

                this.Price -= product.Price;
                this._bag.Add(product);
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            string person = $"{this.Name} - ";

            if (this._bag.Count == 0)
            {
                person += "Nothing bought";
            }
            else
            {
                person += string.Join(", ", this._bag);
            }

            return person;
        }
    }
}
