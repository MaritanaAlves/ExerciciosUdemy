using System;

namespace _03_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma dos dois números é: " + (numero1 + numero2));
            Console.ReadKey();
        }
    }
}
