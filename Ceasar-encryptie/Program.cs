using System;

namespace Ceasar_encryptie
{
    internal class Program
    {
        private const string alfabet = "abcdefghijklmnopqrstuvwxyz";

        private static void Main(string[] args)
        {
            //aanmaak zin met omzet naar char
            Console.WriteLine("Geef mij uw zin.");
            string zin = Console.ReadLine();
            char[] convertedZin = zin.ToLower().ToCharArray();

            string encryptedString = Encrypt(convertedZin, 3);
            Console.WriteLine(encryptedString);

            Console.ReadLine();
        }

        // Single Responsability: Een methode zou maar 1 ding moeten doen
        // Heeft een methode data nodig? Vraag dan om deze data mbv input parameters ipv deze data zelf te gaan zoeken.
        public static string Encrypt(char[] charArray, int key)
        {
            char[] encryptedArray = new char[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    continue;
                }

                int positionInAlfabet = alfabet.IndexOf(charArray[i]);
                int newPositionInAlfabet = positionInAlfabet + key;

                if (newPositionInAlfabet >= alfabet.Length)
                {
                    newPositionInAlfabet = newPositionInAlfabet - alfabet.Length;
                }

                encryptedArray[i] = alfabet[newPositionInAlfabet];
            }

            return new string(encryptedArray).ToUpper();
        }

        public void Decrypt(char[] charArray, int key)
        {
        }
    }
}