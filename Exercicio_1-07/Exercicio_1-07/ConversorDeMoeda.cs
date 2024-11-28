using System.Globalization;

namespace Exercicio_1_07
{
    internal class ConversorDeMoeda
    {

        public static double ValorPagoEmReais(double cotacao, double dolaresAComprar)
        {
            double total = 0;
            total = dolaresAComprar * cotacao;
            total += (total * 6.0 / 100);
            return total;
        }
    }
}
