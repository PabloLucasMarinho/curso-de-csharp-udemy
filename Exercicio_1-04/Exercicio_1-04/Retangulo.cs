using System.Globalization;

namespace Exercicio_1_04
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return $"ÁREA: {Area().ToString("F2", CultureInfo.InvariantCulture)}\nPERÍMETRO: {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\nDIAGONAL: {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
