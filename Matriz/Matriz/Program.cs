//double[,] matriz = new double[2, 3];

//Console.WriteLine(matriz.Length);

//Console.WriteLine(matriz.Rank);

//Console.WriteLine(matriz.GetLength(0));

//Console.WriteLine(matriz.GetLength(1));

Console.Write("Insert matrix length: ");
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];

for (int line = 0; line < n; line++)
{
    Console.Write($"Insert values for line {line+1}: ");
    string[] values = Console.ReadLine().Split(' ');

    for (int col = 0; col < n; col++)
    {
        mat[line, col] = int.Parse(values[col]);
    }
}

Console.WriteLine("Main diagonal: ");
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + " ");
}
Console.WriteLine();

int count = 0;
for (int line = 0; line < n; line++)
{
    for (int col = 0; col < n; col++)
    {
        if (mat[line, col] < 0)
        {
            count++;
        }
    }
}

Console.WriteLine($"Negative numbers: {count}");