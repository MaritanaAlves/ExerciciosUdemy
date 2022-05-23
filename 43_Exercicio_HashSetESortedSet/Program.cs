using System;
using System.Collections.Generic;

namespace _43_Exercicio_HashSetESortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            printCollection(c);

            //Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.UnionWith(b);
            printCollection(d);

            //Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.UnionWith(b);
            printCollection(e);
        }

        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
