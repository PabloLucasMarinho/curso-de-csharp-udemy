using Abstratos_Ex.Entities.Enums;

namespace Abstratos_Ex.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle (Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
