using System;

namespace _10_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.Write("Didite o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.Write("Didite o nome da segunda pessoa pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine(pessoa1.nome + " é mais velho.");
            }
            else
            {
                Console.WriteLine(pessoa2.nome + " é mais velho.");
            }

            Console.ReadKey();
        }
    }
}
