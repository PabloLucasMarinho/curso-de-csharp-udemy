using System.Globalization;

namespace Exercicio_1_06
{
    internal class Aluno
    {
        public string Nome;
        public List<double> Notas = new List<double> {};

        public double SomarNotas()
        {
            double total = 0;
            foreach (var nota in Notas)
            {
                total += nota;
            }
            return total;
        }
        
        public override string ToString()
        {
            if (SomarNotas() >= 60.00)
            {
                return $"NOTA FINAL = {SomarNotas().ToString("F2", CultureInfo.InvariantCulture)}\nAPROVADO";
            } else
            {
                return $"MOTA FINAL = {SomarNotas().ToString("F2", CultureInfo.InvariantCulture)}\nREPROVADO\nFALTARAM {(60 - SomarNotas()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
