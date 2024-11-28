Console.Write("Insert the number of lines: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Insert the number of columns: ");
int n  = int.Parse(Console.ReadLine());

int[,] mat = new int[m, n];


for (int line = 0; line < m; line++)
{
    Console.Write($"Insert values for line {line + 1}: ");
    string[] values = Console.ReadLine().Split(" ");

    for (int col = 0; col < n; col++)
    {
        mat[line, col] = int.Parse(values[col]);
    }
}

Console.Write("Type an integer number: ");
int num = int.Parse(Console.ReadLine());

for (int line = 0; line < m; line++)
{
    for (int col = 0; col < n; col++)
    {
        if (mat[line, col] == num)
        {
            Console.WriteLine($"Position: {line},{col}");

            if (col > 0)
            {
                Console.WriteLine($"Left: {mat[line, col - 1]}");
            }

            if (line > 0)
            {
                Console.WriteLine($"Up: {mat[line - 1, col]}");
            }

            if (col != n - 1)
            {
                Console.WriteLine($"Right: {mat[line, col + 1]}");
            }

            if (line != m -1)
            {
                Console.WriteLine($"Down: {mat[line + 1, col]}");
            }
        }
    }
}