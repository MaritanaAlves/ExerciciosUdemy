using System;

namespace _05_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b) - (c * d);

            Console.WriteLine("A diferença do produto de A e B pelo produto de C e D é: " + diferenca);
            Console.ReadKey();
        }
    }
}
