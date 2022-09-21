using CSharpDiscovery.Quest04;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var RandomTruck = new Truck();
            var MAC = new Truck(2, "MAC", "White", 80);
            var Renault = new Truck(3, "Renault", "Black", 20);

            Vehicule.WhoIsHere();

            RandomTruck.Accelerate(30);
            MAC.Accelerate(40);
            Renault.Brake(30);

            Vehicule.WhoIsHere();
        }
    }
}