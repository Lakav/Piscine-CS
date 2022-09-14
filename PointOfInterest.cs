using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; } = 0.0;
        public double Longitude { get; set; } = 0.0;
        public string Name { get; set; } = null;
        public static string GoogleMapsUrlTemplate { get; set; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";



    }
}