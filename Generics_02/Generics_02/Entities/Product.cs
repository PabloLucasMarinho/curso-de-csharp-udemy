using System.Globalization;

namespace Generics_02.Entities
{
    internal class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(Product other)
        {
            if (!(other is Product))
            {
                throw new ArgumentException("Comparing error: argument is not a Product");
            }
            return Price.CompareTo(other.Price);
        }
    }
}
