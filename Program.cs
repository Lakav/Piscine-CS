using System;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new DateTime(2021, 02, 01, 12, 0, 0, 0);
            var end = new DateTime(2021, 02, 01, 18, 0, 0, 0);
            Console.WriteLine(DifferenceInMinutes_Exercice.DifferenceInMinutes(start, end));

        }
    }
}