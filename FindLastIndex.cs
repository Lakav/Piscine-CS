using System;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if (Array.LastIndexOf(tab, a) != -1)
            {
                return Array.LastIndexOf(tab, a);
            }
            else return null;
        }
    }
}