using System.Globalization;

namespace LINQ.Entities
{
    internal class Product(int id, string name, double price, Category category)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;
        public Category Category { get; set; } = category;

        public override string ToString()
        {
            return $"{Id}, {Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}, {Category.Name}, {Category.Tier}";
        }
    }
}
