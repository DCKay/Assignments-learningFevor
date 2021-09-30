using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_Orakeltje_van_Delphi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies het volgende: \nv: vrouw \nm: man");
            string geslacht = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wat is uw leeftijd?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            int gemiddeldeMan = 120;
            int gemiddeldeVrouw = 150;
            Random mygen = new Random();
            int getal1 = 0;
            switch (geslacht)
            {
                case "v":
                    getal1 = mygen.Next(5, gemiddeldeVrouw - leeftijd);
                    Console.WriteLine($"Je zal nog {getal1} jaar leven.");
                    break;
                case "m":
                    getal1 = mygen.Next(5, gemiddeldeMan - leeftijd);
                    Console.WriteLine($"Je zal nog {getal1} jaar leven.");
                    break;
                default:
                    Console.WriteLine("Ongekende optie");
                    break;
            }
            Console.ReadLine();
        }
    }
}
