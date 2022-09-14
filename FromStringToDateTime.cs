using System;

namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            DateTime myDate = DateTime.ParseExact(dateStr,"dd/MM/yyyy HH:mm", null);
            return myDate;
        }
    }
}