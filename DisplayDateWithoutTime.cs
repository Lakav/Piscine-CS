using System;

namespace CSharpDiscovery.Quest02
{
    public class DisplayDateWithoutTime_Exercice
    {
        public static string DisplayDateWithoutTime(DateTime date)
        {
            string strTodayFR = date.ToString("dd/MM/yyyy HH:mm:ss");
            return strTodayFR;

        }
    }
}