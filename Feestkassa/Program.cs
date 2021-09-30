using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feestkassa
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0;

            Console.WriteLine("Frietjes?");
            int frieten = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tussenprijs= {frieten * 20} EURO");
            Console.WriteLine("Koninginenhapjes?");
            int koninginenhapje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tussenprijs= {frieten * 20} EURO + {koninginenhapje * 10} EURO");
            Console.WriteLine("Ijsjes?");
            int ijskes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tussenprijs= {frieten * 20} EURO + {koninginenhapje * 10} EURO + {ijskes * 3} EURO");
            Console.WriteLine("Dranken?");
            int drank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tussenprijs= {frieten * 20} EURO + {koninginenhapje * 10} EURO + {ijskes * 3} EURO + {drank * 2} EURO");
            Console.WriteLine($"\nHet totaal te betalen bedrag is {totaal = (frieten * 20) + (koninginenhapje * 10) + (ijskes * 3) + (drank * 2) } EURO.");
            Console.ReadLine();
        }
    }
}
