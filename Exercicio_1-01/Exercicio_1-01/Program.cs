using Exercicio_1_01;

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

Console.Write("Digite o nome da primeira pessoa: ");
pessoa1.nome = Console.ReadLine();
Console.Write("Digite a idade da primeira pessoa: ");
pessoa1.idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o nome da segunda pessoa: ");
pessoa2.nome = Console.ReadLine();
Console.Write("Digite a idade da segunda pessoa: ");
pessoa2.idade = Convert.ToInt32(Console.ReadLine());

if (pessoa1.idade > pessoa2.idade)
{
    Console.WriteLine($"Pessoa mais velha: {pessoa1.nome}.");
} else if (pessoa1.idade < pessoa2.idade)
{
    Console.WriteLine($"Pessoa mais velha: {pessoa2.nome}.");
} else
{
    Console.WriteLine($"{pessoa1.nome} e {pessoa2.nome} tem a mesma idade!");
}
