using System;
using System.Globalization;

namespace _11_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario1 = new Funcionarios();
            Funcionarios funcionario2 = new Funcionarios();

            Console.Write("Digite o nome do primeiro funcionário: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Digite o salário do primeiro funcionário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o nome do segundo funcionário: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Digite o salário do segundo funcionário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine($"O salário médio dos funcionários é: R$ {media}");
        }
    }
}
