using System.Globalization;
using Abstratos_Ex.Entities;
using Abstratos_Ex.Entities.Enums;

Console.Write("Enter the number of shapes: ");
int quantity = int.Parse(Console.ReadLine());
List<Shape> shapes = [];

for (int i = 1;  i <= quantity; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Shape #{i} data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    char response = char.Parse(Console.ReadLine().ToLower());

    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (response == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
        shapes.Add(new Rectangle(color, width, height));
    }else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
        shapes.Add(new Circle(color, radius));
    }
}

Console.WriteLine("");
Console.WriteLine("SHAPE AREAS:");
foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}