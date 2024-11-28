string sourcePath = @"C:\Users\pablo\OneDrive\Documentos\File1.txt";
string targetPath = @"C:\Users\pablo\OneDrive\Documentos\File2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using StreamWriter sw = File.AppendText(targetPath);
    foreach (string line in lines)
    {
        sw.WriteLine(line.ToUpper());
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}