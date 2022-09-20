using System;
using System.Runtime.InteropServices;

namespace CSharpDiscovery.Quest04
{
    public class Car:Vehicule
    {
        public string Model { get; set; }

        public Car() : base()
        {
            Model = "Unknown";
        }
        
        public Car(string _Model, string _Brand, string _Color, int _CurrentSpeed = 0)
            : base(_Brand,_Color,_CurrentSpeed)
        {
            Model = _Model;
        }
        
        public override string ToString()
        {
            string str ="(Color) (Brand) (Model)";
            str = str.Replace("(Color)", Color);

            string strB = str;
            strB = str.Replace("(Brand)", Brand);

            string strM = strB;
            strM = strB.Replace("(Model)", Model);

            return strM;
        }

        public override void Accelerate(int speed)
        {
            if (CurrentSpeed + speed >= 180)
            {
                CurrentSpeed = 180;
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