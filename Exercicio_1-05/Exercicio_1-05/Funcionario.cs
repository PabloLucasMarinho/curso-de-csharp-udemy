using System.Globalization;

namespace Exercicio_1_05
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return $"{Nome}, R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
