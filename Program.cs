using System;
using CSharpDiscovery.Quest01;
using CSharpDiscovery.Models;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextTrafficLightColor_Exercice.GetNextTrafficLightColor(TrafficLightColor.Red));
            Console.WriteLine(NextTrafficLightColor_Exercice.GetNextTrafficLightColor(TrafficLightColor.Orange));
            Console.WriteLine(NextTrafficLightColor_Exercice.GetNextTrafficLightColor(TrafficLightColor.None));
        }
    }
}