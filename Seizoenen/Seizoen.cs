using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seizoenen
{
    enum Seizoenen
    {
        Onbekend,
        Winter,
        Lente,
        Zomer,
        Herfst
    }
    class Seizoen
    {
        public static void Run()
        {
            int maand;
            do
            {
                Console.WriteLine("Geef mij een maandnummler");
                maand = Convert.ToInt32(Console.ReadLine());
                Seizoenen seizoen;

                switch (maand)
                {
                    case 1:
                    case 2:
                    case 3:
                        seizoen = Seizoenen.Winter;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        seizoen = Seizoenen.Lente;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        seizoen = Seizoenen.Zomer;
                        break;
                    case 10:
                    case 11:
                    case 12:
                        seizoen = Seizoenen.Herfst;
                        break;
                    default:
                        seizoen = Seizoenen.Onbekend;
                        break;
                }

                if (seizoen == Seizoenen.Herfst || seizoen == Seizoenen.Winter)
                {
                    Console.WriteLine("Dit is een koude maand.");
                }
                else if (seizoen == Seizoenen.Lente || seizoen == Seizoenen.Zomer)
                {
                    Console.WriteLine("Dit is een warme maand.");
                }
                else
                {
                    Console.WriteLine("Onbekend.");
                }

            } while (maand != 0);

        }
    }
}
