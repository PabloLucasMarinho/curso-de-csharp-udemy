using Exercicio_1_05;
using System.Globalization;

Funcionario func = new Funcionario();

Console.Write("Digite o nome do funcionário: ");
func.Nome = Console.ReadLine();
Console.Write("Digite seu salário bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Digite a quantidade de imposto que o funcionário deverá pagar: ");
func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Funcionário: {func}");

Console.Write("Digite a porcentagem para aumentar o salário: ");
func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine($"Dados atualizados: {func}");