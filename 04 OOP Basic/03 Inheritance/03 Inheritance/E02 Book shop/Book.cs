namespace E02_Book_shop
{
    using System;
    using System.Text;

    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Author
        {
            get { return this.author; }

            protected set
            {
                var nameTokens = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (nameTokens.Length > 1 && char.IsDigit(nameTokens[1][0])) // second name, first char
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }

        public string Title
        {
            get { return this.title; }

            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Title not valid!");
                }
                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").AppendLine($"{this.Price:f1}");

            return sb.ToString();
        }


    }
}
