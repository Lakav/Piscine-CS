using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var BordeauxCampus = new Campus();
            BordeauxCampus.Capacity = 3000;
            Console.WriteLine(BordeauxCampus.ToString());
        }
    }
}