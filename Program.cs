using System;
using CSharpDiscovery.Quest02;
namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var tab = new int[] { 20, 35, 12, 56, 35, 76 };
            Console.WriteLine(FindLastIndex_Exercice.FindLastIndex(tab, 12));
            Console.WriteLine(FindLastIndex_Exercice.FindLastIndex(tab, 35));
            Console.WriteLine(FindLastIndex_Exercice.FindLastIndex(tab, 66));
        }
    }
}