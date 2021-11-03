using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // union
            SortedSet<int> c = new SortedSet<int>(a); // meu conjunto c vai ter todos elementos contidos em a
            
            c.UnionWith(b); // uniao algebrica de conjuntos significa que eu vou inserir dentro
            // do conjunto c todos os elementos de b que nao estejam em c. (Conjunto nao aceita repeticao)
            PrintCollection(a);
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); // ira inserir no objeto d aqueles elementos que existem nos dois conjuntos (d e b no caso)
            PrintCollection(d);
        
            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // insere no objeto os elementos de a excluindo os elementos contidos em b
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
