namespace CSharpDiscovery.Quest04
{
    public class HybridCar : Car
    {
        public interface IThermalCar
        {
            public int FuelLevel { get; set; } 
            void FillUp();
            int GetFuelLevel();
        }

        public interface IElectricCar
        {
            public int BatteryLevel { get; set; }
            void Recharge();
            int GetBatteryLevel();
        }

        public HybridCar(){}

        public HybridCar(string Model, string Brand, string Color, int CurrentSpeed = 0)
            : base(Model, Brand, Color, CurrentSpeed){}

        public int FuelLevel = 100;

        public int BatteryLevel = 100; 


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
            FuelLevel = 100;
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