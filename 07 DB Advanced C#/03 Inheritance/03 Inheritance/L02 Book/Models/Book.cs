using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_Book.Models
{
    public class Book
    {
        private decimal _price;
        private string _title;
        private string _author;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get => this._author;

            set
            {
                string[] args = value.Split();
                char ch = args[1][0];

                if (Char.IsDigit(ch))
                {
                    throw new ArgumentException("Author  not valid!");
                }

                this._author = value;
            }
        }

        public string Title
        {
            get => this._title;

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this._title = value;
            }
        }

        public virtual decimal Price
        {
            get => this._price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this._price = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}" + Environment.NewLine +
                   $"Title: {this.Title}" + Environment.NewLine +
                   $"Author: {this.Author}" + Environment.NewLine +
                   $"Price: {this.Price:f2}";
        }

    }
}
