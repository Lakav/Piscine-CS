namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
    
        char[] charArray = str.ToCharArray();
        int len = str.Length - 1;

        for (int i = 0; i < len; i++, len--)
        {
            charArray[i] ^= charArray[len];
            charArray[len] ^= charArray[i];
            charArray[i] ^= charArray[len];
        }

        return new string(charArray);
        }
    }
}