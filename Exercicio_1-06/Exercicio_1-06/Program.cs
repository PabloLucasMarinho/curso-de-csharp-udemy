using Exercicio_1_06;
using System.Globalization;

Aluno aluno = new Aluno();


Console.Write("Digite o nome do aluno: ");
aluno.Nome = Console.ReadLine();
Console.Write("Digite a primeira nota do Aluno: ");
aluno.Notas.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.Write("Digite a segunda nota do Aluno: ");
aluno.Notas.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.Write("Digite a última nota do Aluno: ");
aluno.Notas.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine(aluno);