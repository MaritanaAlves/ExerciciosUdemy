using System;
using System.Globalization;

namespace _06_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario = int.Parse(Console.ReadLine());
            double horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"O número do funcionário é: {numeroFuncionario}");
            Console.WriteLine($"O salário do funcionário é: R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
