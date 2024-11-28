using System.Globalization;
using Exercicio_1_07;

double cotacao;
double dolaresAComprar;

Console.Write("Qual é a cotação do dolar? ");
cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar? ");
dolaresAComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.ValorPagoEmReais(cotacao, dolaresAComprar).ToString("F2", CultureInfo.InvariantCulture)}");