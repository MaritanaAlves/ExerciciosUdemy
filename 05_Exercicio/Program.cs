using System;

namespace _05_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine("A diferença do produto de A e B pelo produto de C e D é: " + diferenca);
            Console.ReadKey();
        }
    }
}
