using System;
using System.Globalization;

namespace _16_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do Dólar: ");
            double cotacaoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double comprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarEmReal(comprar, cotacaoDoDolar);

            Console.WriteLine("Valor a ser pago em Reais: " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
