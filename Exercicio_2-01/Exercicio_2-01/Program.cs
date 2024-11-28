using Exercicio_2_01;

Quartos[] quartos = new Quartos[10];

Console.Write("Quanto quartos serão alugados? ");
int alugueis = int.Parse(Console.ReadLine());

for  (int i = 0; i < alugueis; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Aluguel #{i+1}");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());

    quartos[quarto] = new Quartos(nome, email);
}

Console.WriteLine("");
Console.WriteLine("Quartos ocupados:");
int contador = 0;
foreach (Quartos quarto in quartos)
{
    if (quarto != null)
    {
        Console.WriteLine($"{contador}: {quarto}");
    }
    contador++;
}
/*for (int i = 0; i < quartos.Length; i++)
{
    if (quartos[i] != null)
    {
        Console.WriteLine($"{i}: {quartos[i]}");
    }
}*/