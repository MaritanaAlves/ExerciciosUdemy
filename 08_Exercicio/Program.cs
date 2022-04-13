using System;

namespace _08_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x > 0) {
                Console.WriteLine("Número positivo");
            }
            else
            {
                Console.WriteLine("Número negativo");
            }
            Console.ReadKey();
        }
    }
}
