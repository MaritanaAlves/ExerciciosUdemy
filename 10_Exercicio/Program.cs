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
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Didite o nome da segunda pessoa pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine(pessoa1.Nome + " é mais velho.");
            }
            else
            {
                Console.WriteLine(pessoa2.Nome + " é mais velho.");
            }

            Console.ReadKey();
        }
    }
}
