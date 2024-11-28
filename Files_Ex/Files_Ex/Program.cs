using System.Globalization;

string sourcePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
string targetPath = sourcePath + @"\out";

try
{
    using (StreamWriter sw = new(sourcePath + @"\source.csv"))
    {
        sw.WriteLine("TV LED,1290.99,1");
        sw.WriteLine("Video Game Chair,350.50,3");
        sw.WriteLine("Iphone X,900.00,2");
        sw.WriteLine("Samsung Galaxy 9,850.00,2");
    }

    Directory.CreateDirectory(targetPath);

    using (StreamReader sr = new(sourcePath + @"\source.csv"))
    using (StreamWriter sw = new(targetPath + @"\summary.csv"))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            List<string> phrases = new(line.Split(','));

            double.TryParse(phrases[^1], NumberStyles.Any, CultureInfo.InvariantCulture, out double quantity);
            double.TryParse(phrases[^2], NumberStyles.Any, CultureInfo.InvariantCulture, out double price);

            double result = price * quantity;

            sw.WriteLine($"{phrases[0]},{result.ToString("F2", CultureInfo.InvariantCulture)}");
        };
    }

    using (StreamReader sr = new(targetPath + @"\summary.csv"))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}