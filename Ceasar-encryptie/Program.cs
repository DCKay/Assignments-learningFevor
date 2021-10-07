using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceasar_encryptie
{
    class Program
    {
        static void Main(string[] args)
        {
            //aanmaak zin met omzet naar char
            Console.WriteLine("Gef mij uw zin.");
            string zin = Convert.ToString(Console.ReadLine());
            char[] convertedZin = zin.ToCharArray();

            char[] encrypt = new char[26];
            char[] decrypt = new char[26];
            int x = 0;



            for (int i = 0; i < encrypt.Length; i++)
            {
                encrypt[i] = (char)(97 + i);
                decrypt[i] = encrypt[i];
            }

            for (int i = 0; i < convertedZin.Length; i++)
            {
                convertedZin[i] = encrypt[i];
            }

            string newZin = new string(convertedZin);
            Console.WriteLine(newZin);

            Console.ReadLine();
        }
    }
}
