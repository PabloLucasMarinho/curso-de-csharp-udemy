using System.Globalization;
using Exercicio_1_02;

Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario();

Console.Write("Digite o nome do primeiro funcionário: ");
f1.nome = Console.ReadLine();
Console.Write("Digite o salário do primeiro funcionário: ");
f1.salario = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite o nome do segundo funcionário: ");
f2.nome = Console.ReadLine();
Console.Write("Digite o salário do segundo funcionário: ");
f2.salario = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

decimal media = (f1.salario + f2.salario) / 2;

Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");