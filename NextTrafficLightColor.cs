using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            switch (currentColor){
                case TrafficLightColor.None:
                    return TrafficLightColor.None;
                
                case TrafficLightColor.Green:
                    return TrafficLightColor.Orange;
                
                case TrafficLightColor.Red:
                    return TrafficLightColor.Green;
                
                case TrafficLightColor.Orange:
                    return TrafficLightColor.Red;
                default:
                    return TrafficLightColor.None;

            }
        }
    }
}