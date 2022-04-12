using System;
using System.Globalization;

namespace _04_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            double pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * (raio * raio);

            Console.WriteLine("A área é igual a: " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
