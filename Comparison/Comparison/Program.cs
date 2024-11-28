using Comparison.Entities;

List<Product> products = [];

products.Add(new("TV", 900.00));
products.Add(new("Notebook", 1200.00));
products.Add(new("Tablet", 450.00));

//Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

foreach (Product product in products)
{
    Console.WriteLine(product);
}

//static int CompareProducts(Product p1,  Product p2)
//{
//    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//}