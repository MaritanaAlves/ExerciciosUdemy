using System;

namespace _09_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Número par");
            }
            else
            {
                Console.WriteLine("Número ímpar");
            }
            Console.ReadKey();
        }
    }
}
