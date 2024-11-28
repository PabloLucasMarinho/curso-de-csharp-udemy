using Abstratos_Ex.Entities.Enums;

namespace Abstratos_Ex.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape() { }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
