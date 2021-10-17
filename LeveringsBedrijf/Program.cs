using System;
using System.Linq;

namespace LeveringsBedrijf
{
    class Program
    {
        // TODO: Maak methodes zoveel mogelijk private
        public static int GetGewicht()
        {
            Console.WriteLine("Geef gewicht pakket");
            int gewichtInKg = Convert.ToInt32(Console.ReadLine());
            return gewichtInKg;
        }

        /*
         * TODO: Deze opzet van deze methode is goed. Controleren of de code in kwestie bestaat. Goede reflex
         * Maar de methode doet 2 dingen. Een postcode opvragen en deze controleren. Deze verantwoordelijkheden zouden gesplitst moeten worden.
         * Ik zou aanraden om deze method een bool te laten returnen en input parameter(s) toe te voegen. Dat verhoogt de herbruikbaarheid en volgt Single Responsabilility
         * Bv. int GetPostal -> bool PostalCodeExists(int postal)
         */

        public static int GetPostal()
        {
            // Todo: duplicate code
            int[] postcode = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Naar welke postcode wenst u dit pakket te versturen(1-10)");
            int postal = Convert.ToInt32(Console.ReadLine());


            // TODO: Deze lus en if check kan ingekort worden naar if (postcode.Contains(postal) { ... }
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

        // TODO: Een Get methode hoort een waarde terug te geven. 
        // TODO: Laat deze methode totaal returnen en print deze waarde in main of een aparte methode
        public static void GetPrice()
        {
            // Todo: duplicate code -> Postcode. Verhoog de scope van deze variabele.
            int[] postcode = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] prijsDeKg = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int totaal = 0;
            int postal = GetPostal();

            for (int i = 0; i < prijsDeKg.Length; i++)
            {
                // TODO: Deze if/else kan ingekort worden naar if(postal == postalcode) {...}    
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
