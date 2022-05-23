using System;
using System.Collections.Generic;
using _44_Exercicio_ColecoesHash.Entities;

namespace _44_Exercicio_ColecoesHash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1500.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }
    }
}
