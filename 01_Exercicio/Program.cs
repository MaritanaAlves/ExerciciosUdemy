using System;
using System.Globalization;

namespace _01_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5298;
            char genero = 'F';

            double preco1 = 2100.00;
            double preco2 = 350.00;
            double medida = 53.234567;

            Console.WriteLine($"Produtos: {produto1}, cujo o preço é R$ {preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é R$ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos, código: {codigo} genero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimas: {medida.ToString("F8")}");
            Console.WriteLine($"arredondando (três casas decimais): {medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariante cuture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}