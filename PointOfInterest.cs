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

        public string ToString()
        {
            string newOne = "Name-Of-Point (Lat=XXXXXXXXX, Long=YYYYYYYYYY)";
            newOne = newOne.Replace("Name-Of-Point", Name);
            
            string newTwo = newOne;
            newTwo = newOne.Replace("XXXXXXXXX", Latitude.ToString());
            
            string newThree = newTwo;
            newThree = newThree.Replace("YYYYYYYYYY", Longitude.ToString());
            
            return newThree;
        }
    }
}

