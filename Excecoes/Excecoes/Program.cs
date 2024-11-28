bool error = false;
do
{
    try
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        int result = n1 / n2;
        Console.WriteLine(result);
        error = false;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine($"Division by zero is not allowed!");
        error = true;
    }
    catch (FormatException)
    {
        Console.WriteLine($"Please, enter an integer number!");
        error = true;
    }
}while (error);