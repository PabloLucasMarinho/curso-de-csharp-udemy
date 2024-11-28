//HashSet<string> set = [];

//set.Add("TV");
//set.Add("Notebook");
//set.Add("Tablet");

//Console.WriteLine(set.Contains("Computer"));

//foreach (string item in set)
//{
//    Console.WriteLine(item);
//}

SortedSet<int> a = [0, 2, 4, 5, 6, 8, 10];
SortedSet<int> b = [5, 6, 7, 8, 9, 10];

// union
SortedSet<int> c = new(a);
c.UnionWith(b);
PrintCollection(c);

// intersection
SortedSet<int> d = new(a);
d.IntersectWith(b);
PrintCollection(d);

// difference
SortedSet<int> e = new(a);
e.ExceptWith(b);
PrintCollection(e);

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T obj in collection)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}