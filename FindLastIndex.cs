using System;

namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if (tab == null)
            {
                return null;
            }
            
            if (Array.LastIndexOf(tab, a) != -1)
            {
                return Array.LastIndexOf(tab, a);
            }
            
            return null;
        }
    }
}