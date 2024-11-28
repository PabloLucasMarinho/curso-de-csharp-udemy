using IComparable.Entities;

string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\in.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = [];
        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }

        list.Sort();
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}