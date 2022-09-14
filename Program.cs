using System;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 24, 13, 4, 40 };
            Console.WriteLine(string.Join(", ", SortTable_Exercice.SortTable(array)));
        }
    }
}