using System;

namespace _20_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro[] vect = new Registro[10];

            Console.Write("Quantos quartos vão ser alugados? ");
            int quartos = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.WriteLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Registro(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 9; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

            Console.ReadKey();
        }    
    }
}
