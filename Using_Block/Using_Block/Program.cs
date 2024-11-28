string path = @"C:\Users\pablo\OneDrive\Documentos\File1.txt";

try
{
    using StreamReader sr = File.OpenText(path);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}