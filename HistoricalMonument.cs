namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument: PointOfInterest
    {
        public int BuildYear { get; set; } = 0;

        public HistoricalMonument() {}
        public HistoricalMonument(string _Name, double _Latitude, double _Longitude, int _BuildYear)
            : base(_Name, _Latitude, _Longitude)
        {
            BuildYear = _BuildYear;
        }
 
        public override string ToString()
        {
            
            string str ="(Name) is a historical monument built in (BuildYear)";
            str = str.Replace("(Name)", Name);

            string strTwo = str;
            strTwo = str.Replace("(BuildYear)", BuildYear.ToString());
            return strTwo;
        }
    }
}


