namespace LINQ.Entities
{
    internal class Category(int id, string name, int tier)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public int Tier { get; set; } = tier;
    }
}
