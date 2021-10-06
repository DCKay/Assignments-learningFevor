using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveringsBedrijf
{
    class Program
    {
        public static int GetGewicht()
        {
            Console.WriteLine("Geef gewicht pakket");
            int gewichtInKg = Convert.ToInt32(Console.ReadLine());
            return gewichtInKg;
        }

        public static int GetPostal()
        {
            int[] postcode = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Naar welke postcode wenst u dit pakket te versturen(1-10)");
            int postal = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < postcode.Length; i++)
            {
                if (postcode.Contains(postal))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ongekende postcode, geef geldige postcode(1-10)");
                    postal = Convert.ToInt32(Console.ReadLine());
                }

            }

            return postal;
        }

        public static void GetPrice()
        {
            int[] postcode = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] prijsDeKg = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int totaal = 0;
            int postal = GetPostal();

            for (int i = 0; i < prijsDeKg.Length; i++)
            {
                if (postal != postcode[i])
                {
                    continue;
                }
                else
                {
                    totaal = GetGewicht() * prijsDeKg[i];
                }

            }

            Console.WriteLine($"\nDit zal {totaal} euro kosten.");
        }

        static void Main(string[] args)
        {
            GetPrice();

            Console.ReadLine();
        }
    }
}
