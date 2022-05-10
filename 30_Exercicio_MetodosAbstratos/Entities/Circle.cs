using System;
using _30_Exercicio_MetodosAbstratos.Entities.Enums;

namespace _30_Exercicio_MetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
