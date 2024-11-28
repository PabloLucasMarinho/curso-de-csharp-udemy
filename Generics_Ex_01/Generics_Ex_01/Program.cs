using Generics_Ex_01.Entities;

HashSet<LogRecord> set = [];
string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\in.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord { Username = name, Instant = instant });
        }
        Console.WriteLine("Total users: " + set.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}