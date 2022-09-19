using CSharpDiscovery.Quest04;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var RandomCar = new Car();
            var Megane = new Car("Mégane", "Renault", "Yellow", 50);
            Vehicule.WhoIsHere();
        }
    }
}