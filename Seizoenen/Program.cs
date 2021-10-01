using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seizoenen
{
    class Program
    {
        enum Seizoenen
        {
            Onbekend,
            Winter,
            Lente,
            Zomer,
            Herfst
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Geef mij een maandnummer");
            int maand = Convert.ToInt32(Console.ReadLine());
            string lente;
            string zomer;
            string herfst;
            string winter;

            switch (maand)
            {
                default:
                    Console.WriteLine("U heeft Ongekend ingegeven.");
                    break;
                case 3:
                case 4:
                case 5:
                    lente = Convert.ToString(Seizoenen.Lente);
                    Console.WriteLine($"Seizoen: {lente}");
                    if (lente == lente)
                    {
                        Console.WriteLine("Dit is een warme maand.");
                    }
                    break;
                case 6:
                case 7:
                case 8:
                    zomer = Convert.ToString(Seizoenen.Zomer);
                    Console.WriteLine($"Seizoen: {zomer}");
                    if (zomer == zomer)
                    {
                        Console.WriteLine("Dit is een warme maand.");
                    }
                    break;
                case 9:
                case 10:
                case 11:
                    herfst = Convert.ToString(Seizoenen.Herfst);
                    Console.WriteLine($"Seizoen: {herfst}");
                    if (herfst == herfst)
                    {
                        Console.WriteLine("Dit is een koude maand.");
                    }
                    break;
                case 12:
                case 1:
                case 2:
                    winter = Convert.ToString(Seizoenen.Winter);
                    Console.WriteLine($"Seizoen: {winter}");
                    if (winter == winter)
                    {
                        Console.WriteLine("Dit is een koude maand.");
                    }
                    break;                 
            }

            Console.ReadLine();
        }
    }
}
