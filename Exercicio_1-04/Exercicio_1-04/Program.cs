using Exercicio_1_04;
using System.Globalization;

Retangulo retangulo = new Retangulo();

Console.Write("Digite a largura do retangulo: ");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Digite a altura do retangulo: ");
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(retangulo);