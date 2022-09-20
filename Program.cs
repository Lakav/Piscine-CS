using System;
using CSharpDiscovery.Quest04;


namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var Megane = new Car("Mégane", "Renault", "Yellow", 100);

            Megane.Accelerate(50);

            Console.WriteLine(Megane.CurrentSpeed);

            Megane.Accelerate(50);

            Console.WriteLine(Megane.CurrentSpeed);

            Megane.Brake(160);

            Console.WriteLine(Megane.CurrentSpeed);

            Megane.Brake(40);

            Console.WriteLine(Megane.CurrentSpeed);
        }
    }
}