using System;
using System.Globalization;

namespace _13.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Ente com a largura e altura do retângulo, respectivamente: ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Perímetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        } 
    }
}
