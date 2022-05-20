using _41_Exercicio_GetHashCodeEEquals.Entities;
using System;

namespace _41_Exercicio_GetHashCodeEEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "João", Email = "joao@gmail.com" };

            Console.WriteLine(a.Equals(b));
        }
    }
}
