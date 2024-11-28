//// Specify the data source
//int[] numbers = [2, 3, 4, 5,];

//// Define the query expression
//IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

//// Execute the query
//foreach (int x in result)
//{
//    Console.WriteLine(x);
//}

using LINQ.Entities;

static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach (T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}

Category c1 = new(1, "Tools", 2);
Category c2 = new(2, "Computers", 1);
Category c3 = new(3, "Eletronics", 1);

List<Product> products = [
    new(1, "Computer", 1100.0, c2),
    new(2, "Hammer", 90.0, c1),
    new(3, "TV", 1700.0, c3),
    new(4, "Notebook", 1300.0, c2),
    new(5, "Saw", 80.0, c1),
    new(6, "Tablet", 700.0, c2),
    new(7, "Camera", 700.0, c3),
    new(8, "Printer", 350.0, c3),
    new(9, "MacBook", 1800.0, c2),
    new(10, "Sound Bar", 700.0, c3),
    new(11, "Level", 70.0, c1)
];

//var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
var r1 =
    from p in products
    where p.Category.Tier == 1 && p.Price < 900.0
    select p;
Print("TIER 1 AND PRICE < 900:", r1);

//var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
var r2 =
    from p in products
    where p.Category.Name == "Tools"
    select p.Name;
Print("NAMES OF PRODUCTS FROM TOOLS:", r2);

//var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name } );
var r3 =
    from p in products
    where p.Name[0] == 'C'
    select new { 
        p.Name, 
        p.Price, 
        CategoryName = p.Category.Name 
    };
Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);

//var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
var r4 =
    from p in products
    where p.Category.Tier == 1
    orderby p.Name
    orderby p.Price
    select p;
Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r4);

//var r5 = r4.Skip(2).Take(4);
var r5 =
    (from p in r4
     select p).Skip(2).Take(4);
Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", r5);

var r6 = products.First();
Console.WriteLine("First test: " + r6);
var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
Console.WriteLine("First or default test: " + r7);
var r8 = products.Where(p => p.Id == 3).Single();
Console.WriteLine("Single test: " + r8);
var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("Single or default test: " + r9);

var r10 = products.Max(p => p.Price);
Console.WriteLine("Max price: " + r10);
var r11 = products.Min(p => p.Price);
Console.WriteLine("Min price: " + r11);
var r12 =  products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("Category 1 Sum prices: " + r12);
var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("Category 1 Average prices: " + r13);
var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0).Average();
Console.WriteLine("Category 5 Average prices: " + r14);
var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
Console.WriteLine("Category 1 Aggregate sum: " + r15);

Console.WriteLine();
//var r16 = products.GroupBy(p => p.Category);
var r16 =
    from p in products
    group p by p.Category;
foreach (IGrouping<Category, Product> group in r16)
{
    Console.WriteLine("Category " + group.Key.Name + ":");
    foreach (Product p in group)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
}