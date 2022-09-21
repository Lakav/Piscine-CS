namespace CSharpDiscovery.Quest04
{
    public class Truck : Vehicule
    {
        public float Tonnage { get; set; }

        public Truck() : base()
        {
            Tonnage = 0;
        }

        public Truck(int _Tonnage, string _Brand, string _Color, int _CurrentSpeed = 0)
            : base(_Brand, _Color, _CurrentSpeed)
        {
            Tonnage = _Tonnage;
        }

        public override string ToString()
        {
            return $"{Color} {Brand} {Tonnage}T Truck";
        }

        public override void Accelerate(int speed)
        {
            if (CurrentSpeed + speed >= 100)
            {
                CurrentSpeed = 100;
            }
            else
            {
                CurrentSpeed += speed;
            }
        }

        public override void Brake(int BrakePower)
        {
            if (BrakePower > CurrentSpeed)
            {
                CurrentSpeed = 0;
            }
            else
            {
                CurrentSpeed -= BrakePower;
            }
        }
    }
}