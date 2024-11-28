using Predicate.Entities;

List<Product> list = [];

list.Add(new("Tv", 900.00));
list.Add(new("Mouse", 50.00));
list.Add(new("Tablet", 350.50));
list.Add(new("HD Case", 80.90));

//list.RemoveAll(ProductTest);

//foreach (Product p in list)
//{
//    Console.WriteLine(p);
//}

//static bool ProductTest(Product p)
//{
//    return p.Price >= 100.0;
//}

static void UpdatePrice(Product p)
{
    p.Price += p.Price * 0.1;
}

list.ForEach(UpdatePrice);

foreach (Product p in list)
{
    Console.WriteLine(p);
}