using System.Globalization;

namespace Exercicio_1_08
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular.Trim();
            DepositarDinheiro(saldo);
        }

        public void DepositarDinheiro(double valor)
        {
            Saldo += valor;
        }

        public void SacarDinheiro(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
