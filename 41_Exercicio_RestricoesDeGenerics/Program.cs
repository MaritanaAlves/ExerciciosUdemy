using System;
using System.Collections.Generic;
using _41_Exercicio_RestricoesDeGenerics.Services;
using _41_Exercicio_RestricoesDeGenerics.Entities;
using System.Globalization;

namespace _41_Exercicio_RestricoesDeGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.Write(max);
        }
    }
}
