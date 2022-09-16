using System;
namespace CSharpDiscovery.Quest03
{
    public class Campus : PointOfInterest
    {
        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public string ToString()
        {
            return $"{Name} is a campus with a capacity of {_capacity} students";
        }
    }
}