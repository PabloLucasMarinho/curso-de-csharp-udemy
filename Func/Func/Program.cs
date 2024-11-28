using Func.Entities;

List<Product> list = [];

list.Add(new("Tv", 900.00));
list.Add(new("Mouse", 50.00));
list.Add(new("Tablet", 350.50));
list.Add(new("HD Case", 80.90));

//Func<Product, string> func = p => p.Name.ToUpper();

List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

foreach (string s in result)
{
    Console.WriteLine(s);
}

//static string NameUpper(Product p)
//{
//    return p.Name.ToUpper();
//}