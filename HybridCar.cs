namespace CSharpDiscovery.Quest04
{
    public class HybridCar : Car, IElectricCar, IThermalCar
    {

        public HybridCar() : base (){}

        public HybridCar(string Model, string Brand, string Color, int CurrentSpeed = 0)
            : base(Model, Brand, Color, CurrentSpeed){}

        public int FuelLevel { get; set; } = 100;
        public int BatteryLevel { get; set; } = 100;

        public int GetFuelLevel()
        {
            return FuelLevel;
        }

        public int GetBatteryLevel()
        {
            return BatteryLevel;
        }

        public void FillUp()
        {
            this.FuelLevel = 100;
        }

        public void Recharge()
        {
            BatteryLevel = 100;
        }

        public override string ToString()
        {
            return $"{Color} {Brand} {Model}, Battery: {BatteryLevel}%, Fuel: {FuelLevel}%";
        }
    }
}