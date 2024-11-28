Dictionary<string, int> candidates = [];
string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\in.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');
            string name = line[0];
            int votes = int.Parse(line[1]);

            if (candidates.ContainsKey(name))
            {
                candidates[name] += votes;
            }
            else
            {
                candidates[name] = votes;
            }
        }
    }

    foreach (KeyValuePair<string, int> candidate in candidates)
    {
        Console.WriteLine(candidate.Key + ": " + candidate.Value);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}