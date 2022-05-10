using _30_Exercicio_MetodosAbstratos.Entities.Enums;

namespace _30_Exercicio_MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
