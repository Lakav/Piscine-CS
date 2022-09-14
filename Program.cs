using System;
using CSharpDiscovery.Quest02;
namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var tab = new int[] { 1, 2, 3, 4, 6 };
            var tab2 = new int[] { 1, 2, 3, 4, 6 };
            var tab3 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(AreEquals_Exercice.AreEquals(tab, tab2));
            Console.WriteLine(AreEquals_Exercice.AreEquals(tab2, tab3));
        }
    }
}