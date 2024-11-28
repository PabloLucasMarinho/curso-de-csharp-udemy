string path = @"C:\temp\myfolder";

try
{
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS:");
    foreach (string folderItem in folders)
    {
        Console.WriteLine(folderItem);
    }

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FILES:");
    foreach (string file in files)
    {
        Console.WriteLine(file);
    }

    Directory.CreateDirectory(path + @"\newFolder");
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}