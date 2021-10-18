using System;

namespace Ceasar_encryptie
{
    internal class Program
    {

        // Klein beetje refactoring gedaan in deze class. - Michiel
        private const string Alfabet = "abcdefghijklmnopqrstuvwxyz";

        private static void Main(string[] args)
        {
            Console.WriteLine("Encrypt:");
            string encryptedString = Encrypt(GetZin(), GetKey());
            Console.WriteLine("Decrypt:");
            string decryptedstring = Decrypt(GetZin(), GetKey());
            
            Console.WriteLine("");
            PrintResultaat(encryptedString, decryptedstring);
            Console.ReadLine();
        }

        private static void PrintResultaat(string encryptedString, string decryptedstring)
        {
            Console.WriteLine($"encrypt: {encryptedString}");
            Console.WriteLine($"decrypt: {decryptedstring}");
        }

        private static char[] GetZin()
        {
            //aanmaak zin met omzet naar char
            Console.WriteLine("Geef mij uw zin.");

            string zin = Console.ReadLine();
            char[] convertedZin = zin.ToLower().ToCharArray();

            return convertedZin;
        }

        private static int GetKey()
        {
            Console.WriteLine("Geef mij uw sleutel. (1-26)");
            int key = Convert.ToInt32(Console.ReadLine());

            return key;
        }

        // Single Responsability: Een methode zou maar 1 ding moeten doen
        // Heeft een methode data nodig? Vraag dan om deze data mbv input parameters ipv deze data zelf te gaan zoeken.
        private static string Encrypt(char[] charArray, int key)
        {
            char[] encryptedArray = PerformCrypt(charArray, key);
            return new string(encryptedArray).ToUpper();
        }

        private static string Decrypt(char[] charArray, int key)
        {
            int decryptKey = Alfabet.Length - key;
            char[] decryptedArray = PerformCrypt(charArray, decryptKey);
            return new string(decryptedArray).ToLower();
        }

        private static char[] PerformCrypt(char[] charArray, int key)
        {
            char[] cryptedArray = new char[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    continue;
                }

                int positionInAlfabet = Alfabet.IndexOf(charArray[i]);
                int newPositionInAlfabet = positionInAlfabet + key;

                if (newPositionInAlfabet >= Alfabet.Length)
                {
                    newPositionInAlfabet -= Alfabet.Length;
                }

                cryptedArray[i] = Alfabet[newPositionInAlfabet];
            }
            return cryptedArray;
        }
    }
}