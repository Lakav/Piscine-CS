using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            PointOfInterest PorteCailhau = new HistoricalMonument("Porte Cailhau", 44.838336, -0.569446, 1493);
            Console.WriteLine(PorteCailhau.ToString());
        }
    }
}