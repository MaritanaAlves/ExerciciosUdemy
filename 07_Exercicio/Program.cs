using System;
using System.Globalization;

namespace _07_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet1[0]);
            int numeroPecas1 = int.Parse(vet1[1]);
            double valorPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            double valor1 = numeroPecas1 * valorPeca1;

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet1[0]);
            int numeroPecas2 = int.Parse(vet2[1]);
            double valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valor2 = numeroPecas2 * valorPeca2;

            double total = valor1 + valor2;

            Console.WriteLine("Valor a pagar: R$ " + total.ToString ("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
