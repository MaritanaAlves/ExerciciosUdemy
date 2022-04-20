using System;

namespace _14_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite os dados do Funcionário: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse (Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse (Console.ReadLine());

            Console.Write("Funcionário: " + f.Nome + )

            Console.ReadKey();
        }
    }
}
