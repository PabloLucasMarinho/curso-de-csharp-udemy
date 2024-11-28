string sourcePath = @"C:\Users\pablo\OneDrive\Documentos\File1.txt";
string targetPath = @"C:\Users\pablo\OneDrive\Documentos\File2.txt";

try
{
    FileInfo fileInfo = new(sourcePath);
    fileInfo.CopyTo(targetPath);

    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}