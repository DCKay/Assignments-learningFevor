using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekhouder
{
    class Program
    {
        static void Main(string[] args)
        {
            int balans = 0;
            int somNegative = 0;

            //TODO: Typo ->SomPositief
            int somePositive = 0;
            int ingave = 0;
            double count = 0;

            do
            {
                balans = balans + ingave;

                // TODO: Dit is moeilijk leesbaar / onderhoudbaar. Gebruik een nieuwe console WriteLine voror elke /n.
                // Denk ook aan Single Responsability. Kan je de code die berekeningen doet en informatie print gescheiden houden met methodes?
                Console.WriteLine($"Uw balans: {balans}\nSom Negatieve input: {somNegative}\nSom Positieve input: {somePositive}\nHet Gemiddelde: {balans / count}");
                Console.WriteLine("Voer een getal in (0000=stop)");
                ingave = Convert.ToInt32(Console.ReadLine());

                if (ingave != 0000)
                {
                    count++;
                }
                if (ingave >= 0)
                {

                    // TODO: SomNegatief en SomPositief moeten hier van plaats wisselen
                    somNegative += ingave;
                }

                // TODO: Dit mag gewoon else worden
                else if (ingave <= 0)
                {
                    somePositive += ingave;
                }
                
            } while (ingave != 0000);

            Console.Clear();

            // TODO: Duplicate code als hierboven. Gebruik hiervoor een methode
            Console.WriteLine($"Uw balans: {balans}\nSom Negatieve input: {somNegative}\nSom Positieve input: {somePositive}\nHet Gemiddelde: {balans / count}");
            Console.ReadLine();
        }
    }
}
