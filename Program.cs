using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var DefaultPoint = new PointOfInterest();
            Console.WriteLine(DefaultPoint.GetGoogleMapsUrl());

            var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            Console.WriteLine(ParisCampus.GetGoogleMapsUrl());
        }
    }
}