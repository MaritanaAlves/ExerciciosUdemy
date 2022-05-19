using System;

namespace _40_Exercicio_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int values = int.Parse(Console.ReadLine());

            for(int i = 0; i < values; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            int a = printService.First();
            int b = a + 2;
            Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
