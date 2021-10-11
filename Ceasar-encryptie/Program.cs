﻿using System;

namespace Ceasar_encryptie
{
    internal class Program
    {
        private const string alfabet = "abcdefghijklmnopqrstuvwxyz";

        private static void Main(string[] args)
        {
            Console.WriteLine("Encrypt:");
            string encryptedString = Encrypt(ConvertedZin(), GetKey());
            Console.WriteLine("Decrypt:");
            string decryptedstring = Decrypt(ConvertedZin(), GetKey());
            Console.WriteLine("");
            Console.WriteLine($"encrypt: {encryptedString}");
            Console.WriteLine($"decrypt: {decryptedstring}");

            Console.ReadLine();
        }

        public static char[] ConvertedZin()
        {
            //aanmaak zin met omzet naar char
            Console.WriteLine("Geef mij uw zin.");
            string zin = Console.ReadLine();
            char[] convertedZin = zin.ToLower().ToCharArray();
            return convertedZin;
        }

        public static int GetKey()
        {
            Console.WriteLine("Geef mij uw sleutel. (1-26)");
            int key = Convert.ToInt32(Console.ReadLine());
            return key;
        }

        // Single Responsability: Een methode zou maar 1 ding moeten doen
        // Heeft een methode data nodig? Vraag dan om deze data mbv input parameters ipv deze data zelf te gaan zoeken.
        public static string Encrypt(char[] charArray, int key)
        {
            char[] encryptedArray = Crypt(charArray, key);
            return new string(encryptedArray).ToUpper();
        }

        public static string Decrypt(char[] charArray, int key)
        {
            int decryptKey = alfabet.Length - key;
            char[] decryptedArray = Crypt(charArray, decryptKey);
            return new string(decryptedArray).ToLower();
        }

        private static char[] Crypt(char[] charArray, int key)
        {
            char[] decryptedArray = new char[charArray.Length];

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

                decryptedArray[i] = alfabet[newPositionInAlfabet];
            }
            return decryptedArray;
        }
    }
}