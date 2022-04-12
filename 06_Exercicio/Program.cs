using System;
using System.Globalization;

namespace _06_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerodofuncionario;
            double horastrabalhadas, valorhora, salario;

            numerodofuncionario = int.Parse(Console.ReadLine());
            horastrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horastrabalhadas * valorhora;

            Console.WriteLine("O número do funcionário é: " + numerodofuncionario);
            Console.WriteLine("O salário do funcionário é: R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
