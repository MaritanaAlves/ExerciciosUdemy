using System;
using System.Collections.Generic;
using System.Text;

namespace _13.Exercicio
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }
        public double Diagonal()
        {
            return Math.Sqrt (Largura * Largura + Altura * Altura);
        }
    }
}
