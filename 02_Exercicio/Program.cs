using System;
using System.Globalization;

namespace _02_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = (Console.ReadLine());
            int numerodequartos = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');
            string ultimonome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(numerodequartos);
            Console.WriteLine(preco);

            Console.WriteLine(ultimonome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
