using System;

namespace Raad_het_getal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TODO: Declaratie & Assignment kunnen op 1 lijn.
            Random rand = new Random();
            int getal;
            getal = rand.Next(0, 100);

            // TODO: Probeer variabelen zo dicht mogelijk te initialiseren waar ze nodig zijn
            int poging = 0;
            string pogingString;

            int aantalPogingen = 0;
            bool gevonden = false;

            while (!gevonden)
            {
                aantalPogingen++;

                // TODO: Er gebeurt geen controle of een getal tussen 0 en 100 ligt
                Console.WriteLine("Geef een getal tussen 0 en 100");

                // TODO: Onderstaande 2 lijnen kunnen 1 lijn worden.
                pogingString = Console.ReadLine();
                poging = int.Parse(pogingString);

                if (getal > poging)
                {
                    Console.WriteLine("Het gezochte getal is groter, probeer opnieuw.");
                }
                else if (getal < poging)
                {
                    Console.WriteLine("Het gezochte getal is kleiner, probeer opnieuw.");
                }
                else
                    gevonden = true;
            }
            Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
            Console.ReadLine();
        }
    }
}