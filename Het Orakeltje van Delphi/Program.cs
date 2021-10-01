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
            char geslacht = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Wat is uw leeftijd?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            int gemiddeldeMan = 120;
            int gemiddeldeVrouw = 150;
            Random mygen = new Random();

            switch (geslacht)
            {
                case 'v':
                    int dood = mygen.Next(5, gemiddeldeVrouw - leeftijd);
                    Console.WriteLine($"Je zal nog {dood} jaar leven.");
                    break;
                case 'm':
                    dood = mygen.Next(5, gemiddeldeMan - leeftijd);
                    Console.WriteLine($"Je zal nog {dood} jaar leven.");
                    break;
                default:
                    Console.WriteLine("Ongekende optie");
                    break;
            }

            Console.ReadLine();
        }
    }
}
