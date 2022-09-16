using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var BordeauxCampus = new PointOfInterest();
            var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);

            Console.WriteLine(BordeauxCampus.GetDistance(ParisCampus));
            Console.WriteLine(PointOfInterest.GetDistance(BordeauxCampus, ParisCampus));
        }
    }
}