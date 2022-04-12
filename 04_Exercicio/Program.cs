using System;
using System.Globalization;

namespace _04_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;

            Console.Write("Digite o raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double raioAoQuadrado = Math.Pow(raio, 2);
            double area = PI * raioAoQuadrado;

            Console.WriteLine($"A área é igual a: {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
