using System;
using System.Globalization;

namespace _07_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, total;

            string[] vet1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet1[0]);
            int numerodepecas1 = int.Parse(vet1[1]);
            double valordapeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            valor1 = numerodepecas1 * valordapeca1;

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet1[0]);
            int numerodepecas2 = int.Parse(vet2[1]);
            double valordapeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valor2 = numerodepecas2 * valordapeca2;

            total = valor1 + valor2;

            Console.WriteLine("Valor a pagar: R$ " + total.ToString ("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();


        }
    }
}
