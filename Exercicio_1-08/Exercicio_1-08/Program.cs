using System.Globalization;
using Exercicio_1_08;

Console.Write("Entre o número da conta: ");
int numeroConta = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá deposíto inicial? (s/n) ");
double saldo = 0;
if (Console.ReadLine().ToUpper() == "S")
{
    Console.Write("Entre o valor de deposito inicial: ");
    saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

Conta conta = new Conta(numeroConta, titular, saldo);
int opcao = 0;

Console.WriteLine("");
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);

do
{
    Console.WriteLine("");
    Console.Write("Digite [1] para fazer um depósito, [2] para fazer um saque ou [3] para sair: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("");
            Console.Write("Entre um valor para depósito: ");
            conta.DepositarDinheiro(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            break;
        case 2:
            Console.WriteLine("");
            if (conta.Saldo <= 0)
            {
                Console.WriteLine("Conta sem saldo. Saque não permitido!");
            }
            else
            {
                Console.Write("Entre um valor para saque: ");
                conta.SacarDinheiro(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(conta);
            }
            break;
        case 3:
            break;
        default:
            Console.WriteLine("");
            Console.WriteLine("Opção inválida!");
            break;
    }
}
while (opcao != 3);