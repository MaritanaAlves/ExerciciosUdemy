using System;

namespace _03_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos dois números é: " + (numero1 + numero2));
            Console.ReadKey();
        }
    }
}
