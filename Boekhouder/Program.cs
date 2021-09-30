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
            int somePositive = 0;
            int ingave = 0;
            double count = 0;
            do
            {
                balans = balans + ingave;
                Console.WriteLine($"Uw balans: {balans}\nSom Negatieve input: {somNegative}\nSom Positieve input: {somePositive}\nHet Gemiddelde: {balans / count}");
                Console.WriteLine("Voer een getal in (0000=stop)");
                ingave = Convert.ToInt32(Console.ReadLine());
                if (ingave != 0000)
                {
                    count++;
                }
                if (ingave >= 0)
                {
                    somNegative += ingave;
                }
                else if (ingave <= 0)
                {
                    somePositive += ingave;
                }
                
            } while (ingave != 0000);
            Console.Clear();
            Console.WriteLine($"Uw balans: {balans}\nSom Negatieve input: {somNegative}\nSom Positieve input: {somePositive}\nHet Gemiddelde: {balans / count}");
            Console.ReadLine();
        }
    }
}
