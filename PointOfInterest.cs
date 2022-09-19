using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; } = 0.0;
        public double Longitude { get; set; } = 0.0;
        public string Name { get; set; } = null;

        public static string GoogleMapsUrlTemplate { get; set; } =
            "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest()
        {
            Name = "Bordeaux Ynov Campus";
            Latitude = 44.854186;
            Longitude = -0.5663056;
        }

        public PointOfInterest(string _Name, double _Latitude, double _Longitude)
        {
            Name = _Name;
            Latitude = _Latitude;
            Longitude = _Longitude;
        }

        public string GetGoogleMapsUrl()
        {
            string newOne = "";
            newOne = GoogleMapsUrlTemplate.Replace("{0}", Name);
            
            string newTwo = newOne;
            newTwo = newOne.Replace("{1}", Latitude.ToString());
            
            string newThree = newTwo;
            newThree = newThree.Replace("{2}", Longitude.ToString());
            
            string newLast = newThree;
            newLast = newThree.Replace(" ", "+");
            
            return newLast;
        }

        public override string ToString()
        {
            string newOne = "Name-Of-Point (Lat=XXXXXXXXX, Long=YYYYYYYYYY)";
            newOne = newOne.Replace("Name-Of-Point", Name);
            
            string newTwo = newOne;
            newTwo = newOne.Replace("XXXXXXXXX", Latitude.ToString());
            
            string newThree = newTwo;
            newThree = newThree.Replace("YYYYYYYYYY", Longitude.ToString());
            
            return newThree;
        }
        
        private static double degreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
        
        private static double Calculate(PointOfInterest p1, PointOfInterest p2)
        {
            int earthRadiusKm = 6371;
            double dLat = degreesToRadians(p2.Latitude - p1.Latitude);
            double dLon = degreesToRadians(p2.Longitude - p1.Longitude);

            double lat1 = degreesToRadians(p1.Latitude);
            double lat2 = degreesToRadians(p2.Latitude);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return Math.Round(earthRadiusKm * c);
        }
        
        public int GetDistance(PointOfInterest other)
        {
            return (int)Calculate(this, other);
        }

        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            return (int)Calculate(p1, p2);
        }
    }
}

