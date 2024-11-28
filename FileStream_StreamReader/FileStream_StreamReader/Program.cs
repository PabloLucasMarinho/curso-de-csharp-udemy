string path = @"C:\Users\pablo\OneDrive\Documentos\File1.txt";

//FileStream fs = null;
StreamReader sr = null;

try
{
    //fs = new(path, FileMode.Open);
    //sr = new(fs);
    sr = File.OpenText(path);

    while (!sr.EndOfStream)
    {
    string line = sr.ReadLine();
    Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An rror occurred");
    Console.WriteLine(e.Message);
}
finally
{
    sr?.Close();
    //fs?.Close();
}